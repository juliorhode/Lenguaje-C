using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajePantalla();
            Console.WriteLine("Mensaje desde el main");
            sumaNumeros(7, 9);

            int resultado = sumaNuevos(9, 9);
            //Console.WriteLine("Este valor es retornado " + resultado);
            Console.WriteLine($"Este valor es retornado {resultado}");

            //llamada de sobrecarga de metodo
            Console.WriteLine($"Llamada de sobrecarga {suma(7.2, 5.5)}");

            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;

            //llamada al metodo que el tercer parametro es opcional
            Console.WriteLine("Este es el metodo de tercer parametro opcional " + suma(valor1, valor2));
            Console.WriteLine("Ahora le pasamos el tercer parametro opcional " + suma(valor1, valor2, valor3));
        }


        static void mensajePantalla() 
        {
            Console.WriteLine("Mensaje del metodo en pantalla");
            
        }

        static void sumaNumeros(int num1, int num2)
        {
            //Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            Console.WriteLine($"La suma de los numeros con void es:{num1 + num2}");
        }

        /*
        static int sumaNuevos(int num1, int num2)
        {
            return num1 + num2;
        }
        */
        // => con esto se puede cambiar por el return cuando es pequeño el codigo
        static int sumaNuevos(int num1, int num2) => num1 + num2;

        void primerMetodo()
        {
            //La variable tiene un ambito local
            //int numero1 = 5;
            //int numero2 = 7;
            Console.WriteLine(numero1 + numero2);
            

        }
        void segundoMetodo()
        {
            Console.WriteLine(numero1 + numero2);
        }

        //Sobrecarga de metodos
        static int suma(int operador1, int operador2) => operador1 + operador2;
        static double suma(double operador1, double operador2) => operador1 + operador2;
        
        //En este metodo el tercer parametro es opcional
        /*********************************************************************
         * los parametros opcionales tienen que ir primero los obligatorios
         * y por ultimo la cantidad de parametros opcionales que se requieram
         ********************************************************************/
        static double suma(int operador1, double operador2,double operador3=0) => operador1 + operador2 + operador3;

        static int suma(int operador1, int operador2, int operador3) => operador1 + operador2 + operador3;
        static int suma(int operador1, int operador2, int operador3, int operador4) => operador1 + operador2 + operador3 + operador4;


        //La variable tiene un ambito de clase
        int numero1 = 5;//campo de clase
        int numero2 = 7;//campo de clase
    }

}
