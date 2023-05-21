using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ejem_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("MENU DE OPERACIONES ");
            Console.WriteLine("1. VALOR BSOLUTO  ");
            Console.WriteLine("2. RAIZ CUADRADA   ");
            Console.WriteLine("3. SENO   ");
            Console.Write("SELECIONE UNA OPERACION SEGUN EL NUMERO ........  ");

            opc = int.Parse(Console.ReadLine());

            switch (opc) 
            {
                case 1:Console.WriteLine(" MODULO VALOR BSOLUTO  ");
                    double num1 = 0;
                    Console.WriteLine("Ingrese un numero positivo negativo ");
                    num1 = double.Parse(Console.ReadLine());
                    double  potencia = Math.Abs(num1);
                    Console.WriteLine("el valor absoluto del numero "+num1+" es "+potencia);

                    break;
                case 2:  Console.WriteLine(" MODULO RAIZ CUADRADA   ");
                    double num = 0;
                    double Raiz = 0;
                    Console.WriteLine("Ingrese un numero ........: ");
                    num = double.Parse(Console.ReadLine());
                    Raiz = Math.Sqrt(num);
                    Console.WriteLine(" la raiz cuadrada de  " + num + " es " + Raiz);

                    break;

                case 3:Console.WriteLine(" MODULO SENO  ");
                    double nums = 0;
                    double seno  = 0;
                    Console.WriteLine("ingrese un numero.......:");
                    nums= double.Parse(Console.ReadLine());
                    seno = Math.Sin(nums);
                    Console.WriteLine(" el seno del numero    " + nums + "  en radianes es  " + seno );
                    seno = Math.Sin(nums*(Math.PI/180));
                    Console.WriteLine(" el seno del numero    " + nums + " en grados es  " + seno);

                    break;
                default: Console.WriteLine("..........opcion selecionada no existe .........");

                    break;


                   

            }//fin switch 
           
             //pausa 
            Console.Read();


        }//fin main
    }//fin class program
}// fin namespace
