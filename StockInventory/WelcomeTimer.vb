Imports System.Data.SqlClient
Public Class WelcomeTimer
    Dim WithEvents aTimer As New System.Windows.Forms.Timer 'could have been done in the Designer
    Private Sub WelcomeText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ""
    End Sub
    Private Sub aTimer_Tick(ByVal sender As Object, _
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        Label2.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, _
                            ByVal e As System.EventArgs) Handles Me.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub
End Class