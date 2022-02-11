using System;

namespace Ex01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort coordX = 0;
            ushort coordY = 0;
           
            Console.Write("Digite coordenada X: ");
            coordX = ushort.Parse(Console.ReadLine());

            Console.Write("Digite coordenada Y: ");
            coordY = ushort.Parse(Console.ReadLine());

            Console.WriteLine();
            
            for (ushort i = 0; i < coordY; i++)
            {
                ushort j;
                for (j = 0; j < coordX; j++)
                {
                    Console.Write("* ");
                }
                if (j >= coordX)
                {
                    Console.WriteLine();
                }
                if (i >= coordY)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
