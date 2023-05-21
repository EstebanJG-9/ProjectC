<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="Login_09_Marzo_V1.Recursos.Paginas.FrmLogin" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta name="viewport" content="width-device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <title>Inicio de Sesión</title>
</head>
<body>
    <form id="FrmLogin"  class="container d-flex justify-content-center aling-items-center" runat="server">
        <div class="col-5">
            <div class="form-control card card-body align-items-center h3 mt-5">
                <div class="modal-title aling-content-center h3"></div>
                <asp:Label ID="Label1" runat="server" Text="Inicio de Sesión" Font-Size="Large"></asp:Label>
            </div>
            <br />
            <div class="input-group">
                <asp:TextBox ID="txUsuario" Cssclass="form-control" placeholder="USUARIO" runat="server"></asp:TextBox>
            </div>
            <br />
            <div class="input-group">
                <asp:TextBox ID="tbClave" Cssclass="form-control" placeholder="PASSWORD" runat="server"></asp:TextBox>
            </div>
            <br />
            <div class="input-group">
                <asp:Button ID="btn_validar" Cssclass="form-control btn btn-dark" runat="server" Text="VALIDAR" />
            </div>
            <br />
            <div class="input-group">
                <asp:Label ID="lb_error" runat="server" class="alert-danger" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server"  Text="Registrese"></asp:Label>
                <asp:LinkButton ID="Button1" runat="server" Text="ACA" />
            </div>



        </div>
    </form>
</body>
</html>

