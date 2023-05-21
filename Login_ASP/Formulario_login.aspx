<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario_login.aspx.cs" Inherits="Login_ASP.Formulario_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" /> 
 <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js "></script>
 <script src="https://code.jquery.com/jquery-3.6.3.min.js"></script>
   <link href="Recursos/Estilos/Style.css" rel="stylesheet"/>
    <title>Login ASP</title>
</head>
    <%-- etiqueta --%>
       <body class="bg-saucess">     
    <div class="envoltura align-items-center ">
        <div class="contenido  align-items-center ">
            <form id="Formulario_Login" runat="server">
                <div class="form-control  align-items-center ">
                    <%-- crear una columna para el saludo--%>
                    <div class=" text-center  mb-5">
                        <asp:Label class="h3" ID="lbBienvenida" runat="server" Text="BIENVENIDO USUARIO"></asp:Label>
                    </div>
                    <%-- crear una columna para el usuario--%>
                    <div class=" align-items-center  text-center mb-5 ">
                        <asp:Label ID="lb_usuario" runat="server" Text="USUARIO"></asp:Label>
                        <asp:TextBox ID="tx_usuario" Cssclass="form-control" placeholder="Nombre Usuario" runat="server"></asp:TextBox>
                    </div>
                    <%-- crear una columna para la contraeña--%>
                    <div class=" text-center mb-5">
                        <asp:Label ID="lb_contraseña" runat="server" Text="CONTRASEÑA"></asp:Label>
                        <asp:TextBox ID="tx_contraseña" CssClass="form-control" TextMode="Password" placeholder="Contraseña" runat="server"></asp:TextBox>
                    </div>

                     <div class="row">
     
                        <asp:Button ID="btn_ingresar" CssClass="btn btn-warning" runat="server" Text="INGRESAR" OnClick="BtnIngresar"/>
                     </div>
                </div>
            </form>
        </div>
    </div> 
</body>
</html>
