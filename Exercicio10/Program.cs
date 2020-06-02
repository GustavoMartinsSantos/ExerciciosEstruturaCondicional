using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de horas trabalhadas no mês: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que você ganha por hora R$");
            double valor = double.Parse(Console.ReadLine());

            double calculo = num;
            double acrescimo;
            double porcentagem = 50;

            if (calculo > 40) {
                acrescimo = (num - 40) * valor;
                calculo = (acrescimo * porcentagem / 100) + (40 * valor);
            } else
                calculo = num * valor;

            Console.WriteLine("O seu salário total é de R${0}", calculo);
            Console.ReadKey();
        }
    }
}