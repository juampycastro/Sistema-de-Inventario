Imports System.Data.SqlClient
Imports System.Data

Public Class Eliminar_Dispositivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnEliminarDispositivo_Click(sender As Object, e As EventArgs) Handles BtnEliminarDispositivo.Click
        Try

            If CmbDispositivo.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar el Dispositivo a eliminar")
                Exit Sub
            End If

            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim Dispositivoseleccionado As String = CmbDispositivo.SelectedItem.Text
            Dim arr() As String
            arr = Split(Dispositivoseleccionado, "]")
            Dim MiID As String = arr(0)
            Dim DispositivoBorrado As String = Trim(arr(1))

            MiID = Replace(MiID, "[", "")
            MiID = Trim(MiID)

            Dim micomando As String = "delete dispositivo where idequipo ='" & MiID & "'"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Dispositivo '" & DispositivoBorrado & "' eliminado satisfactoriamente.", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub BtnBuscarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnBuscarDispositivo.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreDispositivo.Text)) = 0 Then
                MsgBox("Ingrese algun dato")
                Exit Sub
            End If

            Dim MiMarca As String = UCase(TxtNombreDispositivo.Text)
            Dim MiComando As String = "select '['+idequipo+'] '+marca from dispositivo where upper(marca) like '%" & MiMarca & "%'"
            Dim cmd As SqlCommand = New SqlCommand(MiComando, cn)

            cn.Open()
            Dim datos As SqlDataReader = cmd.ExecuteReader

            'CmbTrabajadores.DataSource = datos
            'CmbTrabajadores.DataBind()

            CmbDispositivo.DataSource = Nothing

            For Each midato In datos
                'MsgBox("dato=" & midato(0).ToString)
                CmbDispositivo.Items.Add(midato(0).ToString)
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