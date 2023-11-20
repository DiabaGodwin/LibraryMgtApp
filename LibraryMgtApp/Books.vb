Imports System.Data.SqlClient
Public Class Books
    Dim Con = New SqlConnection("Data Source=COBBIEKAY;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub DisplayBooks()
        Con.Open()
        Dim query = "SELECT * FROM BookTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)

        Con.Close()
    End Sub
    Private Sub SaveBooksBtn_Click(sender As Object, e As EventArgs) Handles SaveBooksBtn.Click
        If BookNameTxt.Text = "" Or BooksAuthorTxt.Text = "" Or BooksPubliserTxt.Text = "" Or BooksQuantityTxt.Text = "" Or
            BooksPriceTxt.Text = "" Then
            MsgBox("Missing information")
        Else
            Con.Open()
            Dim query = "INSERT INTO BookTbl VALUES ('" & BookNameTxt.Text & "','" & BooksAuthorTxt.Text & "','" & BooksPubliserTxt.Text & "','" & BooksQuantityTxt.Text & "','" & BooksPriceTxt.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book saved Succesfully")
            Con.Close()
            DisplayBooks()
            ResetBooks()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBooks()
    End Sub

    Private Sub ResetBooks()
        BookNameTxt.Text = ""
        BooksAuthorTxt.Text = ""
        BooksPubliserTxt.Text = ""
        BooksPriceTxt.Text = ""
        BooksQuantityTxt.Text = ""
    End Sub
    Private Sub ResetBooksBtn_Click(sender As Object, e As EventArgs) Handles ResetBooksBtn.Click
        ResetBooks()
    End Sub
End Class