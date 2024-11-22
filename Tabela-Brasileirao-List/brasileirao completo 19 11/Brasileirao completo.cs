using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace brasileirao_completo_19_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int posicao;

            string[] times = new string[]
       {
            "Botafogo", "Palmeiras", "Fortaleza", "Flamengo",
            "Internacional", "São Paulo", "Cruzeiro", "Bahia",
            "Vasco", "Athletico-MG", "Corinthians", "Grêmio",
            "EC Vitória", "Athletico-PR", "Fluminense", "Criciúma",
            "Juventude", "Bragantino", "Cuiabá", "Atlético-GO"
       };

            Console.Write("============================\n");
            Console.Write("= Classificação para copas =");
            Console.Write("\n============================\n");

            do
            {
                Console.Write("\nDigite a posição do time no campeonato (1 a 20): ");
                if (int.TryParse(Console.ReadLine(), out posicao) && posicao >= 1 && posicao <= 20)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Posição inválida. Por favor, insira um número entre 1 e 20.");
                }
            } while(!flag);


                string time = times[posicao - 1];

                if (posicao >= 1 && posicao <= 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nO {time} está em {posicao}º na tabela, e se encontra classificado para a Libertadores.");
                    Console.ResetColor();
                }
                else if (posicao > 4 && posicao <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nO {time} está em {posicao}º na tabela, e se encontra classificado para a Pré Libertadores.");
                    Console.ResetColor();
                }
                else if (posicao > 6 && posicao <= 12)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\nO {time} está em {posicao}º na tabela, e se encontra classificado para a Sul-Americana.");
                    Console.ResetColor();
                }
                else if (posicao > 12 && posicao <= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nO {time} está em {posicao}º na tabela, e se encontra na Zona de Rebaixamento.");
                    Console.ResetColor();
                }
            

            Console.ReadKey();
        }
    }
}
