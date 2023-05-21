using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //variables inicio sesión
            string usuario, clave;
            int intentos = 1,tam=3;
            bool salirPrograma = true;

            string USUARIO_GERENTE = "gerente";
            string CLAVE_GERENTE = "123";

            string USUARIO_VENDEDOR = "vendedor";
            string CLAVE_VENDEDOR = "1234";

            string USUARIO_CAJERO = "cajero";
            string CLAVE_CAJERO = "12345";

            //Variables programa
            int opcionMenu;
            string busquedaProducto;
            bool seguirBuscando = true;

            //Arreglos para guardar la información de los productos
            int[] productosCodigo = new int[] { 1, 2, 3 };
            string[] productosNombres = new string[] { "gaseosa", "pan", "papas" };
            double[] productosPrecios = new double[] { 2500, 500, 1500 };

            //valores nuevos 
            int[] codIngresado = new int[3] ;
            string[] productoIngresado = new string[3];
            double[] precioIngresado = new double[3];

       

         



            Console.Write("\t\t\t" + "Almacén ESJH" + "\n\n");
            Console.Write("//////////////////////////////////////////////////////////" + "\n\n");
            do
            {
                //Solicitar Credenciales al usuario
                Console.Write("¡Iniciar Sesion! " + "\n\n");
                Console.Write("Ingrese su Usuario: ");
                usuario = Console.ReadLine();

                Console.Write(".........................................................." + "\n\n");
                Console.Write("Ingrese su Clave: ");
                clave = Console.ReadLine();
                //Valida el inicio de sesión
                if (
                    (usuario == USUARIO_GERENTE && clave == CLAVE_GERENTE) ||
                    (usuario == USUARIO_VENDEDOR && clave == CLAVE_VENDEDOR) ||
                    (usuario == USUARIO_CAJERO && clave == CLAVE_CAJERO)
                )
                {
                    //Se inicia sesión y se crean todas las operaciones del menu
                    Console.Clear();
                    Console.Write("\t\tBienvenido " + usuario + "\n");
                    Console.Write(".........................................................." + "\n\n");
                    while (salirPrograma)
                    {
                        //funciones a realizar
                        Console.WriteLine("***Menu Opciones***");
                        Console.WriteLine("# 1 Ingresar productos");
                        Console.WriteLine("# 2 Mostrar productos");
                        Console.WriteLine("# 3 Mostrar producto factura");
                        Console.WriteLine("# 4 Buscar producto");
                        Console.WriteLine("# 5 Valor Agregado");
                        Console.WriteLine("# 6 Salir del programa");

                        //Solicitud de opción
                        Console.Write("Ingrese la opción deseada: ");
                        opcionMenu = int.Parse(Console.ReadLine());
                        Console.Clear();

                        //Opciones del menu
                        switch (opcionMenu)
                        {
                            case 1:
                                //codigo
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write("Ingrese el codigo  ...:");
                                    codIngresado[j] = int.Parse( Console.ReadLine());

                                } //fin for



                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write("Ingrese  el producto ...:");
                                    productoIngresado[j] = Console.ReadLine();

                                } //fin for

                                //valor productos
                                for (int j = 0; j < tam; j++)
                                { 
                                    Console.Write("Ingrese  el precio  del producto  ...:");
                                    precioIngresado[j] = double.Parse(Console.ReadLine());


                                } //fin for
                                Console.Write("PRODUCTOS INGRESADO " + "\n\n\n ");

                                break;
                            case 2:
                                //Esta opción nos permite mostrar los productos

                              for (int j = 0; j <3; j++)
                                {



                                   // Console.WriteLine("Producto   " + "Codigo  " + productosCodigo[j] + productosNombres[j] + "  --> " + productosPrecios[j]);
                                   // Console.WriteLine("Producto   " + "Codigo  " + codIngresado[j] + productoIngresado[j] + "  --> " + precioIngresado[j]);



                                   
                                     Console.WriteLine("codigo: " + productosCodigo[j]);
                                    Console.WriteLine("Nombre: " + productosNombres[j]);
                                    Console.WriteLine("precio: $" + productosPrecios[j]);
                                  
                                    Console.WriteLine("codigo: " + codIngresado[j]);
                                    Console.WriteLine("Nombre: " +productoIngresado[j]);
                                    Console.WriteLine("precio: $" + precioIngresado[j]);
                                    Console.WriteLine();

                                } //fin for


                                break;
                            case 3:
                                
                                break;
                            case 4:
                                //Esta opción nos permite buscar productos
                                Console.Write(".........................................................." + "\n\n");
                                Console.Write("\t\t\t" + "Buscar un registro" + "\n");
                                Console.Write(".........................................................." + "\n\n");

                                //Permite ejecutar varias busquedas hasta que se desee no seguir buscando
                                while (seguirBuscando)
                                {
                                    //Guarda el nombre del producto a buscar
                                    Console.Write("¿Que  producto está buscando? ");
                                    busquedaProducto = Console.ReadLine();

                                    Console.Write(".........................................................." + "\n\n");

                                    //Permite buscar en el arreglo de productos nombres
                                    int indice = Array.IndexOf(productosNombres, busquedaProducto);

                                    //Comprueba si encontro un producto
                                    if (indice < 0)
                                    {
                                        Console.WriteLine("No se encontro ningun producto");
                                    }//fin if 
                                    else
                                    {
                                        Console.WriteLine("codigo: " + productosCodigo[indice]);
                                        Console.WriteLine("Nombre: " + productosNombres[indice]);
                                        Console.WriteLine("precio: $" + productosPrecios[indice]);
                                    }//fin else

                                    //Valida con el usuario si desea seguir buscando o salir
                                    Console.WriteLine("\nOprime 1 para salir o cualquier tecla para continuar buscando");
                                    string cerrarBusqueda = Console.ReadLine();

                                    //Verifica si el usuario desea salir
                                    if (cerrarBusqueda == "1")
                                    {
                                        seguirBuscando = false;
                                    }
                                    Console.Clear();
                                }
                                break;
                            case 5:
                                //?????????????
                                break;
                            case 6:
                                //Salir del programa
                                salirPrograma = false;
                                break;
                            default:
                                Console.WriteLine("Lo siento, no encontramos esta opción\n");
                                break;
                        }
                    }//fin while
                }//fin if
                else
                {
                    Console.Clear();
                    Console.WriteLine("¡Usuario o Clave invalida!");
                    Console.WriteLine("Usted lleva " + intentos + " intentos\n");
                    intentos++;
                }

                //Cierra el programa cuando se cumple el limite de intentos
                if (intentos > 3)
                {
                    Console.WriteLine("Se exedieron el limite de intentos");
                    salirPrograma = false;
                    Console.ReadLine();
                }


            } while (salirPrograma);

        }//fin main
    }
}