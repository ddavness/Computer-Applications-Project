Public Class DiscordHelp
    Private Sub Global_Load() Handles MyBase.Load
        ' trancar valores
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        System.Diagnostics.Process.Start("https://support.discordapp.com/hc/en-us/articles/219470277-Getting-Started")
    End Sub
End Class