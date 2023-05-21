using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 
programa que permita almacenar 10 valores en un 
vector que represnre las edades de 10 personas 
y luego muestre cada uno de los valores ingresados
 
 */

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam  = 0;

            //bienvenida
            Console.Write("\t\t\t"+"PROGRAMA PARA ALMACENAR EDADES "+"\n\n");

            //entrada de datos 
            Console.Write("Ingrese el tamaño del vector ...:");
            tam = int.Parse(Console.ReadLine());

            //declaracion de vector
            int[] vector =new int[tam];

            //llenar el vector 

            for (int i = 0;i <tam;i++) {

                Console.Write("dato #"+(i+1)+"Ingrese  la edad ...:");
                vector[i] = int.Parse(Console.ReadLine());
            
            
            }//fin fo

            //mostrar la informacion capturada 
            Console.Write("\t\t\t" + "Reporte de registrso insertados" + "\n\n");

            for (int i = 0; i < tam;i++) {

                Console.WriteLine("registro  # "+(i+1)+" valor --> " + vector[i]);
            }//fin for

            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
