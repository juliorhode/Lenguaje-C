using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class Punto
    {
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            //Al instanciar un objeto, la variable se incrementara
            contadorObjetos++;
            Console.WriteLine("Este es el constructor por defecto sin parametros");
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            //Al instanciar un objeto, la variable se incrementara
            contadorObjetos++;
            //$ se utiliza para imprimir variables en consola
            Console.WriteLine($" Coordenada x: {x} \n Coordenada y: {y}");
        }
        //recibe parametro de tipo objeto
        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            //Teorema de Pitagoras
            //el cuadrado de la hipotenusa es igual a la suma de los cuadrados de los catetos
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
        //public static int ContadorObjetos()
        //{
        //    return contadorObjetos;
        //}
        
        public static int ContadorObjetos() => contadorObjetos;
        /*******************/
        /* CAMPOS DE CLASE */
        /*******************/
        private int x, y;
        //Creacion de variable estatica
        private static int contadorObjetos = 0;

        public const int constantePrueba = 7;
    }
}
