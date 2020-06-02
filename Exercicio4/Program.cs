using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de maçãs que você vai comprar: ");
            int numacas = int.Parse(Console.ReadLine());
            double valor;

            if (numacas < 12 && numacas > 0)
                valor = numacas * 0.30;
            else if (numacas >= 12)
                valor = numacas * 0.25;
            else
                valor = 0;

            Console.WriteLine("O valor total é igual a {0}", valor + "R$");
        }
    }
}