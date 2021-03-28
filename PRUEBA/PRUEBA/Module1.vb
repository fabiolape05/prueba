Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection
    Public Sub conectar()
        con.ConnectionString = "Data Source=DESKTOP-9J0V9I7\SQLEXPRESS;Initial Catalog=probar;Integrated Security=True"
        con.Open()
    End Sub
End Module
