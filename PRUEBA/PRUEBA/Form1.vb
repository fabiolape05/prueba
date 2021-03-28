Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        mostrardatos()
    End Sub
    'mostrar datos en el datagrid
    Sub mostrardatos()
        Dim da As New SqlDataAdapter("select * from alumno", con)
        Dim ds As New DataSet
        da.Fill(ds, "alumno")
        DataGridView1.DataSource = ds.Tables(0)
        'personalizamo el encabezado de  las columnas
        DataGridView1.Columns("codigo").HeaderText = "codigo"
        DataGridView1.Columns("nombre").HeaderText = "nombre"
        DataGridView1.Columns("apellido").HeaderText = "apellido"

    End Sub


    Private Sub cmdInsertar_Click(sender As Object, e As EventArgs) Handles cmdInsertar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into alumno (codigo,nombre,apellido)   values  ('" & txtcodigo.Text & "','" & txtnombre.Text & "','" & txtapellido.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("datos guardados")
            'ponemos el mostrar datos para que recargue
            mostrardatos()
        Catch ex As Exception
            'si se produce un error lo mostramos aqui
            MessageBox.Show(ex.Message)
            'probamos
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'usaremos el eevnto rowheadermouseclick 
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If DataGridView1.Rows.Count > 0 Then
            'si es mayor que cero tiene datos cargados
            If DataGridView1.SelectedRows.Count > 0 Then
                'comprobamos que hay filas seleccionadas 
                'mostramos los datos en la cajade texto
                txtcodigo.Text = DataGridView1.SelectedRows(0).Cells("codigo").Value
                txtnombre.Text = DataGridView1.SelectedRows(0).Cells("nombre").Value
                txtapellido.Text = DataGridView1.SelectedRows(0).Cells("apellido").Value
                'probamos
            End If
        End If
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'para actualizar el codigo es casi igual que el guardar
        'solo cambia la instruccion sql
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "update alumno set codigo = '" & txtcodigo.Text & "', nombre = '" & txtnombre.Text & "',apellido= '" & txtapellido.Text & "' where codigo = '" & txtcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("datos guardados")
            'ponemos el mostrar datos para que recargue
            mostrardatos()
        Catch ex As Exception
            'si se produce un error lo mostramos aqui
            MessageBox.Show(ex.Message)
            'probamos
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        'finalmente veremos el eliminar
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "delete from alumno where codigo = '" & txtcodigo.Text & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("datos eliminados")
        mostrardatos()
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        limpiar()
    End Sub
    'crearemos un procedimiento para limpiar desde ahi 
    Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class
