<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminLoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminLoginForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbReset = New System.Windows.Forms.Label()
        Me.btnAdLogout = New System.Windows.Forms.Button()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.cbViewPassword = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbAdPassword = New System.Windows.Forms.Label()
        Me.lbAdUserName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 176)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'lbReset
        '
        Me.lbReset.AutoSize = True
        Me.lbReset.BackColor = System.Drawing.Color.Transparent
        Me.lbReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReset.ForeColor = System.Drawing.Color.Fuchsia
        Me.lbReset.Location = New System.Drawing.Point(360, 140)
        Me.lbReset.Name = "lbReset"
        Me.lbReset.Size = New System.Drawing.Size(49, 16)
        Me.lbReset.TabIndex = 26
        Me.lbReset.Text = "Reset"
        '
        'btnAdLogout
        '
        Me.btnAdLogout.BackColor = System.Drawing.Color.White
        Me.btnAdLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdLogout.FlatAppearance.BorderSize = 2
        Me.btnAdLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdLogout.Location = New System.Drawing.Point(335, 179)
        Me.btnAdLogout.Name = "btnAdLogout"
        Me.btnAdLogout.Size = New System.Drawing.Size(55, 26)
        Me.btnAdLogout.TabIndex = 29
        Me.btnAdLogout.Text = "Logout"
        Me.btnAdLogout.UseVisualStyleBackColor = False
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdmin.Location = New System.Drawing.Point(133, 12)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(257, 29)
        Me.lbAdmin.TabIndex = 30
        Me.lbAdmin.Text = "Administrator's Login"
        '
        'cbViewPassword
        '
        Me.cbViewPassword.AutoSize = True
        Me.cbViewPassword.BackColor = System.Drawing.Color.Transparent
        Me.cbViewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbViewPassword.ForeColor = System.Drawing.Color.Fuchsia
        Me.cbViewPassword.Location = New System.Drawing.Point(207, 140)
        Me.cbViewPassword.Name = "cbViewPassword"
        Me.cbViewPassword.Size = New System.Drawing.Size(132, 20)
        Me.cbViewPassword.TabIndex = 25
        Me.cbViewPassword.Text = "View Password"
        Me.cbViewPassword.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(207, 59)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(222, 20)
        Me.txtUsername.TabIndex = 21
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(207, 95)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(222, 20)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lbAdPassword
        '
        Me.lbAdPassword.AutoSize = True
        Me.lbAdPassword.BackColor = System.Drawing.Color.Transparent
        Me.lbAdPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdPassword.Location = New System.Drawing.Point(118, 98)
        Me.lbAdPassword.Name = "lbAdPassword"
        Me.lbAdPassword.Size = New System.Drawing.Size(61, 13)
        Me.lbAdPassword.TabIndex = 23
        Me.lbAdPassword.Text = "Password"
        '
        'lbAdUserName
        '
        Me.lbAdUserName.AutoSize = True
        Me.lbAdUserName.BackColor = System.Drawing.Color.Transparent
        Me.lbAdUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdUserName.Location = New System.Drawing.Point(118, 62)
        Me.lbAdUserName.Name = "lbAdUserName"
        Me.lbAdUserName.Size = New System.Drawing.Size(69, 13)
        Me.lbAdUserName.TabIndex = 24
        Me.lbAdUserName.Text = "User Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(273, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 25)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.White
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOK.FlatAppearance.BorderSize = 2
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(211, 179)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(56, 25)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'adminLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 216)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbReset)
        Me.Controls.Add(Me.btnAdLogout)
        Me.Controls.Add(Me.lbAdmin)
        Me.Controls.Add(Me.cbViewPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lbAdPassword)
        Me.Controls.Add(Me.lbAdUserName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "adminLoginForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbReset As Label
    Friend WithEvents btnAdLogout As Button
    Friend WithEvents lbAdmin As Label
    Friend WithEvents cbViewPassword As CheckBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lbAdPassword As Label
    Friend WithEvents lbAdUserName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
End Class
