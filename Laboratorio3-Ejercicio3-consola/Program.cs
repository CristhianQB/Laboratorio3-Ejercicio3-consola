using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Ejercicio3_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eres menor o mayo de edad");
            Console.WriteLine("(0)Mayor");
            Console.WriteLine("(1)Menor");
            string edad1Texto = Console.ReadLine();

            Console.WriteLine("Cual es su edad");
            int edad = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Cuántas adivinanzas acertó");
            string acertoTexto = Console.ReadLine();

            int edad1 = int.Parse(edad1Texto);
            int acerto = int.Parse(acertoTexto);

            switch (edad1)
            {
                case 0:
                    if (acerto < 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 30;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else if (edad >= 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 50;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;

                case 1:
                    if (acerto < 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 50;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    else if (edad >= 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 80;
                        Console.WriteLine("El total es de: " + total + " soles");
                    }
                    break;

            }
                Console.ReadKey();
        }
    }
}
