using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] edades;
            edades = new int[4];
            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;
            */
            //int[] edades = new int[4] { 15, 27, 19, 80 };
            int[] edades = { 15, 27, 19, 80 };
            Console.WriteLine(edades[1]);
            /**
             * Array Implicito
             * ----------------
             * almacena datos sin especificar nada ya que el compilador
             * determina el tipo de datos.OJO deben ser del mismo tipo
             * **/

            //Array Implicito
            //el compilador lo asigna como String
            var datos = new[] { "Julio", "Cesar", "Venezuela"};
            //el compilador lo asigna como double
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };

            //Array de objeto
            Empleados[] arrayEmpleado = new Empleados[2];
            arrayEmpleado[0] = new Empleados("Julio", 37);

            Empleados ana = new Empleados("Cesar", 13);
            arrayEmpleado[1] = ana;

            //Array anonimo DEBE SER IGUAL EL TIPO Y LOS NOMBRE DE CAMPOS
            var personas = new[]
            {
                new {nombre="Adrianno",edad=8},
                new {nombre="Maria",edad=30},
                new {nombre="Diana",edad=35}
            };

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            
        }
    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        String nombre;
        int edad;
    }
}
