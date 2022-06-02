Imports System.IO
Imports System.Data.SqlServerCe
Imports VisualBasicWinFormsCoreApp.Data.Entities
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports Microsoft.Data.SqlClient

Public Class Form1

    Private db As New NorthwindContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcreatedat.Text = Now
        txtcreatedby.Text = Environment.MachineName
        LoadData()
    End Sub

    Public Sub LoadData()
        Dim users = db.Users.ToList()
        DataGridView1.DataSource = users
    End Sub
    Public Function Connection() As String
        Dim domain = AppDomain.CurrentDomain.BaseDirectory
        Dim db = Path.Combine(domain, "db.sdf")
        If db Is Nothing Then
            CreateDatabase(db)
        End If
        Dim cs = $"Data Source={db};Max Database Size=4091"
        Return cs
    End Function

    Private Sub CreateDatabase(db As String)


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim id = Guid.Parse(DataGridView1.CurrentCell.Value.ToString)
        Dim data = db.Users.SingleOrDefault(Function(x) x.id = id)
        If data IsNot Nothing Then
            btndelete.Enabled = True
            lblcreatedat.Text = "Updated At"
            lblcreatedby.Text = "Updated By"
            txtcreatedat.Text = Now
            btnadd.Text = "Update User"
            txtcreatedby.Text = Environment.MachineName
            txtemail.Text = data.email
            txtid.Text = data.id.ToString
            txtpass.Text = data.password
        End If

    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                Dim cellvalue = cell.Value
                Dim strCellValue As String
                If cellvalue Is Nothing Then
                    strCellValue = "N/A"
                Else
                    strCellValue = cellvalue.ToString
                End If
                pdfTable.AddCell(strCellValue)
            Next
        Next

        'Exporting to PDF
        Dim folderPath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim pdffile = Path.Combine(folderPath, "DataGridViewExport.pdf")
        If File.Exists(pdffile) Then
            File.Delete(pdffile)
        End If
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using stream As New FileStream(pdffile, FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
        If File.Exists(pdffile) Then
            Try
                Process.Start(pdffile)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim email = txtemail.Text.Trim
        Dim pass = txtpass.Text.Trim
        Dim bydate = Date.Parse(txtcreatedat.Text)
        Dim by = txtcreatedby.Text
        If email.Length = 0 Or pass.Length = 0 Then
            MessageBox.Show("Fields are required", "My App")
        Else
            If btnadd.Text = "Add User" Then
                Dim user As New Users
                user.createdat = bydate
                user.createdby = by
                user.email = email
                user.password = pass

                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Added
                db.Users.AddAsync(user)
                Dim result = db.SaveChanges()
                If result > 0 Then
                    MessageBox.Show("User created", "My App")
                    DataGridView1.DataSource = Nothing
                    LoadData()
                End If
            End If

            If btnadd.Text = "Update User" Then
                Dim id = Guid.Parse(txtid.Text)
                Dim data = db.Users.SingleOrDefault(Function(x) x.id = id)
                data.email = email
                data.createdat = data.createdat
                data.createdby = data.createdby
                data.email = email
                data.password = pass
                data.updatedat = Now
                data.updatedby = Environment.MachineName

                db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified
                db.Users.Update(data)

                Dim result = db.SaveChanges()
                If result > 0 Then
                    MessageBox.Show("User updated", "My App")
                    DataGridView1.DataSource = Nothing
                    LoadData()
                End If
            End If


        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtemail.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim msgbox As DialogResult = MessageBox.Show("Confirm Delete?",
                              "My App",
                              MessageBoxButtons.YesNo)

        If (msgbox = DialogResult.Yes) Then
            Dim id = Guid.Parse(txtid.Text)
            Using sqlcon As New SqlConnection("Data Source=.;Initial Catalog=Northwind;Persist Security Info=True;User ID=test;Password=test")
                sqlcon.Open()
                Dim query = $"DELETE FROM  Users WHERE id='{id}'"
                Using sqlcmd As New SqlCommand(query, sqlcon)
                    Dim result = sqlcmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("User Deleted", "My App")
                        DataGridView1.DataSource = Nothing
                        LoadData()
                    End If
                End Using
                sqlcon.Close()
            End Using

        Else

        End If
    End Sub
End Class
