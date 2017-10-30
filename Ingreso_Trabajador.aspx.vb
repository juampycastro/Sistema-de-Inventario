Imports System.Data.SqlClient
Imports System.Data
Public Class Ingreso_Trabajador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnIngresarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnIngresarTrabajador.Click
        Try
            'Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            'Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)
            'Dim cmd As SqlCommand = New SqlCommand("select rut,nombre,departamento from trabajador", cn)
            'Dim ad As SqlDataAdapter = New SqlDataAdapter(cmd)
            'Dim dt As DataTable = New DataTable()

            'ad.Fill(dt)
            'grilla.DataSource = dt
            'grilla.DataBind()
            'cn.Close()

            If Len(TxtRut.Text) = 0 Then
                MsgBox("Ingresar Rut")
                Exit Sub

            End If

            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim MiDepartamento As String = CmbDepartamento.SelectedItem.Text

            Dim micomando As String = "insert trabajador values('" & TxtRut.Text & "',"
            micomando = micomando & "'" & TxtNombre.Text & "','" & MiDepartamento & "','" & TxtCargo.Text & "','" & TxtCorreo.Text & "','" & TxtTelefono.Text & "','" & TxtAnexo.Text & "')"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Trabajador Ingresado Correctamente")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

End Class