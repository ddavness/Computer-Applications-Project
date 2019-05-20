Imports System.IO ' Métodos de manipulação de ficheiros (IO = Input/Output)

Module Base ' modulo base para manipulação de ficheiros
    Public Enum TipoConsulta ' enumeração, para substituir "strings de comando"
        Leitura
        Escrita
    End Enum

    Friend Function CheckFicheiro(ByVal f As String, ByVal tipo As TipoConsulta) ' verifica que o ficheiro com a path dada existe. Caso contrário, cria o ficheiro.
        Try
            If tipo = TipoConsulta.Escrita Then
                Return My.Computer.FileSystem.OpenTextFileWriter(f, False)
            Else
                Return My.Computer.FileSystem.OpenTextFileReader(f)
            End If
        Catch
            File.Create(f).Close()
            If tipo = TipoConsulta.Escrita Then
                Return My.Computer.FileSystem.OpenTextFileWriter(f, False)
            Else
                Return My.Computer.FileSystem.OpenTextFileReader(f)
            End If
        End Try
    End Function
End Module

' =================== FICHEIRO CONFIG.APPCFG =================== '
' ============================================================== '
' ============================================================== '

Module AppConfig ' manipulação do ficheiro Config.appcfg
    Dim ficheiro As String = Application.LocalUserAppDataPath & "\Config.appcfg" ' ficheiro de configuraçoes

    Dim configs As New Dictionary(Of String, String)

    Public Sub LerTudo()
        configs = New Dictionary(Of String, String)
        Dim cLeitura As StreamReader = Base.CheckFicheiro(ficheiro, TipoConsulta.Leitura)
        Dim linha As Integer = 0

        While Not cLeitura.EndOfStream
            Dim decode As String() = cLeitura.ReadLine().Split(Chr(0))
            configs.Add(decode(0), decode(1))
        End While

        cLeitura.Close()
    End Sub

    Public Sub GuardarTudo()
        Dim encode As String = ""

        For Each i In configs.Keys
            encode = encode & i & Chr(0) & configs(i) & Chr(13)
        Next
        If encode <> "" Then
            encode = encode.Remove(encode.Length - 1)
        End If
        Dim cEscrita As StreamWriter = Base.CheckFicheiro(ficheiro, TipoConsulta.Escrita)
        cEscrita.Write(encode)
        cEscrita.Close()
    End Sub

    Public Property Definicao(nome As String, Optional valor As Object = "") As String ' para 
        Get
            If configs.ContainsKey(nome) Then
                Return configs.Item(nome)
            End If

            Return valor
        End Get

        Set(val As String)
            Dim a As Boolean
            If configs.ContainsKey(nome) Then
                a = True
                configs.Item(nome) = val
            Else
                configs.Add(nome, val)
            End If
        End Set
    End Property
End Module

' =================== FICHEIRO APPDADOS.AGDA =================== '
' ============================================================== '
' ============================================================== '

Public Module LembreteManagement
    Dim lembretes As Lembrete() = {}
    Dim ficheiro As String = Application.LocalUserAppDataPath & "\AppDados.agda"

    Public Sub LerTudo()
        lembretes = {}
        Dim cLeitura As StreamReader = Base.CheckFicheiro(ficheiro, TipoConsulta.Leitura)
        Dim linha As Integer = 0
        Dim sucesso As Boolean = True

        While Not cLeitura.EndOfStream
            Dim cLinha As String = cLeitura.ReadLine()
            Dim d, a As Date
            Dim n, desc As String
            Dim sd, sa As Boolean

            If cLinha = Chr(0) Then
                n = cLeitura.ReadLine()
                desc = cLeitura.ReadLine()
                sd = Date.TryParse(cLeitura.ReadLine(), d)
                sa = Date.TryParse(cLeitura.ReadLine(), a)

                ReDim Preserve lembretes(linha)
                lembretes(linha) = New Lembrete(n, desc, d, a)

                sucesso = sucesso And sd And sa
            Else
                sucesso = False
                ' descartar o evento
            End If

            linha = linha + 1
        End While

        cLeitura.Close()

        Array.Sort(lembretes) ' por causa do IComparable, definido abaixo, vai ordenar os lembretes por data/hora

        If Not sucesso Then
            MsgBox("Parece que houve um erro na codificação dos lembretes. Alguns podem não ter sido carregados." & Chr(13) & "Pedimos desculpa!", MsgBoxStyle.Critical, "E-Agenda by Deed")
        End If
    End Sub

    Public Sub GuardarTudo()
        Dim encode As String = ""

        For i = 0 To lembretes.Length - 1
            If Not IsNothing(ListaLembretes(i)) Then
                encode = encode & lembretes(i).ToString() & Chr(13)
            End If
        Next

        If encode <> "" Then
            encode = encode.Remove(encode.Length - 1)
        End If

        Dim cEscrita As StreamWriter = Base.CheckFicheiro(ficheiro, TipoConsulta.Escrita)
        cEscrita.Write(encode)
        cEscrita.Close()
    End Sub

    Public Property ListaLembretes As Lembrete()
        Get
            Return (lembretes)
        End Get
        Set(l As Lembrete())
            lembretes = l
        End Set
    End Property
End Module

Public Class Lembrete
    Implements IComparable(Of Lembrete) ' serve para nos ajudar a ordenar os lembretes

    Public Function CompareTo(outro As Lembrete) As Integer _
        Implements IComparable(Of Lembrete).CompareTo
        Return Date.Compare(Me.Data, outro.Data) ' Comparar datas
    End Function

    Dim nom, desc As String ' nome e descricao
    Dim d, a As Date ' data e data de aviso
    Dim num As UShort

    Public Property Titulo As String
        Get
            Return nom
        End Get
        Set(ByVal val As String)
            nom = val
        End Set
    End Property

    Public Property Descricao As String
        Get
            Return desc
        End Get
        Set(ByVal val As String)
            desc = val
        End Set
    End Property

    Public Property Data As Date
        Get
            Return d
        End Get
        Set(ByVal val As Date)
            d = val
        End Set
    End Property

    Public Property DataNotificacao As Date
        Get
            Return a
        End Get
        Set(ByVal val As Date)
            a = val
        End Set
    End Property

    Public ReadOnly Property Id As UShort
        Get
            Return num
        End Get
    End Property

    Public Function NotifTick(RealEventDate) As Long ' se falso, utiliza a data/hora de aviso como base
        If RealEventDate Then
            ' hora do evento
            Return (d.Ticks / 10000 - Date.Now.Ticks / 10000) ' 10000 ticks = 1ms
        Else
            ' hora de aviso
            Return (a.Ticks / 10000 - Date.Now.Ticks / 10000)
        End If
    End Function

    Public Sub New(ByVal nom1 As String, ByVal desc1 As String, ByVal d1 As Date, ByVal a1 As Date)
        nom = nom1
        desc = desc1
        d = d1
        a = a1
    End Sub

    Public Overrides Function ToString() As String
        Dim e As String = Chr(13)
        Return Chr(0) & e & nom & e & desc & e & d.ToString & e & a.ToString ' devolve o lembrete codificado em string para ser guardado
    End Function
End Class