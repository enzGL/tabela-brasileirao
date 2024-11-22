using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brasileiraoalt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int posicao;

            Dictionary<int, string> times = new Dictionary<int, string>()
        {
            { 1, "Botafogo" },
            { 2, "Palmeiras" },
            { 3, "Fortaleza" },
            { 4, "Flamengo" },
            { 5, "Internacional" },
            { 6, "São Paulo" },
            { 7, "Cruzeiro" },
            { 8, "Bahia" },
            { 9, "Vasco" },
            { 10, "Atlético-MG" },
            { 11, "Corinthians" },
            { 12, "Grêmio" },
            { 13, "EC Vitória" },
            { 14, "Athletico-PR" },
            { 15, "Fluminense" },
            { 16, "Criciúma" },
            { 17, "Juventude" },
            { 18, "Bragantino" },
            { 19, "Cuiabá" },
            { 20, "Atlétigo-GO" }
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
            } while (!flag);

            string time = times[posicao];

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
