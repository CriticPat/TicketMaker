Imports System.Drawing.Text
Public Class LoginScreen
    Dim passwarn As String, userwarn As String
    Dim acceptpass As Boolean = False
    Dim acceptuser As Boolean = False
    Private pfc As Object

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This function enables custom fonts for labels
        Dim pfc As New PrivateFontCollection
        pfc.AddFontFile("SpaceGrotesk-Regular.ttf")
        lblLoginInfo.Font = New Font(pfc.Families(0), 12.5, FontStyle.Bold)
        lblUser.Font = New Font(pfc.Families(0), 8.25, FontStyle.Italic)
        lblPassword.Font = New Font(pfc.Families(0), 8.25, FontStyle.Italic)
        lblNewAccount.Font = New Font(pfc.Families(0), 9, FontStyle.Regular)
        lnlblRegister.Font = New Font(pfc.Families(0), 9, FontStyle.Regular)

        'This will change the text from the txtUser and txtPassword
        txtUser.Text = "Enter your username"
        txtUser.ForeColor = Color.Gray
        txtUser.Font = New Font(pfc.Families(0), 10, FontStyle.Regular)

        txtPassword.Text = "Enter your password"
        txtPassword.ForeColor = Color.Gray
        txtPassword.Font = New Font(pfc.Families(0), 10, FontStyle.Regular)
    End Sub
    Private Sub lnlblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnlblRegister.LinkClicked
        Me.Close()
        UserManagement.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPassword.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'If the password character length is less than 8, the userwarning text will change
        If txtPassword.TextLength >= 8 Then
            If txtPassword.Text = "Enter your password" Then
                passwarn = "Invalid Password. It must contain 8 characters."
                txtPassword.PasswordChar = ""

            Else
                acceptpass = True
                passwarn = ""

            End If
        Else
            passwarn = "Invalid Password. It must contain 8 characters."
            txtPassword.PasswordChar = "*"

        End If
        'If the User text length is less than 3 then user warning will change
        If txtUser.TextLength >= 3 Then
            If txtUser.Text = "Enter your username" Then
                userwarn = "Invalid Username. Username must contain at least 3 characters."

            Else
                acceptuser = True
                userwarn = ""
            End If
        Else
            userwarn = "Invalid Username. Username must contain at least 3 characters."
        End If
        ' If the acceptuser and accept password are true, it will show the next form
        If acceptpass And acceptuser Then
            Me.Hide()
            UserManagement.Show()
        Else
            ' Concatenate the user and password warnings into a single string
            Dim warningMessage As String = passwarn & vbCrLf & userwarn
            ' Display the combined warning message
            MsgBox(warningMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Input")
        End If

    End Sub
    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            txtUser.Text = "Enter your username"
            txtUser.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtUser.ForeColor = Color.Gray AndAlso txtUser.Text = "Enter your username" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If

    End Sub
    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = "Enter your password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnShowPass_MouseDown(sender As Object, e As EventArgs) Handles btnShowPass.MouseDown
        txtPassword.PasswordChar = ""
        btnShowPass.Image = Image.FromFile("C: user\source\repos\TicketMaker_CS206\TicketMaker_CS206\bin\Debug\Show.png")
    End Sub

    Private Sub btnShowPass_MouseUp(sender As Object, e As EventArgs) Handles btnShowPass.MouseUp
        txtPassword.PasswordChar = "*"
        btnShowPass.Image = Image.FromFile("C:user\source\repos\TicketMaker_CS206\TicketMaker_CS206\bin\Debug\Hide.png")

    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtPassword.ForeColor = Color.Gray AndAlso txtPassword.Text = "Enter your password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If

    End Sub
End Class