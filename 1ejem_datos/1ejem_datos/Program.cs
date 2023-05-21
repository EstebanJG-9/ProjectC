using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ejem_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables 
            //constante 

            const String mes = "octubre";
            const int dia = 14;// que ya esta declarado 
            const int anio = 2022;
            const int incre = 10;

            int edad_actu;
            double estatura;
            int aumento, actual, neto;




            Console.WriteLine("fecha de clase .........:" + dia + "  " + mes + " " + anio + "\n\n");


            //comando mostarr informacion 
            Console.WriteLine("\t\taplicacion tipo escritorio c#\a");
            Console.WriteLine("\n\tEjemplo de concatenacion ");

            // usar operador 
            Console.Write("ingrese su primer apellido ........");
            String ape1 = Console.ReadLine();

            Console.WriteLine("ingrese su primer nombre  ........");
            String nom1 = Console.ReadLine();

            String nombre = ape1 + " " + nom1;

            // captura de datoa numerico
            Console.WriteLine("año de nacimiento.........:");
            int naci = int.Parse(Console.ReadLine());// redline me ayuda a capturarlo 

            Console.WriteLine("cuanto mide .........:");
            estatura = double.Parse(Console.ReadLine());


            Console.WriteLine("sueldo al que aspira tener ..............:");
            String sueldo = Console.ReadLine(); // forma sin parseo de datos solo capturarlo




            //operaciones matematicas
            edad_actu = anio - naci;
            //parsear tipo texto a numerico 
            actual = int.Parse(sueldo);

            aumento = (actual * incre) / 100;
            neto = (actual + aumento);

            ///Convert.ToInt32(Console.ReadLine());// otro tipo de conversion de datos 

            // int aumento;




            // salida 
            Console.WriteLine(nom1 + " " + ape1);
            Console.WriteLine("el usuario de llama--------: " + nombre);
            Console.WriteLine("año de nacimiento----------: " + naci);
            Console.WriteLine("el ali 2022 ud tiene----------: " + edad_actu + " años");
            Console.WriteLine("su estatura es --------: " + estatura + " ");
            Console.WriteLine("sueldo deseado  --------: " + sueldo + " ");
            Console.WriteLine("***************************************** \n ");
            Console.WriteLine("\t\t contratado\n ");
            Console.WriteLine("aumento del: " + incre + "% ......$  " + aumento);
            Console.WriteLine("neto a pagar: ......$  " + neto );





            // pausa 
            Console.ReadLine();



        }// fin main 
    }// fin class program 
}// fin namespace 
