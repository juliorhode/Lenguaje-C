using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para usar los metodos sin necesidad de colocar la clase antes del metodo
//using static System.Math;
//using static System.Console;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

                            //          clase anonima        //
            var miVarible = new { Nombre = "Julio", edad = 19 };
            Console.WriteLine(miVarible.Nombre + " " + miVarible.edad);
            var miOtraVariable = new { Nombre = "Cesar", edad = 13 };
            miVarible = miOtraVariable;
            Console.WriteLine(miVarible.Nombre + " " + miVarible.edad);
            /************************************************
             * CLASES ANONIMAS
             * ----------------
             * Solo pueden contener campos publicos
             * Todos los campos deben estar iniciados
             * Los campos no pueden ser static
             * No se pueden definir metodos
             * 
             ************************************************/

        }

        static void realizarTarea()
        {
            //Estamos intanciando y llamando al constructor por defecto
            Punto origen = new Punto();
            
            //Estamos intanciando y llamando al constructor sobrecargado
            Punto destino = new Punto(128, 80);
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Punto ortoPunto = new Punto();

            //Vamos a obtener el valor de contador
            //Como es static, se debe acceder desde la clase y no instanciandola
            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorObjetos()}");

            //para acceder a una constante que por defecto es static, debe ser desde la clase
            //ESTA NO PUEDE SER MODIFICADA
            Console.WriteLine($"El valor de la constante es: {Punto.constantePrueba}");
            //TODO: Por aqui seguimos
        }
    }  
}
