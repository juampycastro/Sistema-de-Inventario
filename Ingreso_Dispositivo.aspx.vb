Imports System.Data.SqlClient
Imports System.Data

Public Class Ingreso_Dispositivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnIngresarDispositivo_Click(sender As Object, e As EventArgs) Handles BtnIngresarDispositivo.Click
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

            If Len(TxtIdEquipo.Text) = 0 Then
                MsgBox("Debe ingresar ID Dispositivo")
                Exit Sub

            End If



            Dim MI_CONEXION As String = "Data Source=localhost;Initial Catalog=inventario;Integrated Security=SSPI" '';user id=DESKTOP-3F94190\juampy"
            Dim cn As SqlConnection = New SqlConnection(MI_CONEXION)

            Dim MiDispositivo As String = CmbDispositivo.SelectedItem.Text

            Dim micomando As String = "insert dispositivo values('" & TxtIdEquipo.Text & "',"
            micomando = micomando & "'" & TxtMarca.Text & "','" & TxtNumeroSerie.Text & "','" & TxtEstado.Text & "','" & TxtModelo.Text & "','" & TxtGarantia.Text & "','" & MiDispositivo & "','" & TxtRam.Text & "','" & TxtDiscoDuro.Text & "','" & TxtProcesador.Text & "')"

            Dim cmd As SqlCommand = New SqlCommand(micomando, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()


            MsgBox("Dispositivo Ingresado Correctamente")

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Protected Sub CmbDispositivo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDispositivo.SelectedIndexChanged
        Try
            If CmbDispositivo.SelectedItem.Text = "CPU" Then
                Ram.Visible = True
                TxtRam.Visible = True

            Else
                Ram.Visible = False
                TxtRam.Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            If CmbDispositivo.SelectedItem.Text = "CPU" Then

                DiscoDuro.Visible = True
                TxtDiscoDuro.Visible = True
            Else

                DiscoDuro.Visible = False
                TxtDiscoDuro.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Try
            If CmbDispositivo.SelectedItem.Text = "CPU" Then

                Procesador.Visible = True
                TxtProcesador.Visible = True
            Else

                Procesador.Visible = False
                TxtProcesador.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Protected Sub CmbDispositivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDispositivo.SelectedIndexChanged
        Try
            If CmbDispositivo.SelectedItem.Text = "Notebook" Then
                Ram.Visible = True
                TxtRam.Visible = True

            Else
                Ram.Visible = False
                TxtRam.Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            If CmbDispositivo.SelectedItem.Text = "Notebook" Then

                DiscoDuro.Visible = True
                TxtDiscoDuro.Visible = True
            Else

                DiscoDuro.Visible = False
                TxtDiscoDuro.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Try
            If CmbDispositivo.SelectedItem.Text = "Notebook" Then

                Procesador.Visible = True
                TxtProcesador.Visible = True
            Else

                Procesador.Visible = False
                TxtProcesador.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class