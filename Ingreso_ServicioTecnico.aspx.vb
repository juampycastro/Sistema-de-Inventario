Imports System.Data.SqlClient
Imports System.Data
Public Class Ingreso_ServicioTecnico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnIngresarServicioTecnico_Click(sender As Object, e As EventArgs) Handles BtnIngresarServiciotecnico.Click
        Try

            If Len(TxtNombre_Serv_Tec.Text) = 0 Then
                MsgBox("Ingresar Nombre Servicio Tecnico")
                Exit Sub

            End If

            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim ServicioTecnico As String = CmbTipo.SelectedItem.Text

            Dim micomando As String = "insert servicio_tecnico values('" & ServicioTecnico & "','" & TxtNombre_Serv_Tec.Text & "',"
            micomando = micomando & "'" & TxtRut_Serv_Tec.Text & "','" & TxtNumero_Orden.Text & "','" & TxtFecha_I.Text & "','" & TxtFecha_S.Text & "')"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Servicio Tecnico Ingresado Correctamente")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged
        Try
            If CmbTipo.SelectedItem.Text = "Externo" Then
                Label2.Visible = True
                TxtNombre_Serv_Tec.Visible = True
                Label3.Visible = True
                TxtRut_Serv_Tec.Visible = True


            Else
                Label2.Visible = False
                TxtNombre_Serv_Tec.Visible = False
                Label3.Visible = False
                TxtRut_Serv_Tec.Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub


End Class