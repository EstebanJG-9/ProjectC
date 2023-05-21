<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegistro.aspx.cs" Inherits="Login_09_Marzo_V1.Recursos.Paginas.FrmRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
 <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>

<script src="../JavaScript/JavaScript.js"></script>

    <title>Registro usuarios</title>
</head>
<body>
    <form id="FrmRegistro" runat="server">
        <div class="container d-flex justify-content-center">
           <div class="col-8">
               <div class="form-control card card-body mt-5">
                   <div class="row justify-content-center">
                       <asp:Label ID="Label1" runat="server" Cssclass="row justify-content-center h3" Text="REGISTRO DE USUARIOS"></asp:Label>
                   </div>
                   <fieldset>
                       <legend class="row justify-content-center">Datos Personales</legend>
                       <div class="input-group">
                           <asp:Label ID="Label2" runat="server" Cssclass="forms-control" Text="NOMBRES"></asp:Label>
                           <asp:TextBox ID="tx_nombre" Cssclass="forms-control" placeholder="Esteban G" runat="server"></asp:TextBox>
                       </div>
                       <br />
                         <div class="input-group">
                           <asp:Label ID="Label3" runat="server" Cssclass="forms-control" Text="APELLIDOS"></asp:Label>
                           <asp:TextBox ID="tx_apellido" Cssclass="forms-control" placeholder="Esteban G" runat="server"></asp:TextBox>
                       </div>
                         <br />
                         <div class="input-group">
                           <asp:Label ID="Label4" runat="server" Cssclass="forms-control" Text="FELLA NACIMIENTO"></asp:Label>
                           <asp:TextBox ID="tx_fecha" Cssclass="forms-control" TextMode="Date" runat="server"></asp:TextBox>
                       </div>
                   </fieldset>
                   <br />
                    <fieldset>
                       <legend class="row justify-content-center">Inicio De Sesion</legend>
                       <div class="input-group">
                           <asp:Label ID="Label5" runat="server" Cssclass="forms-control" Text="USUARIO"></asp:Label>
                           <asp:TextBox ID="tx_usuario" Cssclass="forms-control" placeholder="USUARIO" runat="server"></asp:TextBox>
                       </div>
                       <br />
                         <div class="input-group">
                           <asp:Label ID="Label6" runat="server" Cssclass="forms-control" Text="CONTRASEÑA"></asp:Label>
                           <asp:TextBox ID="tx_contra" Cssclass="forms-control" TextMode="Password" placeholder="PASSWORD" runat="server"></asp:TextBox>
                       </div>
                         <br />
                         <div class="input-group">
                           <asp:Label ID="Label7" runat="server" Cssclass="forms-control" Text="CONFRIMAR CLAVE"></asp:Label>
                           <asp:TextBox ID="tx_contra2" Cssclass="forms-control" TextMode="password" placeholder="CONFIRMAR" runat="server"></asp:TextBox>
                       </div>
                          <br />
                   <div class="row justify-content-center">
                       <asp:Image ID="Image1" runat="server" Cssclass="img-thumbnail" Width="150" Height="150" ImageUrl="~/Recursos/Imagenes/img_1.jpg"/>
                   </div>
                   <br />
                     <div class="row justify-content-center">
                         <asp:FileUpload ID="FUImage" runat="server" Cssclass="small form-control" onchange="mostrarimagen(this)" />
                   </div>
                   </fieldset>
                   <br />
                   <asp:Label ID="lb_error" runat="server" CssClass="alert-danger" Text="Label"></asp:Label>
                   <br />
                   <div class="row">
                       <asp:Button ID="bt_completar" Cssclass="form-control btn btn-success" runat="server" Text="Completar Registro" OnClick="Registrar" />
                       <hr />
                        <asp:Button ID="btn_cancelar" Cssclass="form-control btn btn-warning" runat="server" Text="Cancelar" OnClick="Cancelar"/>
                   </div>

               </div>
           </div>
        </div>
    </form>


</body>
</html>
