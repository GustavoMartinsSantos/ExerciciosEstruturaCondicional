using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor da base: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            double h = double.Parse(Console.ReadLine());

            double valor;

            if (b != h) { 
                valor = b * h;
                Console.WriteLine("A área desse retângulo é igual a {0}", valor);
            } 
        }
    }
}