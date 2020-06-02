using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a hora de início do jogo de Xadrez: ");
            int horai = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora de término do jogo de Xadrez: ");
            int horaf = int.Parse(Console.ReadLine());

            if (horai < 24 && horai >= 0 && horaf < 24 && horaf >= 0) {
                if (horaf > horai)
                    Console.WriteLine("A duração do jogo é de " + (horaf - horai)
                    + " horas.");
                else if (horaf == horai)
                    Console.WriteLine("A duração do jogo é de " + 24 + " horas.");
                else if (horaf == 0) {
                    horaf = 24;
                    Console.WriteLine("A duração do jogo é de " + (horaf - horai));
                } else 
                    Console.WriteLine("ERRO");       
            } else
                Console.WriteLine("ERRO");
        }
    }
}