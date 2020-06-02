using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            num = num - 1;

            Console.WriteLine("O seu antecessor é igual a {0}", num);
        }
    }
}