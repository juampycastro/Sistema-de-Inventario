Imports System.Data.SqlClient
Imports System.Data

Public Class Eliminar_Trabajador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnEliminarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnEliminarTrabajador.Click
        Try

            If CmbTrabajadores.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar el trabajador a eliminar")
                Exit Sub
            End If

            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim Trabajadorseleccionado As String = CmbTrabajadores.SelectedItem.Text
            Dim arr() As String
            arr = Split(Trabajadorseleccionado, "]")
            Dim MiRut As String = arr(0)
            Dim TrabajadorBorrado As String = Trim(arr(1))

            MiRut = Replace(MiRut, "[", "")
            MiRut = Trim(MiRut)

            Dim micomando As String = "delete trabajador where rut ='" & MiRut & "'"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Trabajador '" & TrabajadorBorrado & "' eliminado satisfactoriamente.", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub BtnBuscarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnBuscarTrabajador.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreTrabajador.Text)) = 0 Then
                MsgBox("Ingrese nombre trabajador")
                Exit Sub
            End If

            Dim MiNombre As String = UCase(TxtNombreTrabajador.Text)
            Dim MiComando As String = "select '['+rut+'] '+nombre from trabajador where upper(nombre) like '%" & MiNombre & "%'"
            Dim cmd As SqlCommand = New SqlCommand(MiComando, cn)

            cn.Open()
            Dim datos As SqlDataReader = cmd.ExecuteReader

            'CmbTrabajadores.DataSource = datos
            'CmbTrabajadores.DataBind()

            CmbTrabajadores.DataSource = Nothing

            For Each midato In datos
                'MsgBox("dato=" & midato(0).ToString)
                CmbTrabajadores.Items.Add(midato(0).ToString)
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
            msgbox(ex.Message)
        End Try

    End Sub
End Class