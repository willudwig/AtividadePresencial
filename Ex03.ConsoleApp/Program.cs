using System;

namespace Ex03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaAtual = DateTime.Now.Hour; 
 
            Console.WriteLine("Hora atual: " + horaAtual);
            if (horaAtual > 0 && horaAtual > 23 && horaAtual < 6)
            {
                Console.WriteLine("\nBOA MADRUGADA!");
            }
            else if ((horaAtual >= 6 && horaAtual < 12))
            {
                Console.WriteLine("\nBOM DIA!");
            }
            else if ((horaAtual >= 12 && horaAtual <= 18))
            {
                Console.WriteLine("\nBOA TARDE!");
            }
            else
                Console.WriteLine("\nBOA NOITE");    


            Console.ReadKey();

            
        }
    }
}
