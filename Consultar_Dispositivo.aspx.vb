Imports System.Data.SqlClient
Imports System.Data
Public Class Consultar_Dispositivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnBuscarDispositivo_Click(sender As Object, e As EventArgs) Handles BtnBuscarDispositivo.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreDispositivo.Text)) = 0 Then
                MsgBox("Ingrese ID Servicio Tecnico")
                Exit Sub
            End If

            Dim MiNombre As String = UCase(TxtNombreDispositivo.Text)


            Dim MiComando As String = "select idequipo as Identificador,marca as Marca ,numero_serie as Serie,estado as Estado  ,modelo as Modelo,garantia as Garantia, tipo_equipo as Dispositivo,ram As Ram, DiscoDuro, procesador as Procesador from dispositivo "
            MiComando = MiComando & "where upper(tipo_equipo) Like '%" & MiNombre & "%'"



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