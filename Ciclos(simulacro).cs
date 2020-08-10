using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace Ciclos__simulacro_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado1 = 0, dado2 = 0, total = 0, turnos = 0, par = 0, suma = 0, contador = 0;
            Random aleatorio = new Random();
            string continuar = "s";

            while (continuar == "s")
            {
                dado1 = int.Parse(Console.ReadLine());
                dado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("El dado uno = " + dado1);
                Console.WriteLine("El dado dos = " + dado2);
                suma = dado1 + dado2;
                total += suma;
                Console.WriteLine("El total es = " + total);
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("perdiste");
                    total = 0;
                    break;
                }
                if (dado1 == dado2)
                {
                    par += 1;
                    Console.WriteLine("Llevas " + par + "par");
                }
                else
                {
                    par = 0;
                }
                if (suma > 6)
                {
                    contador += 1;
                }
                if (total >= 100 || par == 3)
                {

                    Console.WriteLine("Ganaste genial");
                    Console.WriteLine("Tu total es = " + total);
                    break;
                }
                turnos += 1;
                Console.WriteLine("Quieres seguir jugando? (s/n):");
                continuar = Console.ReadLine();

            }

            double porcentaje = ((double)contador / turnos) * 100;
            Console.WriteLine("El turno es: " + turnos);
            Console.WriteLine("El contador es: " + contador);
            Console.WriteLine("El porcentaje es: " + porcentaje + "%");
            Console.WriteLine("Gracias por haber jugado: ");
        }
    }
}
