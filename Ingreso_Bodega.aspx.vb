Imports System.Data.SqlClient
Imports System.Data

Public Class Ingreso_Bodega
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnIngresarBodega_Click(sender As Object, e As EventArgs) Handles BtnIngresarBodega.Click
        Try


            If Len(TxtIdBodega.Text) = 0 Then
                MsgBox("Debe ingresar ID Bodega")
                Exit Sub

            End If


            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim MiDispositivoBodega As String = CmbTipoBodega.SelectedItem.Text

            Dim micomando As String = "insert bodega values('" & TxtIdBodega.Text & "',"
            micomando = micomando & "'" & MiDispositivoBodega & "','" & TxtMarcaBodega.Text & "','" & TxtModeloBodega.Text & "','" & TxtMarcaBodega.Text & "','" & TxtEstanteBodega.Text & "','" & TxtStock.Text & "')"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Dispositivo Ingresado a Bodega Correctamente")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub CmbTipoEquipoBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoBodega.SelectedIndexChanged

    End Sub

    Protected Sub TxtMarcaBodega_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class