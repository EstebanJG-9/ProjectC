using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa que permita realizar los siguinetes
 requerimientos:


   1. caluclar distancia recorrdia
   2. caluclar tiempo
   3. calcular velocidad

 dependiendo de lo que seleccione el usuario se debe
 solicitar los datos correspondientes y la operacion 
 adecuada , teniendo en cuenta el movimiento rectilineo
 uniforme cuya principal ecuacion es : V = V*T
 
 */
namespace Programa_CalcularDistancia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int opc;
            double velo=0, timp=0, dist=0,result=0;

            //Bienvenida 
            Console.Write("\t\t\t"+"PROGRAMA PARA CALCULAR DISTNACIA "+"\n\n");

            //entrada de datos

            Console.WriteLine(" # 1 Calcular distancia recorrida");
            Console.WriteLine(" # 2 Calcular Tiempo");
            Console.WriteLine(" # 3 Calcular Velocidad ");
            Console.Write(" Selecione la opcion que desea realizar ....:");
            opc = int.Parse(Console.ReadLine());

            //sentencia switch case para selecionar la opcion tipo menu 

            switch (opc)
            {

                case 1:
                    //entra de datos de la opcion 1
                    Console.Write("Ingrese la Velocidad  /KM");
                    velo = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el tiempo   /T");
                    timp = double.Parse(Console.ReadLine());
                    //operacion de V*T
                    result = velo * timp;
                    //salida de datos
                    Console.Write("la distancia recorrida es ---> " + " " + result + "KM/H");

                    break;

                case 2:
                    //entra de datos de la opcion 1
                    Console.Write("Ingrese la Velocidad  /KM*H");
                    velo = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la distancia destino   /D*S");
                    dist = double.Parse(Console.ReadLine());
                    //operacion de V*T
                    result = dist / velo;
                    //salida de datos
                    Console.WriteLine("El tiempo restante es  ---> " + " " + result + "s");

                    break;

                case 3:
                    //entra de datos de la opcion 1
                    Console.Write("Ingrese la distancia   /KM*H");
                    dist = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el timpo   /D*T");
                    timp = double.Parse(Console.ReadLine());
                    //operacion de V*T
                    result = dist / timp;
                    //salida de datos
                    Console.WriteLine("El tiempo restante es  ---> " + " " + result + "KM/H");

                    break;



                default:
                    Console.WriteLine("opcion Invalida ");
                    break;

            }//fin  switch


            Console.ReadLine();
        }//fin man 
    }//fin class
}//fin namespace
