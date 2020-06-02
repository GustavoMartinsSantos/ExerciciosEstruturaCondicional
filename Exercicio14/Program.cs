using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite M para masculino e F para feminino: ");
            char sexo = char.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em cm: ");
            double altura = double.Parse(Console.ReadLine());

            double peso = 0;

            if (sexo == 'M')
                peso = (altura * 0.95) - 95;
            else if (sexo == 'F')
                peso = (altura * 0.85) - 85;
            else
                Console.WriteLine("ERRO!");

            Console.WriteLine("O peso ideal para uma pessoa da sua altura é" +
            " de " + peso + "Kg");
        }
    }
}