using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Escreva dois valores: ");
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            // Hello Github

            if (num != num2) {
                if (num > num2)
                    Console.WriteLine("O maior desses números é {0}", num);
                else
                    Console.WriteLine("O maior desses números é {0}", num2);
            }
        }
    }
}