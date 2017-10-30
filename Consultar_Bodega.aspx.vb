Imports System.Data.SqlClient
Imports System.Data
Public Class Consultar_Bodega
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnBuscarDispositivo_Click(sender As Object, e As EventArgs) Handles BtnBuscarBodega.Click
        Try
            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            If Len(Trim(TxtNombreBodega.Text)) = 0 Then
                MsgBox("Ingrese Nombre Dispositivo")
                Exit Sub
            End If

            Dim MiNombre As String = UCase(TxtNombreBodega.Text)


            Dim MiComando As String = "select id_bodega as Identificador,tipo_equipo_bodega as Dispositivo ,marca_bodega as Marca ,modelo_bodega as Modelo,num_serie_bodega as Serie, estante_bodega as Estante,stock_bodega as Bodega from bodega "
            MiComando = MiComando & "where upper(tipo_equipo_bodega) Like '%" & MiNombre & "%'"



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