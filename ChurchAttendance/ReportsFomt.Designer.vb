<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.GeneralReport = New System.Windows.Forms.TabControl()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Individual = New System.Windows.Forms.TabPage()
        Me.Critecal = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GeneralReport.SuspendLayout()
        Me.General.SuspendLayout()
        Me.Individual.SuspendLayout()
        Me.Critecal.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralReport
        '
        Me.GeneralReport.AccessibleName = ""
        Me.GeneralReport.Controls.Add(Me.General)
        Me.GeneralReport.Controls.Add(Me.Individual)
        Me.GeneralReport.Controls.Add(Me.Critecal)
        Me.GeneralReport.Location = New System.Drawing.Point(13, 8)
        Me.GeneralReport.Name = "GeneralReport"
        Me.GeneralReport.SelectedIndex = 0
        Me.GeneralReport.Size = New System.Drawing.Size(856, 488)
        Me.GeneralReport.TabIndex = 0
        '
        'General Report
        '
        Me.General.Controls.Add(Me.DataGridView1)
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "TabPage1"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(848, 462)
        Me.General.TabIndex = 0
        Me.General.Text = "TabPage1"
        Me.General.UseVisualStyleBackColor = True
        '
        'Individual Report
        '
        Me.Individual.Controls.Add(Me.txtSearch)
        Me.Individual.Controls.Add(Me.btnSearch)
        Me.Individual.Controls.Add(Me.DataGridView2)
        Me.Individual.Location = New System.Drawing.Point(4, 22)
        Me.Individual.Name = "TabPage2"
        Me.Individual.Padding = New System.Windows.Forms.Padding(3)
        Me.Individual.Size = New System.Drawing.Size(848, 462)
        Me.Individual.TabIndex = 1
        Me.Individual.Text = "TabPage2"
        Me.Individual.UseVisualStyleBackColor = True
        '
        'Critecal Report
        '
        Me.Critecal.Controls.Add(Me.DataGridView3)
        Me.Critecal.Location = New System.Drawing.Point(4, 22)
        Me.Critecal.Name = "TabPage3"
        Me.Critecal.Padding = New System.Windows.Forms.Padding(3)
        Me.Critecal.Size = New System.Drawing.Size(848, 462)
        Me.Critecal.TabIndex = 2
        Me.Critecal.Text = "TabPage3"
        Me.Critecal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(839, 395)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 54)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(836, 402)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 54)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(836, 402)
        Me.DataGridView3.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(544, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(625, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(217, 20)
        Me.txtSearch.TabIndex = 2
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 501)
        Me.Controls.Add(Me.GeneralReport)
        Me.Name = "ReportsForm"
        Me.Text = "ReportsFomt"
        Me.GeneralReport.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralReport As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
End Class
