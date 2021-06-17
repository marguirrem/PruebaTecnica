<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NOM.WA.DATOSEMPLEADO.FE.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Frontend</title>
    <link href="src/css/bootstrap.min.css" rel="stylesheet" />
    <link href="src/css/app.css" rel="stylesheet" />
    <script src="src/js/app.js"></script>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="#">TEST</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
      </li>
  
     
    </ul>
  </div>
</nav>
    <form id="form1" runat="server">
        <div class="container">

            <div class="alert alert-success alert-dismissible fade show alertas" role="alert" id="salvo">
                FUERA DE PELIGRO
                 <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                     <span aria-hidden="true">&times;</span>
                 </button>
            </div>
            <div class="alert alert-danger alert-dismissible fade show alertas" role="alert" id="media">
                TENGA CUIDADO, TOME TODAS LAS MEDIDAS DE PREVENSION
                 <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                     <span aria-hidden="true">&times;</span>
                 </button>
            </div>
            <div class="alert alert-danger alert-dismissible fade show alertas" role="alert" id="tercera">
                POR FAVOR QUEDARSE EN CASA
                 <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                     <span aria-hidden="true">&times;</span>
                 </button>
            </div>
            <h1>Colaboradores</h1>
            <asp:Button Text="Obtener Colaboradores" CssClass="btn btn-primary" ID="btnObtner" runat="server" OnClick="Unnamed1_Click" />
            <br />
            <asp:GridView ID="gridColaboradores" runat="server" CssClass="table table-striped" OnSelectedIndexChanged="gridColaboradores_SelectedIndexChanged1">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Mostrar Riesgo" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="src/js/jquery-3.5.1.slim.min.js"></script>
    <script src="src/js/bootstrap.bundle.min.js"></script>

</body>
</html>
