Imports System.Data.SqlClient
Imports System.Data

Public Class Eliminar_Bodega
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnEliminarBodegaDispositivo_Click(sender As Object, e As EventArgs) Handles BtnEliminarBodegaDispositivo.Click
        Try

            If CmbDispositivoBodega.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar el Dispositivo a eliminar de Bodega")
                Exit Sub
            End If

            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim Bodegaseleccionado As String = CmbDispositivoBodega.SelectedItem.Text
            Dim arr() As String
            arr = Split(Bodegaseleccionado, "]")
            Dim MiBodega As String = arr(0)
            Dim BodegaBorrado As String = Trim(arr(1))

            MiBodega = Replace(MiBodega, "[", "")
            MiBodega = Trim(MiBodega)

            Dim micomando As String = "delete Bodega where id_bodega ='" & MiBodega & "'"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Dispositivo '" & BodegaBorrado & "' eliminado satisfactoriamente.", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub BtnBuscarTrabajador_Click(sender As Object, e As EventArgs) Handles BtnBuscarDispositivoBodega.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtDispositivoBodega.Text)) = 0 Then
                MsgBox("Ingrese algun dato")
                Exit Sub
            End If

            Dim MiBodega As String = UCase(TxtDispositivoBodega.Text)
            Dim MiComando As String = "select '['+id_bodega+'] '+tipo_equipo_bodega from bodega where upper(tipo_equipo_bodega) like '%" & MiBodega & "%'"
            Dim cmd As SqlCommand = New SqlCommand(MiComando, cn)

            cn.Open()
            Dim datos As SqlDataReader = cmd.ExecuteReader

            'CmbTrabajadores.DataSource = datos
            'CmbTrabajadores.DataBind()

            CmbDispositivoBodega.DataSource = Nothing

            For Each midato In datos
                'MsgBox("dato=" & midato(0).ToString)
                CmbDispositivoBodega.Items.Add(midato(0).ToString)
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