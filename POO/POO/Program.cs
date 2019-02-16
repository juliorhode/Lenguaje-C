using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //creacion de objeto de tipo circulo. Variable de tipo objeto
            miCirculo = new Circulo(); //iniciacion de variable objeto de tipo circulo. Instanciar una clase

            Console.WriteLine(miCirculo.CalculaArea(5));

            Circulo miCirculo2 = new Circulo();
            Console.WriteLine(miCirculo2.CalculaArea(9));

            Console.WriteLine();

            Console.WriteLine("Conversor Euro / Dolar");
            ConversorEuroDolar obj = new ConversorEuroDolar();
            Console.WriteLine(obj.convierte(50));
            obj.cambiaValorEuro(-1.45);
            Console.WriteLine(obj.convierte(50));
            
        }
    }

    class Circulo
    {
        //variable constante de tipo primitivo
        //No se puede acceder a esta constante ya que no es necesaria, porque el ambito
        //es solo de su clase. Esta esta encapsulada y es solo accesible desde su pripoa clase

        //Por lo general las variables y constantes, deben ser encapsuladas 
        private const double pi = 3.1416; //Propiedad de la clase circulo. (campo de clase)

        //Se puede acceder por la palabra reservada public
        public double CalculaArea(int radio) //metodo de clase circulo. (que puede hacer los objetos de tipo circulo)
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor<0)
            {
                euro = 1.253;
            }
            else
            {
                euro = nuevoValor;

            }
        }
    }
}
