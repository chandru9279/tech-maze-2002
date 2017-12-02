Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Enter up a team name and then u can play:-)")
        Else
            Dim test As New Test
            test.TName = TextBox1.Text
            test.LGN = Me
            test.Show()
            Me.Hide()
        End If
    End Sub
End Class