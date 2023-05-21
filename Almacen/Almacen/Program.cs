using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace Almacen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //variables

            int tam=0,buscarv=0,post=0,logitudv=0,logitudp=0;
            string rol="";
            string usuariog,usuario,usuarioc,usuariov,buscarp;
            string prod = "";
            string prodc = "";
            string claveg,clave,clavec,clavev;
            int intentos = 1;
            bool validacion = true;
            bool bandera= true; 
          
            //gerente 

            usuariog = "gere23";
            claveg = "1233";

            //cajero

            usuarioc = "caje24";
            clavec = "1234";

            //vendedor 
            usuariov = "vend25";
            clavev = "1222";

            //   iniciar session 

            Console.Write("\t\t\t"+" ALAMACEN "+"\n\n");



            do
            {
                if (intentos >= 3) {
                
                 validacion= false; 
                }//fin if 
               
                Console.Write("INICIAR SESION " + "\n\n");

                Console.Write("Ingrese su usuario ...:");
                usuario = Console.ReadLine();
           
                Console.Write("Ingrese su clave ...:");
                clave = Console.ReadLine();

                Console.Clear();

                if (usuario == usuariog && clave == claveg)
                {


                    Console.Write("gerente ");

                    // Console.Write("# 1 Ingresar productos");******
                    // Console.Write("# 2 Mostrar producto venta "); vendedor 
                    // Console.Write("# 3 Mostrar producto factura"); // los producto son
                    // Console.Write("# 4 Buscar producto")**********; vendedor 
                    //  Console.Write("# 5 Valor Agregado");**********   // busca el valor con el producto 
                    // Console.Write("# Salir ");

                    Console.Write("cuantos producto va ingresar  ");
                    tam = int.Parse(Console.ReadLine());

                    //valor del vector cantidad de productos 
                    string[] vectorProducto = new string[tam];
                    int logitud = vectorProducto.Length;

                    //buscar gerente 
                    for (int i = 0; i < tam; i++)
                    {


                        Console.Write("Ingrese  el producto ...:");
                        vectorProducto[i] = Console.ReadLine();

                    } //fin for


                    //mostrar la informacion capturada 
                    Console.Write("\t\t\t" + "PRODUCTOS INGRESADOS " + "\n\n");


                    for (int i = 0; i < tam; i++)
                    {

                        Console.WriteLine("registro  # " + (i + 1) + " valor --> " + vectorProducto[i]);
                    }//fin for




                    //ingreso del precio de los productos
                    int[] vectorvalor = new int[tam];

                    for (int i = 0; i < logitud; i++)
                    {

                        Console.Write("Ingrese  un valor $  ...:");

                        vectorvalor[i] = int.Parse(Console.ReadLine());



                    }//fin for

                    //mostrar la informacion capturada 
                    Console.Write("\t\t\t" + "REGISTRO PRODUCTO CON EL VALOR " + "\n\n");

                    for (int i = 0; i < logitud; i++)
                    {

                        Console.WriteLine("registro  # " + vectorProducto[i] + "  --> " + vectorvalor[i]);

                        // Console.Clear();
                    }//fin for



                }//fin if
                else if (usuario == usuarioc && clave == clavec)
                {

                    Console.Write("cajero  ");

                    //buscar  precios de los productos 

                  


                    double[] vectorvalor = new double[5];
            
                    vectorvalor[0] = 2.500;
                    vectorvalor[1] = 3.750;
                    vectorvalor[2] = 5.500;
                    vectorvalor[3] = 800;
                    vectorvalor[4] = 3.500;


                    string[] vectorProducto = new string[5];
            
        
                    vectorProducto[0] = "gaseosa";
                    vectorProducto[1] = "pan";
                    vectorProducto[2] = "papas";
                    vectorProducto[3] = "gelatina";
                    vectorProducto[4] = "Pony malta ";

                    int[] vectorventa = new int[5];
        
                    vectorventa[0] = 456785;
                    vectorventa[1] = 456785;
                    vectorventa[2] = 456785;
                    vectorventa[3] = 456785;
                    vectorventa[4] = 456785;




                    Console.Write("\t\t\t Buscar un registro\n:");


                    for (int i = 0; i < 5; i++)
                    {

                        Console.Write("¿que  precio esta buscando?......::");
                        //buscarv = int.Parse(Console.ReadLine());
                        vectorvalor[i] = int.Parse(Console.ReadLine());


                        Console.Write("¿que  producto esta buscando?......::");
                        vectorProducto[i] = Console.ReadLine();


                        if (!string.IsNullOrEmpty(vectorProducto[i])) {

                            Console.WriteLine("registro  # " + vectorProducto[i] + "  --> " + vectorvalor[i] + "  --->  " + " Cod Caja  " + vectorventa[i]);



                        }//fin if 
                        else {

                            Console.WriteLine("valor invalido");
                        
                        }//fin else
                       

                    }//fin for 
              
                }//fin else if

                else if (usuario == usuariov && clave == clavev)
                {


                    Console.Write("vendedor   ");


                    double[] vectorvalor = new double[5];
                    int logitud = vectorvalor.Length;
                    vectorvalor[0] = 2.500;
                    vectorvalor[1] = 3.750;
                    vectorvalor[2] = 5.500;
                    vectorvalor[3] = 800;
                    vectorvalor[4] = 3.500;


                    string[] vectorProducto = new string[5];
                    int logitudproducto = vectorvalor.Length;
                    vectorProducto[0] = "gaseosa";
                    vectorProducto[1] = "pan";
                    vectorProducto[2] = "papas";
                    vectorProducto[3] = "gelatina";
                    vectorProducto[4] = "Pony malta ";

                    int[] vectorcode = new int[5];
                    int logitudventa = vectorcode.Length;
                    vectorcode[0] = 456;
                    vectorcode[1] = 955;
                    vectorcode[2] = 7815;
                    vectorcode[3] = 6565;
                    vectorcode[4] = 4445;




                    //buscar vendeor 

                    Console.Write("\t\t\t Buscar productos \n:");


                    for (int i = 0; i < 5; i++)
                    {

                        Console.Write("¿que  precio esta buscando?......::");
                        //buscarv = int.Parse(Console.ReadLine());
                        vectorvalor[i] = int.Parse(Console.ReadLine());


                        Console.Write("¿que  producto esta buscando?......::");
                        vectorProducto[i] = Console.ReadLine();


                        if (!string.IsNullOrEmpty(vectorProducto[i]))
                        {

                            Console.WriteLine("registro  # " + vectorProducto[i] + "  --> " + vectorvalor[i] + "  --->  " + " Cod Vendedor  " + vectorcode[i]);



                        }//fin if 
                        else
                        {
                            Console.Write("**********************");
                            Console.WriteLine("valor invalido");
                            Console.Write("**********************");
                        }//fin else


                        //mostrar la informacion capturada 
                        Console.WriteLine("*********************************************");
                        Console.Write("\t\t\t" + "REGISTRO  DE PRODUCTOS " + "\n\n");
                        Console.WriteLine("*********************************************");

                        for (int j = 0; j < logitud; j++)
                        {

                            Console.WriteLine("registro  # " + vectorProducto[j] + "  --> " + vectorvalor[j] + "  --->  " + " Cod Vendedor  " + vectorcode[j]);



                           
                        }//fin for

                    }

                }//fin for 

                Environment.Exit(0);





            } while (validacion );

           // Environment.Exit(0);
            Console.ReadKey();

          //  Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespace
