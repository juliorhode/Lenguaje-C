using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto imprime un mensaje en consola
            //Console.WriteLine("Hola a todos");

            int edad = 19;
            edad++;

            Console.WriteLine(edad);
            Console.WriteLine("Multiplicacion: " + 7 * 5);
            Console.WriteLine("Division: " + 5.0/2.0);
            Console.WriteLine("El resto de la division es: "+ 9%3);
            Console.WriteLine("Tu edad es: " + edad + " años");
            //Interpolacion de Strings... es el mismo resultado que el anterior
            Console.WriteLine($"Tu edad es: {edad} años");//Esto es mas eficiente
            Console.WriteLine($"Tu edad es: {++edad} años");//Aqui incrementamos la edad nuevamente
            Console.WriteLine($"Tu edad es: {--edad} años");//Aqui decrementamos la edad nuevamente

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            //Iniciar las variables en bloque
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 39;
            Console.WriteLine(edadPersona2);

            //aqui solo inicia a otraEdad2 mas no a la otra
            int otraEdad1, otraEdad2 = 27;
            //cuando la variable no esta inicializada, no se puede usar
            //Console.WriteLine(otraEdad1);

            //declaracion de variable implicita
            //las implicitas se tienen que iniciarlas ajuro, no luego
            var edadImplicita = 27;
            Console.WriteLine(edadImplicita);
            //esto no se puede hacer, ya que el compilador lo puso entero y no decimal
            //edadImplicita = 27.5;

            //conversion implicita a explicita
            double temperatura = 34.5;
            //casting o conversion explicita
            int temperaturaVenezuela;
            temperaturaVenezuela = (int)temperatura;//esto lo paso a entero y desecha los decimales
            Console.WriteLine(temperaturaVenezuela);

            //conversion implicita
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/implicit-numeric-conversions-table
            int habitantes = 100;
            long habitantesCiudad = habitantes;
            Console.WriteLine(habitantesCiudad);

            float peso = 5.78F;
            double pesoMaterial = peso;
            Console.WriteLine(pesoMaterial);

            /**** conversiones de tipo ****/
            Console.WriteLine("Introduce primer numero");
            //solicitar al usuario los datos
            //Console.ReadLine();ReadLine es tipo String

            //convertimos de string a numero
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + (num1+num2));

            //declaracion de constante
            const int VALOR = 5;
            const int VALOR1 = 7;
            Console.WriteLine("El valor de la constante es ", VALOR);
            Console.WriteLine("El valor de la constante es {0}",VALOR,VALOR1);
            Console.WriteLine("El valor de la constante es {1}", VALOR, VALOR1);

            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio");
            //pasamos de string a double
            double radio = double.Parse(Console.ReadLine());
            //double area = radio * radio * PI;
            double area = Math.Pow(radio, 2) * PI;
            //Console.WriteLine("El area del circulo es: " + area);
            Console.WriteLine($"El area del circulo es: {area}");
        }
    }
}
