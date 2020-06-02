using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade atual em estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima em estoque: ");
            int maxima = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade mínima em estoque: ");
            int minima = int.Parse(Console.ReadLine());

            double media = (maxima + minima) / 2;

            if (estoque >= media)
                Console.WriteLine("Não efetuar compra");
            else
                Console.WriteLine("Efetuar compra");
        }
    }
}