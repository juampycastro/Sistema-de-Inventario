Imports System.Data.SqlClient
Imports System.Data
Public Class Consultar_ServicioTecnico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnBuscarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnBuscarServicioTecnico.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreServicio.Text)) = 0 Then
                MsgBox("Ingrese Numero Orden del Servicio Tecnico")
                Exit Sub
            End If

            Dim MiNombre As String = UCase(TxtNombreServicio.Text)

            'Dim MiComando As String = "select *from servicio_tecnico"

            Dim MiComando As String = "select tipo as Tipo,nombre_serv_tec as Nombre ,rut_serv_tec as Rut,numero_orden as Orden  ,fecha_i as Ingreso,fecha_s as Salida from servicio_tecnico "
            MiComando = MiComando & "where upper(numero_orden) Like '%" & MiNombre & "%'"



            Dim cmd As SqlCommand = New SqlCommand(MiComando, cn)

            cn.Open()
            Dim ad As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()

            ad.Fill(dt)
            grilla.DataSource = dt
            grilla.DataBind()
            cn.Close()


            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class