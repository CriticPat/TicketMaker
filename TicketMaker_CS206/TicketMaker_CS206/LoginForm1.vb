Public Class Login
    Dim acceptpass As Boolean = False
    Dim acceptuser As Boolean = False
    Dim passwarn As String, userwarn As String
    Public Property username As String

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtbPassword.TextLength >= 8 Then
            If txtbPassword.Text = "Enter your password" Then
                passwarn = "Invalid Password. It must contain 8 characters."
                txtbPassword.PasswordChar = ""

            Else
                acceptpass = True
                passwarn = ""

            End If
        Else
            passwarn = "Invalid Password. It must contain 8 characters."
            txtbPassword.PasswordChar = "*"

        End If
        If txtbUsername.TextLength >= 3 Then
            If txtbUsername.Text = "Enter your username" Then
                userwarn = "Invalid Username. Username must contain at least 3 characters."

            Else
                acceptuser = True
                userwarn = ""

            End If
        Else
            userwarn = "Invalid Username. Username must contain at least 3 characters."
        End If
        If acceptpass And acceptuser Then
            Me.Hide()
            UserManagement.Show()
        Else
            ' Concatenate the user and password warnings into a single string
            Dim warningMessage As String = passwarn & vbCrLf & userwarn
            ' Display the combined warning message
            MsgBox(warningMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Input")
        End If
        btnPassShow.Visible = True

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbUsername.Text = "Enter your username"
        txtbUsername.ForeColor = Color.Gray

        txtbPassword.Text = "Enter your password"
        txtbPassword.ForeColor = Color.Gray
        btnPassShow.Visible = False
    End Sub

    Private Sub txtbUsername_LostFocus(sender As Object, e As EventArgs) Handles txtbUsername.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtbUsername.Text) Then
            txtbUsername.Text = "Enter your username"
            txtbUsername.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtbUsername_GotFocus(sender As Object, e As EventArgs) Handles txtbUsername.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtbUsername.ForeColor = Color.Gray AndAlso txtbUsername.Text = "Enter your username" Then
            txtbUsername.Text = ""
            txtbUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbPassword_LostFocus(sender As Object, e As EventArgs) Handles txtbPassword.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtbPassword.Text) Then
            txtbPassword.PasswordChar = ""
            txtbPassword.Text = "Enter your password"
            txtbPassword.ForeColor = Color.Gray
            btnPassShow.Hide()


        End If
    End Sub
    Private Sub txtbPassword_GotFocus(sender As Object, e As EventArgs) Handles txtbPassword.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtbPassword.ForeColor = Color.Gray AndAlso txtbPassword.Text = "Enter your password" Then
            txtbPassword.Text = ""
            txtbPassword.ForeColor = Color.Black
            txtbPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtbPassword.TextChanged
        If txtbPassword.TextLength > 1 Then
            btnPassShow.Visible = True
        Else
            btnPassShow.Visible = False
        End If

    End Sub

    Private Sub btnPassShow_MouseDown(sender As Object, e As EventArgs) Handles btnPassShow.MouseDown
        txtbPassword.PasswordChar = ""
        btnPassShow.Image = Image.FromFile("C:source\repos\Project_CS206\assets\Show.png")
    End Sub
    Private Sub btnPassShow_MouseUp(sender As Object, e As EventArgs) Handles btnPassShow.MouseUp
        txtbPassword.PasswordChar = "*"
        btnPassShow.Image = Image.FromFile("C:source\repos\Project_CS206\assets\Hide.png")
    End Sub

    Private Sub btnPassShow_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPassShow.MouseDown

    End Sub

    Private Sub btnPassShow_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPassShow.MouseUp

    End Sub

    Private Sub btnPassShow_Click(sender As Object, e As EventArgs) Handles btnPassShow.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub pctbUsername_Click(sender As Object, e As EventArgs) Handles pctbUsername.Click

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
    Private Sub txbtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbPassword.KeyPress
        ' Check if the pressed key is the Enter key (ASCII value 13)
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub txtbUsername_TextChanged(sender As Object, e As EventArgs) Handles txtbUsername.TextChanged

    End Sub

    Private Sub txtbUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbUsername.KeyPress
        ' Check if the pressed key is the Enter key (ASCII value 13)
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtbUsername.Focus()
        End If
    End Sub
End Class
