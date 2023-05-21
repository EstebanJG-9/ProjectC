using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 programa para determinar un numero ingresado por el usuario es 
 positivo o negatico 
 */
namespace Programa_NpositivosNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int num = 0, positivo = 0,negativo=0;

            //Bienvenida 
            Console.Write("\t\t\t"+"BIENVENIDO PROGRAMA PARA VERIFICAR SI UN NUMERO ES POSITIVO O NEGATICO"+"\n\n");

            //entrada de datos 

            Console.Write("Ingrese un numero .....:");
            num = int.Parse(Console.ReadLine());

            //sentencia if 
            //en donde si numero es mayor a 0 es positivo 
            if (num > 0) {

                Console.Write("numero positivo");
            
            
            }//fin inf
            //sentencia else if es otra condicion en donde si numero es menor a 0 es negativo 
            else if(num < 0) {

                Console.Write("numero negativo");
            }//fin else if 

            //else si no es niguna de las anteriores el numero es neutro 

            else
            {
                Console.Write("numero neutro ");
            }//fin else

            Console.ReadLine();


        }//fin main
    }//fin class
}//fin namespaces
