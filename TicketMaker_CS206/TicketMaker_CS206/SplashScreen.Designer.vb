<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timerSplash = New System.Windows.Forms.Timer(Me.components)
        Me.pgbarSplash = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'timerSplash
        '
        Me.timerSplash.Enabled = True
        '
        'pgbarSplash
        '
        Me.pgbarSplash.Location = New System.Drawing.Point(-2, 327)
        Me.pgbarSplash.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pgbarSplash.Name = "pgbarSplash"
        Me.pgbarSplash.Size = New System.Drawing.Size(634, 38)
        Me.pgbarSplash.TabIndex = 0
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 366)
        Me.Controls.Add(Me.pgbarSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timerSplash As Timer
    Friend WithEvents pgbarSplash As ProgressBar
End Class
