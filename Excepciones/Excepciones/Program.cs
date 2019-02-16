using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
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
                try
                {
                miNumero = Int32.Parse(Console.ReadLine());

                }
                /*****************************************************************
                 * Lo recomendado es ser lo mas preciso en las excepciones y no
                 * utilizar la excepcion generica.
                 * 
                 * Al usar muchos catch pueden haber conflictos.Hay que tener
                 * cuidado ya que si se coloca una excepcion general y luego
                 * una puntual, dara un error.
                 * 
                 * Se debe colocar de lo mas puntual a lo mas generico
                 * 
                 *****************************************************************/
                /*
                catch (Exception e)
                {
                    Console.WriteLine("Haz introducido un valor valido. Se toma como numero el 0");
                    Console.WriteLine(e.Message);
                    miNumero = 0;
                }
                */

                //aqui se le indica que capture todas las excepciones, cuando el tipo
                //de excepcion sea diferente de FormatException
                //.GetType() nos indica el tipo de excepcion que se ha lanzado
                //
                catch (Exception e) when (e.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error. Se toma como numero el 0");
                    //Console.WriteLine(e.Message);
                    miNumero = 0;
                }
                //cuando GetType() sea igual a FormatException, entra en el siguiente catch
                catch (FormatException e)
                {
                    Console.WriteLine("Haz introducido texto.");
                    //Console.WriteLine(e.Message);
                    miNumero = 0;
                }

                if (miNumero < numeroAleatorio)
                {
                    Console.WriteLine("El numero debe ser mas alto");
                }
                if (miNumero > numeroAleatorio)
                {
                    Console.WriteLine("El numero debe ser mas bajo");
                }
            } while (numeroAleatorio != miNumero);

            Console.WriteLine($"Correcto!!! Haz necesitado {intentos} intentos");
            Console.WriteLine("A partir de esta linea de codigo el programa continuaria");

        }
    }
}
