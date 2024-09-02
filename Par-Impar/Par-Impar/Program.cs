using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Cálculo de Par ou Ímpar");
            Console.WriteLine("-----------------------");
            int n1 = 0;
            Console.Write("Informe um número inteiro: ");
            int.TryParse(Console.ReadLine(), out n1);

            string resultado = (n1 % 2 == 0) ? "Par" : "Ímpar";

            Console.WriteLine($"O número {n1:D} é {resultado}");
            Console.ReadKey();
        }
    }
}
