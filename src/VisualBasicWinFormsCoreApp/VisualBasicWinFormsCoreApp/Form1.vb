Imports System.IO
Imports System.Data.SqlServerCe
Imports VisualBasicWinFormsCoreApp.Data.Entities

Public Class Form1

    Private db As New NorthwindContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim obj = sender
        Dim myevent = e
        Dim idcol = DataGridView1.Columns("Id")
        Dim idrow = DataGridView1.Rows.Item(0)

    End Sub
End Class
