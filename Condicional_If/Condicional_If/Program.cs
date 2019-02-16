using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    class Program
    {
        /********************************
         *  !   -- esto invierte el valor
         *  ==  -- igual que
         *  !=  -- diferente que
         *  <   -- menor que
         *  >   -- mayor que
         *  <=  -- menor igual que
         *  >=  -- mayor igual que
         ********************************
         *  &&  -- Y logico
         *  ||  -- O logico
         ********************************/
         
        static void Main(string[] args)
        {
            bool haceFrio;

            haceFrio = false;

            Console.WriteLine("Hace frio: " + haceFrio);
            Console.WriteLine("Hace frio: " + !haceFrio);

            Console.WriteLine("Introduce tu edad");
            //Int32 pasa a entero de 32bits el string 
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 30)
            {
                Console.WriteLine("Eres un joven");
            }
            else if (edad < 60)
            {
                Console.WriteLine("Eres un maduro");
            }
            else
            {
                Console.WriteLine("Debes cuidarte");
            }

            if (edad<18)
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("¿Tienes carnet?");
                string carnet = Console.ReadLine();
                //esto compara las cadenas y adicionalmente con true
                //se le indica que ignore si es mayusculas o minusculas
                int compara = String.Compare(carnet, "si", true);
                if (compara == 0)
                {
                    Console.WriteLine("Puedes conducir vehiculos");
                }
                else
                {
                    Console.WriteLine("No puedes conducir vehiculos");
                }

            }



            Console.WriteLine("Introduce la primera nota");
            int nota1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            int nota2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            int nota3 = Int32.Parse(Console.ReadLine());

            if (nota1>=5 || nota2>=5 || nota3>=5)
            {
                float resultado = (nota1 + nota2 + nota3)/3;
                Console.WriteLine("La nota media es " + resultado);
            }
            else
            {
                Console.WriteLine("Nos vemos en reparacion");
            }

        }
    }
}
