using System;

namespace Ex04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] media =  new int[5];
            int x = 0 ;
            int i;
            int pos = 0;
            int neg = 0;


            
            for (i = 0; i < media.Length; i++)
            {
                Console.Write("Entre com o valor " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                media[i] = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            foreach (int n in media)
            {
                x += n;
                if (n % 2 == 0)
                {
                    pos++;
                }
                else if (n % 2 != 0)
                {
                    neg++;
                }
            }

            int resultado = x/i;

            Console.WriteLine("\nA média é: " + resultado + "\nA quantidade de positivos é: " + pos + "\nA quantidade de negativos é: " + neg);
            Console.ReadKey();
        }
    }
}
