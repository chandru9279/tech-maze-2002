Public Class Nter

    Private Sub HardBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.HardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QDS)

    End Sub

    Private Sub Nter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QDS.Hard' table. You can move, or remove it, as needed.
        Me.HardTableAdapter.Fill(Me.QDS.Hard)
        'TODO: This line of code loads data into the 'QDS.Hard' table. You can move, or remove it, as needed.
        Me.HardTableAdapter.Fill(Me.QDS.Hard)

    End Sub

    Private Sub HardBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QDS)

    End Sub
End Class