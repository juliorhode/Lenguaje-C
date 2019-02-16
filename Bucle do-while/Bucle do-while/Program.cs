using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 10);
            int miNumero;
            int intentos = 0;
            Console.WriteLine($"El numero aleatorio es {numeroAleatorio}");
            do
            {
                intentos++;
                Console.WriteLine("Introduce un nuevo numero entre 0 y 10");
                miNumero = Int32.Parse(Console.ReadLine());
                if (miNumero < numeroAleatorio)
                {
                    Console.WriteLine("El numero debe ser mas alto");
                }
                if (miNumero > numeroAleatorio)
                {
                    Console.WriteLine("El numero debe ser mas bajo");
                }
            }while (numeroAleatorio != miNumero);

            Console.WriteLine($"Correcto!!! Haz necesitado {intentos} intentos");
            Console.WriteLine("A partir de esta linea de codigo el programa continuaria");
        }
    }
}
