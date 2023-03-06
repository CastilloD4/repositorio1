using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primero declarar las variables 
            int x = 5;
            int y = 6;
            int z = 20;

            //Realizar asignación de valores
            Console.WriteLine(x + y + z);
            Console.WriteLine(x.ToString() + y.ToString());

            //Solicitar valores y almacenarlos 

            Console.WriteLine("Ingrese el valor 1");
            string value1 = Console.ReadLine();
            int value1Number = Int32.Parse(value1);

            Console.WriteLine("Ingrese el valor 2");
            string value2 = Console.ReadLine();
            int value2Number = Int32.Parse(value2);

            // Sumar los números
            Console.WriteLine(value1Number + value2Number);
            // Restar los números
            Console.WriteLine(value1Number - value2Number);
            // Multiplicar los números
            Console.WriteLine(value1Number * value2Number);
            // Dividir los números
            Console.WriteLine(value1Number / value2Number);

        }
    }
}
