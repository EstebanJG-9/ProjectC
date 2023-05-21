<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="animales.aspx.cs" Inherits="Pagina_Animales.animales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="estilos/animales.css">
    <link rel="shortcut icon" href="imagenes/icono_2.ico" type="image/x-icon">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

              <header>
        <div class="logo">
            <img src="imagenes/icono_1.ico" alt="logo animales">
        </div>
        <nav>
            <a href="default.aspx">INICIO</a>
            <a href="animales.aspx">ANIMALES</a>
            <a href="nosotros.aspx">NOSOTROS</a>
        </nav>
    </header>

    <main>
        <div class="contenedor-img">
            <div class="imagenes-principal">
                <img src="imagenes/img_2.jpg" alt="img">
            </div>


        </div>

        <div class="container">
            <div class="card">
                <figure>
                    <img src="imagenes/img_9.jpg" alt="">
                </figure>
                <div class="contenido">
                    <h3>Mamiferos</h3>
                    <p>
                        Los mamíferos son una clase de animales vertebrados amniotas homeotermos que poseen glándulas
                        mamarias productoras de leche con las que alimentan a las crías. La mayoría son vivíparos.
                    </p>
                    <h3>cantidad 4,381</h3>
                    <a href="#">leer mas</a>
                </div>
            </div>
            <div class="card">
                <figure>
                    <img src="imagenes/img_10.jpg" alt="">
                </figure>
                <div class="contenido">
                    <h3>Reptiles</h3>
                    <p>
                        Los reptiles, ​​ son un grupo de animales vertebrados amniotas provistos de escamas epidérmicas
                        de queratina. Se trata de una clase propia de la taxonomía tradicional
                    </p>
                    <h3>cantidad 8,238</h3>
                    <a href="index.html">leer mas</a>
                </div>
            </div>
            <div class="card">
                <figure>
                    <img src="imagenes/img_11.jpg" alt="">
                </figure>
                <div class="contenido">
                    <h3>Aves</h3>
                    <p>
                        Las aves son animales vertebrados, de sangre caliente, que caminan, saltan o se mantienen solo
                        sobre las extremidades posteriores.
                    </p>
                    <h3>cantidad 9,271</h3>
                    <a href="#">leer mas</a>
                </div>
            </div>
        </div>

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
