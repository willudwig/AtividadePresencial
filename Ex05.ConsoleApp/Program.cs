using System;

namespace Ex05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int play1, play2;
            int contPlay1 = 0;
            int contPlay2 = 0;
            int i = 1;
            string jog1 = "";
            string jog2 = "";

            Random dados = new Random();

            Console.Write("Idenfiticar jogador 01 : ");
            jog1 = Console.ReadLine();
            Console.Write("Idenfiticar jogador 02 : ");
            jog2 = Console.ReadLine();

            Console.Clear();

            while (i <= 3)
            {
                Console.WriteLine("Rodada " + i + "\n");
                Console.WriteLine("\nDado lançado...  (tecle)\n");
                Console.ReadKey();

                play1 = dados.Next(0, 7);
                play2 = dados.Next(0, 7);

                if (play1 > play2)
                {
                    Console.Write(jog1 + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(play1 + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(jog2 + ": " + play2);

                    Console.WriteLine("\n");    
                    Console.WriteLine(jog1 + " venceu a rodada " + i);

                    contPlay1++;
                }
                else if (play1 < play2)
                {
                    Console.Write(jog1 + ": " + play1 + "\n");
                    Console.Write(jog2 + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(play2 + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.WriteLine("\n");
                    Console.WriteLine(jog2 + " venceu a rodada " + i);

                    contPlay2++;
                }
                else if (play1 == play2)
                {
                    Console.Write(jog1 + ": " + play1 + "\n");
                    Console.Write(jog2 + ": " + play2);
                    
                    Console.WriteLine("\n");
                    Console.WriteLine("Esta rodada empatou");
                }
                i++;

                Console.WriteLine("\n\n(tecle)");
                Console.ReadKey();
                Console.Clear();
            }

            if (contPlay1 > contPlay2)
            {
                Console.Write("O vencedor é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(jog1);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (contPlay1 < contPlay2)
            {
                Console.Write("O vencedor é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(jog2);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (contPlay1 == contPlay2)
            {
                Console.WriteLine("A partida empatou!");
            }

            Console.ReadKey();
        }
    }
}
