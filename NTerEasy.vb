Public Class NTerEasy

    Private Sub QuestionsTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionsTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QuestionsTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QDS)
    End Sub

    Private Sub NTerEasy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QDS.questionsT' table. You can move, or remove it, as needed.
        Me.QuestionsTTableAdapter.Fill(Me.QDS.questionsT)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As New Nter
        a.Show()
    End Sub
End Class