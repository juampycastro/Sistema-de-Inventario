Imports System.Data.SqlClient
Imports System.Data

Public Class Eliminar_ServicioTecnico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnEliminarServicioTecnico_Click(sender As Object, e As EventArgs) Handles BtnEliminarServicioTecnico.Click
        Try

            If CmbServicioTecnico.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar el Servicio Tecnico a eliminar")
                Exit Sub
            End If

            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim ServicioTecnicoseleccionado As String = CmbServicioTecnico.SelectedItem.Text
            Dim arr() As String
            arr = Split(ServicioTecnicoseleccionado, "]")
            Dim MiServicio As String = arr(0)
            Dim ServicioTecnicoBorrado As String = Trim(arr(1))

            MiServicio = Replace(MiServicio, "[", "")
            MiServicio = Trim(MiServicio)

            Dim micomando As String = "delete servicio_tecnico where numero_orden ='" & MiServicio & "'"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("ServicioTecnico '" & ServicioTecnicoBorrado & "' eliminado satisfactoriamente.", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub BtnBuscarServicioTecnico_Click(sender As Object, e As EventArgs) Handles BtnBuscarServicioTecnico.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreServicioTecnico.Text)) = 0 Then
                MsgBox("Ingrese algun dato")
                Exit Sub
            End If

            Dim MiServicioTecnico As String = UCase(TxtNombreServicioTecnico.Text)
            Dim MiComando As String = "select '['+numero_orden+'] '+nombre_serv_tec from servicio_tecnico where upper(nombre_serv_tec) like '%" & MiServicioTecnico & "%'"
            Dim cmd As SqlCommand = New SqlCommand(MiComando, cn)

            cn.Open()
            Dim datos As SqlDataReader = cmd.ExecuteReader

            'CmbTrabajadores.DataSource = datos
            'CmbTrabajadores.DataBind()

            CmbServicioTecnico.DataSource = Nothing

            For Each midato In datos
                'MsgBox("dato=" & midato(0).ToString)
                CmbServicioTecnico.Items.Add(midato(0).ToString)
            Next
            'Dim dt As DataTable = New DataTable()

            'Dim i As Integer = 0

            'i = i
            'CmbTrabajadores.DataSource = ad
            'CmbTrabajadores.DataBind()

            'ad.Fill(dt)
            'CmbTrabajadores.DataSource = dt.Columns.Item(0)
            'CmbTrabajadores.DataBind()

            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class