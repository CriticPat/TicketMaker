Public Class UserManagement
    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click

    End Sub

    Private Sub ReturnToLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToLoginToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub UserTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.User_InfoDataSet)

    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_InfoDataSet.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.User_InfoDataSet.UserTable)

    End Sub
End Class