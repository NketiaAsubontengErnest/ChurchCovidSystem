<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPassword))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnResetExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lbConfirmNewPass = New System.Windows.Forms.Label()
        Me.txtConfirmNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbNewPass = New System.Windows.Forms.Label()
        Me.lbCurrentPass = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(30, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 128)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'btnResetExit
        '
        Me.btnResetExit.BackColor = System.Drawing.Color.White
        Me.btnResetExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnResetExit.FlatAppearance.BorderSize = 2
        Me.btnResetExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResetExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResetExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetExit.Location = New System.Drawing.Point(291, 181)
        Me.btnResetExit.Name = "btnResetExit"
        Me.btnResetExit.Size = New System.Drawing.Size(71, 29)
        Me.btnResetExit.TabIndex = 20
        Me.btnResetExit.Text = "Exit"
        Me.btnResetExit.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.FlatAppearance.BorderSize = 2
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(214, 181)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(71, 29)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lbConfirmNewPass
        '
        Me.lbConfirmNewPass.AutoSize = True
        Me.lbConfirmNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lbConfirmNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConfirmNewPass.Location = New System.Drawing.Point(152, 141)
        Me.lbConfirmNewPass.Name = "lbConfirmNewPass"
        Me.lbConfirmNewPass.Size = New System.Drawing.Size(155, 15)
        Me.lbConfirmNewPass.TabIndex = 21
        Me.lbConfirmNewPass.Text = "Confirm New Password"
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(320, 138)
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(181, 20)
        Me.txtConfirmNewPassword.TabIndex = 17
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(320, 100)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(181, 20)
        Me.txtNewPassword.TabIndex = 15
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(320, 64)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(181, 20)
        Me.txtCurrentPassword.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 18
        '
        'lbNewPass
        '
        Me.lbNewPass.AutoSize = True
        Me.lbNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lbNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewPass.Location = New System.Drawing.Point(152, 103)
        Me.lbNewPass.Name = "lbNewPass"
        Me.lbNewPass.Size = New System.Drawing.Size(101, 15)
        Me.lbNewPass.TabIndex = 16
        Me.lbNewPass.Text = "New Password"
        '
        'lbCurrentPass
        '
        Me.lbCurrentPass.AutoSize = True
        Me.lbCurrentPass.BackColor = System.Drawing.Color.Transparent
        Me.lbCurrentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCurrentPass.Location = New System.Drawing.Point(152, 65)
        Me.lbCurrentPass.Name = "lbCurrentPass"
        Me.lbCurrentPass.Size = New System.Drawing.Size(120, 15)
        Me.lbCurrentPass.TabIndex = 14
        Me.lbCurrentPass.Text = "Current Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "PASSWORD RESET FORM"
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnResetExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lbConfirmNewPass)
        Me.Controls.Add(Me.txtConfirmNewPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbNewPass)
        Me.Controls.Add(Me.lbCurrentPass)
        Me.Name = "ResetPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnResetExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lbConfirmNewPass As Label
    Friend WithEvents txtConfirmNewPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbNewPass As Label
    Friend WithEvents lbCurrentPass As Label
    Friend WithEvents Label1 As Label
End Class
