using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano >= 0) {
                ano = 2020 - ano;

                if (ano >= 18)
                    Console.WriteLine("Você deve votar este ano!");
                else 
                    Console.WriteLine("Você ainda não pode votar.");
            }
        }
    }
}