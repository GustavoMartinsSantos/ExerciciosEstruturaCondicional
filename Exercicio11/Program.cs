using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor das vendas efetuadas: ");
            double valor = double.Parse(Console.ReadLine());

            if (salario <= 1500 && salario > 0)
                salario = (valor * 3 / 100) + salario;
            else if (salario > 0)
                salario = (valor * 5 / 100) + salario;
            else
                Console.WriteLine("Você digitou o salário errado!");

            Console.WriteLine("Seu salário somado com a comissão é igual a R${0}", salario);
        }
    }
}