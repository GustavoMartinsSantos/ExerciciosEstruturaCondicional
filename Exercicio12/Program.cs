using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número da sua conta: ");
            string num = Console.ReadLine();

            Console.Write("Digite o seu saldo: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o débito: ");
            double debito = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double credito = double.Parse(Console.ReadLine());

            saldo = saldo - debito + credito;
            Console.WriteLine("Saldo atual R${0}", saldo);

            if (saldo >= 0)
                Console.WriteLine("Saldo positivo");
            else
                Console.WriteLine("Saldo negativo");
        }
    }
}