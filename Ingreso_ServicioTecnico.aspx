﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Ingreso_ServicioTecnico.aspx.vb" Inherits="Menu2.Ingreso_ServicioTecnico" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Ingreso Servicio Tecnico</title>
    <!-- Bootstrap Core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- MetisMenu CSS -->
    <link href="vendor/metisMenu/metisMenu.min.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="dist/css/sb-admin-2.css" rel="stylesheet">
    <!-- Custom Fonts -->
    <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        .auto-style1 {
            position: relative;
            min-height: 1px;
            top: 7px;
            left: -5px;
            float: left;
            width: 100%;
            height: 522px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>

<body>
    <div id="wrapper">
        <!-- Navigation -->
        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="WebForm1.aspx">Inchalam</a>
            </div>
            <!-- /.navbar-header -->
            <ul class="nav navbar-top-links navbar-right">

                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user fa-fw"></i> <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li>
                            <a href="#"><i class="fa fa-user fa-fw"></i> Usuario</a>
                        </li>
                        <li>
                            <a href="#"><i class="fa fa-gear fa-fw"></i> Ajustes</a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="login.aspx"><i class="fa fa-sign-out fa-fw"></i> Salir</a>
                        </li>
                    </ul>
                    <!-- /.dropdown-user -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-top-links -->
            <div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                    <ul class="nav" id="side-menu">
                        <li class="sidebar-search">
                            <div class="input-group custom-search-form">
                                <input type="text" class="form-control" placeholder="Search...">
                                <span class="input-group-btn">
                                    <button class="btn btn-default" type="button">
                                        <i class="fa fa-search"></i>
                                    </button>
                                </span>
                            </div>
                            <!-- /input-group -->
                        </li>

                        <li>
                            <a href="#"><i class="fa fa-dashboard fa-fw"></i> Ingresar</a>
                            <ul class="nav nav-second-level">
                                <li>
                                    <a href="Ingreso_Trabajador.aspx">Ingresar Trabajador</a>
                                </li>
                                <li>
                                    <a href="Ingreso_Dispositivo.aspx">Ingresar Dispositivo Informatico</a>
                                </li>
                                <li>
                                    <a href="Ingreso_ServicioTecnico.aspx">Ingresar Servicio Tecnico</a>
                                </li>
                                 <li>
                                    <a href="Ingreso_Bodega.aspx">Ingresar Dispositivo a Bodega</a>
                                </li>
                            </ul>
                            <!-- /.nav-second-level -->
                        </li>
                        <li>
                            <a href="#"><i class="fa fa-table fa-fw"></i> Consultar</a>
                            <ul class="nav nav-second-level">
                                <li>
                                    <a href="Consultar_Trabajador.aspx">Consultar Trabajador</a>
                                </li>
                                <li>
                                    <a href="Consultar_Dispositivo.aspx">Consultar Dispositivo Informatico</a>
                                </li>
                                <li>
                                    <a href="Consultar_ServicioTecnico.aspx">Consultar Servicio Tecnico</a>
                                </li>
                                  <li>
                                    <a href="Consultar_Bodega.aspx">Consultar Dispositivo en Bodega</a>
                                </li>
                            </ul>
                            <!-- /.nav-second-level -->
                        </li>

                        <li>
                            <a href="index.html"><i class="fa fa-edit fa-fw"></i> Modificar</a>
                            <ul class="nav nav-second-level">
                                <li>
                                    <a href="Modificar_Trabajador.aspx">Modificar Trabajador</a>
                                </li>
                                <li>
                                    <a href="Modificar_Dispositivo.aspx">Modificar Dispositivo Informatico</a>
                                </li>
                                <li>
                                    <a href="Modificar_ServicioTecnico.aspx">Modificar Servicio Tecnico</a>
                                </li>
                                 <li>
                                    <a href="Modificar_Bodega.aspx">Modificar Dispositivo de Bodega</a>
                                </li>

                            </ul>
                        </li>

                        <li>
                            <a href="#"><i class="fa fa-warning fa-fw"></i> Eliminar</a>
                            <ul class="nav nav-second-level">
                                <li>
                                    <a href="Eliminar_Trabajador.aspx">Eliminar Trabajador</a>
                                </li>
                                <li>
                                    <a href="Eliminar_Dispositivo.aspx">Eliminar Dispositivo Informatico</a>
                                </li>
                                <li>
                                    <a href="Eliminar_ServicioTecnico.aspx">Eliminar Servicio Tecnico</a>
                                </li>
                                <li>
                                    <a href="Eliminar_Bodega.aspx">Eliminar Dispositivo de Bodega</a>
                                </li>
                            </ul>
                            <!-- /.nav-second-level -->
                        </li>

                    </ul>
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->
        </nav>

      <div id="page-wrapper">
            <div class="row">
                
                    <h2 class="page-header">Ingresar Servicio Tecnico</h2>
                <div class="col-lg-6">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Datos Servicio Tecnico</div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="auto-style1">
                                    <form id="form1" runat="server">
                                        &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#003399" Text="Tipo de Servicio Tecnico"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; <asp:DropDownList ID="CmbTipo" runat="server" Height="33px" Width="184px" AutoPostBack="True">
                                            <asp:ListItem>Externo</asp:ListItem>
                                            <asp:ListItem>Interno</asp:ListItem>
                                            
                                        </asp:DropDownList>
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#003399" Text="Nombre Servicio Tecnico"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtNombre_Serv_Tec" runat="server" Height="33px" Width="184px" BorderColor="#CCCCCC" BorderStyle="Ridge"></asp:TextBox>
                                        &nbsp;
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#003399" Text="Rut Servicio Tecnico"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtRut_Serv_Tec" runat="server" Height="33px" Width="184px" BorderColor="#CCCCCC" BorderStyle="Ridge"></asp:TextBox>
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#003399" Text="Numero Orden"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtNumero_Orden" runat="server" Height="33px" Width="184px" BorderColor="#CCCCCC" BorderStyle="Ridge"></asp:TextBox>
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#003399" Text="Fecha Ingreso" placeholder="DD/MM/AA"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtFecha_I"  placeholder="             DD/MM/AA" runat="server" Height="33px" Width="184px" BorderColor="#CCCCCC" BorderStyle="Ridge"></asp:TextBox>
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#003399" Text="Fecha Salida"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtFecha_S"  placeholder="              DD/MM/AA" runat="server" Height="33px" Width="184px" BorderColor="#CCCCCC" BorderStyle="Ridge"></asp:TextBox>
                                        <br />
                                        <br />

                                        <br />
                                        <br />
                                       



                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="BtnIngresarServicioTecnico" runat="server" Text="Ingresar" BorderColor="#CCCCCC" BorderStyle="Ridge" Height="29px" />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                    </form>


                                    <!-- /.col-lg-6 (nested) -->
                                </div>
                                <!-- /.row (nested) -->
                            </div>
                            <!-- /.panel-body -->
                        </div>
                        <!-- /.panel -->
                    </div>
                    <!-- /.col-lg-12 -->
                </div>
                <!-- /.row -->
            </div>
                </div>
                
                <!-- /.col-lg-12 -->
            </div>
            <!-- /.row -->
            <!-- /#page-wrapper -->
        </div>
        <!-- /#wrapper -->
        <!-- jQuery -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <!-- Bootstrap Core JavaScript -->
        <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
        <!-- Metis Menu Plugin JavaScript -->
        <script src="vendor/metisMenu/metisMenu.min.js"></script>
        <!-- Custom Theme JavaScript -->
        <script src="dist/js/sb-admin-2.js"></script>
</body>
</html>