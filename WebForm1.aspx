<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Menu2.WebForm1" %>

<!DOCTYPE html>


<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Inventario Informatica</title>

    <!-- Bootstrap Core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- MetisMenu CSS -->
    <link href="vendor/metisMenu/metisMenu.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="dist/css/sb-admin-2.css" rel="stylesheet">

    <!-- Morris Charts CSS -->
    <link href="vendor/morrisjs/morris.css" rel="stylesheet">

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
            top: 14px;
            left: -17px;
            float: left;
            width: 13%;
            height: 60px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style2 {
            left: -5px;
            top: 46px;
        }
        .auto-style3 {
            position: relative;
            min-height: 1px;
            top: 6px;
            left: 115px;
            float: left;
            width: 25%;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style4 {
            position: relative;
            min-height: 1px;
            top: 8px;
            left: 113px;
            float: left;
            width: 25%;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style5 {
            left: 93px;
            top: -43px;
        }
        .auto-style6 {
            position: relative;
            min-height: 1px;
            top: 6px;
            left: 114px;
            float: left;
            width: 25%;
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
                        <li><a href="#"><i class="fa fa-user fa-fw"></i> Usuario</a>
                        </li>
                        <li><a href="#"><i class="fa fa-gear fa-fw"></i> Ajustes</a>
                        </li>
                        <li class="divider"></li>
                        <li><a href="login.aspx"><i class="fa fa-sign-out fa-fw"></i> Salir</a>
                        </li>
                    </ul>
                    <!-- /.dropdown-user -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-top-links -->

            <br /> 

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
                            <a href="index.html"><i class="fa fa-dashboard fa-fw"></i> Ingresar</a>
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
                                    <a href="Consultar_Bodega.aspx">Consultar Bodega</a>
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
                                    <a href="Modificar_Bodega.aspx">Modificar Bodega</a>
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
                                    <a href="Eliminar_Bodega.aspx">Eliminar  Bodega</a>
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
                <div class="col-lg-12">
                    <center><h2 class="page-header">Inventario Dispositivos Informaticos </h2></center>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!-- /.row -->

            <div class="col-lg-3 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="auto-style6">
                                    <i class="fa fa-comments fa-5x "></i>
                                </div>
                                <div class="auto-style5">
                                    <div class="huge">26</div>
                                    <div>Ingresar</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <span class="pull-left">Detalles</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>


               <div class="col-lg-3 col-md-6">
                    <div class="panel panel-green">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="auto-style6">
                                    <i class="fa fa-tasks fa-5x"></i>
                                </div>
                                <div class="auto-style5">
                                    <div class="huge">45</div>
                                    <div>Consultar</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <span class="pull-left">Detalles</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>


               <div class="col-lg-3 col-md-6">
                    <div class="panel panel-yellow">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="auto-style6">
                                    <i class="fa fa-shopping-cart fa-5x"></i>
                                </div>
                                <div class="auto-style5">
                                    <div class="huge">16</div>
                                    <div>Modificar</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <span class="pull-left">Detalles</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>


                <div class="col-lg-3 col-md-6">
                    <div class="panel panel-red">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="auto-style6">
                                    <i class="fa fa-support fa-5x"></i>
                                </div>
                                <div class="auto-style5">
                                    <div class="huge">3</div>
                                    <div>Eliminar</div>
                                </div>
                            </div>
                        </div>
                        <a href="#">
                            <div class="panel-footer">
                                <span class="pull-left">Detalles</span>
                                <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                <div class="clearfix"></div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
            <!-- /.row -->

                
            <!-- /.panel-body -->
        </div>
                    <!-- /.panel -->

                        <!-- /.panel-heading -->

                                <!-- /.col-lg-4 (nested) -->
                                <div class="col-lg-8">
                                    <div id="morris-bar-chart"></div>
                                </div>
                                <!-- /.col-lg-8 (nested) -->
                            </div>
                            <!-- /.row -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->

                <!-- /.col-lg-8 -->

                <!-- /.col-lg-4 -->
            </div>
            <!-- /.row -->
       

    <!-- jQuery -->
    <script src="vendor/jquery/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="vendor/metisMenu/metisMenu.min.js"></script>

    <!-- Morris Charts JavaScript -->
    <script src="vendor/raphael/raphael.min.js"></script>
    <script src="vendor/morrisjs/morris.min.js"></script>
    <script src="data/morris-data.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="dist/js/sb-admin-2.js"></script>

</body>

</html>


