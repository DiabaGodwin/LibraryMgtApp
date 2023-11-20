<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 41)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LibraryMgtApp.My.Resources.Resources.ktu_logo1
        Me.PictureBox2.Location = New System.Drawing.Point(619, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "STUDENT"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(24, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(515, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(174, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 27)
        Me.TextBox3.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox1.Location = New System.Drawing.Point(329, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 23)
        Me.ComboBox1.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblName.Location = New System.Drawing.Point(26, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(329, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(174, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(515, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.Snow
        Me.btnLogin.Location = New System.Drawing.Point(309, 90)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(114, 33)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Update"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(443, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Location = New System.Drawing.Point(178, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 33)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.OrangeRed
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Snow
        Me.Button3.Location = New System.Drawing.Point(55, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 33)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 134)
        Me.Panel2.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(212, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "STUDENT DETAILS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(248, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "STUDENT LIST"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(2, 200)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(659, 165)
        Me.Panel3.TabIndex = 16
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.OrangeRed
        Me.Back.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Back.ForeColor = System.Drawing.Color.White
        Me.Back.Location = New System.Drawing.Point(266, 380)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(98, 24)
        Me.Back.TabIndex = 0
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 416)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.Text = "Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Back As Button
End Class
