Imports System.Data.SqlClient
Imports System.Data
Public Class Consultar_Trabajador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnBuscarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnBuscarTrabajador.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreTrabajador.Text)) = 0 Then
                MsgBox("Ingrese nombre trabajador")
                Exit Sub
            End If

            Dim MiNombre As String = UCase(TxtNombreTrabajador.Text)
            Dim MiComando As String = "select rut as Rut,nombre as Trabajador,departamento as Departamento,cargo as Cargo,correo as Correo ,telefono as Telefono ,"
            MiComando = MiComando & "id_equipo as EquipoAsignado "
            MiComando = MiComando & "from trabajador a left join relacion_trabajador_equipo b on a.rut=b.rut_trabajador "
            MiComando = MiComando & "where upper(nombre) Like '%" & MiNombre & "%'"

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