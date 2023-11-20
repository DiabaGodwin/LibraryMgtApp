<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveBooksBtn = New System.Windows.Forms.Button()
        Me.BooksAuthorTxt = New System.Windows.Forms.TextBox()
        Me.EditBooksBtn = New System.Windows.Forms.Button()
        Me.ResetBooksBtn = New System.Windows.Forms.Button()
        Me.BooksPriceTxt = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.BooksDGVPanel = New System.Windows.Forms.Panel()
        Me.BooksDGV = New System.Windows.Forms.DataGridView()
        Me.BkId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BookNameTxt = New System.Windows.Forms.TextBox()
        Me.BooksPubliserTxt = New System.Windows.Forms.TextBox()
        Me.BooksQuantityTxt = New System.Windows.Forms.TextBox()
        Me.UpdateBooksBtn = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BooksDGVPanel.SuspendLayout()
        CType(Me.BooksDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(505, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(4, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(248, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Books Details"
        '
        'SaveBooksBtn
        '
        Me.SaveBooksBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.SaveBooksBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SaveBooksBtn.ForeColor = System.Drawing.Color.Snow
        Me.SaveBooksBtn.Location = New System.Drawing.Point(55, 90)
        Me.SaveBooksBtn.Name = "SaveBooksBtn"
        Me.SaveBooksBtn.Size = New System.Drawing.Size(114, 33)
        Me.SaveBooksBtn.TabIndex = 12
        Me.SaveBooksBtn.Text = "Save"
        Me.SaveBooksBtn.UseVisualStyleBackColor = False
        '
        'BooksAuthorTxt
        '
        Me.BooksAuthorTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BooksAuthorTxt.Location = New System.Drawing.Point(135, 54)
        Me.BooksAuthorTxt.Name = "BooksAuthorTxt"
        Me.BooksAuthorTxt.Size = New System.Drawing.Size(107, 27)
        Me.BooksAuthorTxt.TabIndex = 1
        '
        'EditBooksBtn
        '
        Me.EditBooksBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.EditBooksBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditBooksBtn.ForeColor = System.Drawing.Color.Snow
        Me.EditBooksBtn.Location = New System.Drawing.Point(178, 90)
        Me.EditBooksBtn.Name = "EditBooksBtn"
        Me.EditBooksBtn.Size = New System.Drawing.Size(114, 33)
        Me.EditBooksBtn.TabIndex = 11
        Me.EditBooksBtn.Text = "Edit"
        Me.EditBooksBtn.UseVisualStyleBackColor = False
        '
        'ResetBooksBtn
        '
        Me.ResetBooksBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.ResetBooksBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetBooksBtn.ForeColor = System.Drawing.Color.Snow
        Me.ResetBooksBtn.Location = New System.Drawing.Point(443, 90)
        Me.ResetBooksBtn.Name = "ResetBooksBtn"
        Me.ResetBooksBtn.Size = New System.Drawing.Size(114, 33)
        Me.ResetBooksBtn.TabIndex = 10
        Me.ResetBooksBtn.Text = "Reset"
        Me.ResetBooksBtn.UseVisualStyleBackColor = False
        '
        'BooksPriceTxt
        '
        Me.BooksPriceTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BooksPriceTxt.Location = New System.Drawing.Point(374, 55)
        Me.BooksPriceTxt.Name = "BooksPriceTxt"
        Me.BooksPriceTxt.Size = New System.Drawing.Size(125, 27)
        Me.BooksPriceTxt.TabIndex = 3
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.OrangeRed
        Me.Back.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Back.ForeColor = System.Drawing.Color.White
        Me.Back.Location = New System.Drawing.Point(259, 407)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(123, 24)
        Me.Back.TabIndex = 27
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'BooksDGVPanel
        '
        Me.BooksDGVPanel.Controls.Add(Me.BooksDGV)
        Me.BooksDGVPanel.Location = New System.Drawing.Point(2, 236)
        Me.BooksDGVPanel.Name = "BooksDGVPanel"
        Me.BooksDGVPanel.Size = New System.Drawing.Size(659, 165)
        Me.BooksDGVPanel.TabIndex = 31
        '
        'BooksDGV
        '
        Me.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BkId, Me.BName, Me.BAuthor, Me.BPublisher, Me.BPrice, Me.BQty})
        Me.BooksDGV.Location = New System.Drawing.Point(13, 11)
        Me.BooksDGV.Name = "BooksDGV"
        Me.BooksDGV.RowTemplate.Height = 25
        Me.BooksDGV.Size = New System.Drawing.Size(638, 106)
        Me.BooksDGV.TabIndex = 0
        '
        'BkId
        '
        Me.BkId.HeaderText = "BookId"
        Me.BkId.Name = "BkId"
        '
        'BName
        '
        Me.BName.HeaderText = "Name"
        Me.BName.Name = "BName"
        '
        'BAuthor
        '
        Me.BAuthor.HeaderText = "Author"
        Me.BAuthor.Name = "BAuthor"
        '
        'BPublisher
        '
        Me.BPublisher.HeaderText = "Publisher"
        Me.BPublisher.Name = "BPublisher"
        '
        'BPrice
        '
        Me.BPrice.HeaderText = "Price"
        Me.BPrice.Name = "BPrice"
        '
        'BQty
        '
        Me.BQty.HeaderText = "Quantity"
        Me.BQty.Name = "BQty"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BookNameTxt)
        Me.Panel2.Controls.Add(Me.BooksPubliserTxt)
        Me.Panel2.Controls.Add(Me.BooksQuantityTxt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.SaveBooksBtn)
        Me.Panel2.Controls.Add(Me.BooksAuthorTxt)
        Me.Panel2.Controls.Add(Me.EditBooksBtn)
        Me.Panel2.Controls.Add(Me.ResetBooksBtn)
        Me.Panel2.Controls.Add(Me.BooksPriceTxt)
        Me.Panel2.Controls.Add(Me.UpdateBooksBtn)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 134)
        Me.Panel2.TabIndex = 29
        '
        'BookNameTxt
        '
        Me.BookNameTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookNameTxt.Location = New System.Drawing.Point(4, 54)
        Me.BookNameTxt.Name = "BookNameTxt"
        Me.BookNameTxt.Size = New System.Drawing.Size(125, 27)
        Me.BookNameTxt.TabIndex = 22
        '
        'BooksPubliserTxt
        '
        Me.BooksPubliserTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BooksPubliserTxt.Location = New System.Drawing.Point(245, 54)
        Me.BooksPubliserTxt.Name = "BooksPubliserTxt"
        Me.BooksPubliserTxt.Size = New System.Drawing.Size(125, 27)
        Me.BooksPubliserTxt.TabIndex = 21
        '
        'BooksQuantityTxt
        '
        Me.BooksQuantityTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BooksQuantityTxt.Location = New System.Drawing.Point(505, 55)
        Me.BooksQuantityTxt.Name = "BooksQuantityTxt"
        Me.BooksQuantityTxt.Size = New System.Drawing.Size(125, 27)
        Me.BooksQuantityTxt.TabIndex = 20
        '
        'UpdateBooksBtn
        '
        Me.UpdateBooksBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.UpdateBooksBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UpdateBooksBtn.ForeColor = System.Drawing.Color.Snow
        Me.UpdateBooksBtn.Location = New System.Drawing.Point(309, 90)
        Me.UpdateBooksBtn.Name = "UpdateBooksBtn"
        Me.UpdateBooksBtn.Size = New System.Drawing.Size(114, 33)
        Me.UpdateBooksBtn.TabIndex = 9
        Me.UpdateBooksBtn.Text = "Update"
        Me.UpdateBooksBtn.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblName.Location = New System.Drawing.Point(135, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(374, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(248, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Publisher"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(248, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Books List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "BOOKS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 41)
        Me.Panel1.TabIndex = 28
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
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 450)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.BooksDGVPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Books"
        Me.Text = "Books"
        Me.BooksDGVPanel.ResumeLayout(False)
        CType(Me.BooksDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveBooksBtn As Button
    Friend WithEvents BooksAuthorTxt As TextBox
    Friend WithEvents EditBooksBtn As Button
    Friend WithEvents ResetBooksBtn As Button
    Friend WithEvents BooksPriceTxt As TextBox
    Friend WithEvents Back As Button
    Friend WithEvents BooksDGVPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BookNameTxt As TextBox
    Friend WithEvents BooksPubliserTxt As TextBox
    Friend WithEvents BooksQuantityTxt As TextBox
    Friend WithEvents UpdateBooksBtn As Button
    Friend WithEvents lblName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BooksDGV As DataGridView
    Friend WithEvents BkId As DataGridViewTextBoxColumn
    Friend WithEvents BName As DataGridViewTextBoxColumn
    Friend WithEvents BAuthor As DataGridViewTextBoxColumn
    Friend WithEvents BPublisher As DataGridViewTextBoxColumn
    Friend WithEvents BPrice As DataGridViewTextBoxColumn
    Friend WithEvents BQty As DataGridViewTextBoxColumn
End Class
