Public Class Question
    Dim pos As List(Of Point)
    Dim time As Integer
    Public result As Boolean
    Dim cans As Byte

    Sub New(ByVal getpos As List(Of Point), ByVal q As String, ByVal ans1 As String, ByVal ans2 As String, ByVal ans3 As String, ByVal ans4 As String, ByVal ca As Byte)
        InitializeComponent()
        pos = getpos
        cans = ca
        time = 0
        Qlabel.Text = q
        a1.Text = ans1
        a2.Text = ans2
        a3.Text = ans3
        a4.Text = ans4
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        result = False
        If cans = 4 And a4.Checked Then
            result = True
        End If
        If cans = 3 And a3.Checked Then
            result = True
        End If
        If cans = 2 And a2.Checked Then
            result = True
        End If
        If cans = 1 And a1.Checked Then
            result = True
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        result = False
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If time = 16 Then
            Me.Close()
            Return
        Else
            hand.X2 = pos(time).X
            hand.Y2 = pos(time).Y
            time = time + 1
        End If
    End Sub

    Private Sub Question_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Dispose()
    End Sub

    Private Sub Question_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class