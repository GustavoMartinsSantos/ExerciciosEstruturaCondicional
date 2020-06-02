using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num != num2) {
                if (num > num2)
                    Console.WriteLine(num2 + " - {0}", num);
                else
                    Console.WriteLine(num + " - {0}", num2);
            }
        }
    }
}