using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
                Console.WriteLine("Esse número é divisível por 3.");
            else
                Console.WriteLine("Esse número não é divisível por 3.");
        }
    }
}