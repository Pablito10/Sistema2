Public Class Formcliente

    Private dt As New DataTable


    Private Sub Formcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try

            Dim func As New fCliente
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                cajabuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                Lnoexiste.Visible = False
            Else
                datalistado.DataSource = Nothing
                cajabuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                Lnoexiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cajacliente.Visible = False
        cajaapellido.Visible = False
        cajacuenta.Visible = False
        cajacuit.Visible = False
        cajadni.Visible = False
        cajadomicilio.Visible = False
        cajalocalidad.Visible = False
        cajaestadocu.Visible = False
        cajamail.Visible = False
        cajatelefono.Visible = False
        cajanombre.Visible = False

        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            If combobusqueda.Text <> String.Empty Then
                dv.RowFilter = combobusqueda.Text & "like'%" & cajabuscar.Text & "%'"
            End If


            dv.RowFilter = combobusqueda.Text & "like'%" & cajabuscar.Text & "%'"

            If dv.Count <> 0 Then
                Lnoexiste.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                Lnoexiste.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(5).Visible = False
        datalistado.Columns(9).Visible = False
        datalistado.Columns(11).Visible = False
    End Sub

    Private Sub combobusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobusqueda.SelectedIndexChanged

    End Sub
End Class