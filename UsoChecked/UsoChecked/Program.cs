using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.MaxValue nos devuelve el valor maximo del primitivo int
            //int numero = int.MaxValue;
            //aqui se va a producir un error 
            //int resultado = numero + 20;
            //nos da un numero negativo, dado que se produjo un overflow
            //y para que no caiga el programa, el compilador lo hace de forma transparente
            //esto lo hace por rendimiento y en caso puntual, en las operaciones 
            //aritmeticas y por ende, da una respuesta erronea

            //para ello, utilizamos la expresion checked
            //el compilador, chequea muy rigurosamente lo que se encuentra dentro
            //para que no lo pase por alto y ahi es cuando lanza la excepcion y cae el programa.
            //ESTO NO ES COMUN NI CONOCIDO
            /*checked
            {
            int numero = int.MaxValue;
            int resultado = numero + 20;
            Console.WriteLine(resultado);
            }
            */

            /*
             * el entorno de visualstudio tiene una opcion para que el checked
             * no lo tengamos que programar nosotros y el compilador haga un chequeo
             * riguroso con las operaciones aritmeticas. Por defecto el compilador lo 
             * deja pasar por alto, pero si queremos que no lo ignore, hacemos lo siguiente:
             * 
             * 1)Pulsamos click derecho sobre nuestro proyecto en el explorador de soluciones,
             * elegimos en el menu "propiedades"
             * 2)Luego nos vamos a Compilacion, y pulsamos en el boton de avanzada
             * 3)Buscamos la casilla donde indica: "Comprobar el desbordamiento y subdesbordamiento aritmetico"
             * POR DEFECTO ESTA DESACTIVADO
             * 4)Tildamos la casilla y guardamos los cambios... con esto seria como si hubiesemos
             * programado el checked, y lanza la excepcion.
             * **/
            int numero = int.MaxValue;
            //aqui es donde se genera la excepcion y podemos abreviar el checked de la siguiente forma
            //para que nos lance la excepcion. SOLO FUNCIONA CON INT Y LONG
            //con double o float, NO VA A FUNCIONAR
            int resultado = checked( numero + 20);
            //si queremos que obvie el chequeo lo hacemos de esta forma
            //int resultado = unchecked (numero + 20);
            Console.WriteLine(resultado);

        }
    }
}
