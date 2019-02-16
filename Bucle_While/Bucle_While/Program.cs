using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * permite repetir codigo de forma rapida y sencilla
             * ahorra tiempo a la hora de programar
             * permite trabajar con grandes volumenes de datos
             * permite trabajar con Arrays
             * 
             * Este bucle es indeterminado.. quiere decir, que no se 
             * sabe cuantas veces ejecutara el codigo
             * 
             * En los bucles indeterminados son los while y los do-while
             * 
             * Los bucles determinados son los que se repiten tantas veces
             * como las que conocemos
             * 
             * Los bucles determinados son los for
             * */

            Console.WriteLine("Deseas entrar en el bucle while? 'si'/'no'");
            string respuesta = Console.ReadLine();
            while (respuesta != "no")
            {
                Console.WriteLine("Estas dentro del while");
                Console.WriteLine("Introduce tu nombre por favor");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Saldras del bucle {nombre} cuando respondas 'no'");
                Console.WriteLine("Deseas volver a repetir");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Haz salido del bucle while");

            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 10);
            Console.WriteLine($"El numero aleatorio es {numeroAleatorio}");
            int miNumero = 11;
            int intentos = 0;
            while (numeroAleatorio != miNumero)
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
            }
            Console.WriteLine($"Correcto!!! Haz necesitado {intentos} intentos");
            Console.WriteLine($"N° intentos {intentos}");
        }
    }
}
