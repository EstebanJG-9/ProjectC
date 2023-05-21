<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nosotros.aspx.cs" Inherits="Login_ASP.Nosotros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <link href="Recursos/Estilos/Nosotros.css" rel="stylesheet" />
    <title>Nosotros</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <header>
        <div class="logo">
            <img src="img/icono_1.ico" alt="logo animales">
        </div>
        <nav>
           <a href="Index.aspx">INICIO</a>
            <a href="Animales.aspx">ANIMALES</a>
            <a href="Nosotros.aspx">NOSOTROS</a>
        </nav>
    </header>

    <main>
        <div class="contenedor-img">
            <div class="img-principal">
                <img src="img/img_2.jpg" alt="img">
            </div>
        </div>
        <section>
            <h2>Quines somos?</h2>
        </section>
        <section>
            <div class="contenedor-nosotros">
                <p>
                    Somos un sitio web dedicado a los animales , creando conciencia sobre los diferente tipos de
                    animales ,ya sea la raza especie habitad y ecosistema , buscamos fomentar el cuidado animal
                    nutriéndonos de conocimiento acerca de estas hermosos seres vivos ,
                </p>
                <img src="img/img_8.jpg" alt="img-">
            </div>
        </section>
    </main>
    <footer>
        <div class="contenedor-footer">
            <div class="content-foo">
                <h5>Telefono : 6484854</h4>

            </div>
            <div class="content-foo">
                <h5>Email : juan.gomez.pachon@pi.eduo.co</h4>

            </div>
            <div class="content-foo">
                <h5>Direccion : calle#13c </h4>

            </div>
        </div>
        <h5 class="titulo-final">&copy;Esteban gomez </h2>
    </footer>

        </div>
    </form>
</body>
</html>
