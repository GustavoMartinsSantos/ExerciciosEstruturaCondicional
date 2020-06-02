using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            string senha = "1234";

            Console.Write("Digite a senha: ");
            string valor = Console.ReadLine();

            if (valor == senha)
                Console.WriteLine("ACESSO PERMITIDO");
            else
                Console.WriteLine("ACESSO NEGADO");
        }
    }
}