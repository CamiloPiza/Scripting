using System;
using System.Xml.Schema;

namespace Dado_12_Caras
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random()
            int dado = 0, contador12 = 0, contadordeturnos = 0, total = 0;
            string tirar = "s";

            while (tirar == "s")
            {

                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                Console.WriteLine("Total: " + total);
                contadordeturnos++;
                Console.WriteLine("Turnos" + contadordeturnos);
                if (contadordeturnos < 3 && dado % 2 != 0) total += dado;
                if (contadordeturnos < 3 && dado % 2 != 0)
                {
                    Console.WriteLine("Perdistes");
                    break;
                }
                if (dado == 12)
                {
                    contador12++;
                }
                else if (dado!=12&&dado!=10)
                {
                    contador12 = 0;
                }
                if (contador12 == 1 && dado == 10) Console.WriteLine("Ganastes");
                if (total>100)
                {
                    Console.WriteLine("Ganastes");
                    break;
                }
                Console.WriteLine("¿Arrojar dados? (s/n)");
                tirar = Console.ReadLine();
            }
        }
    }
}
