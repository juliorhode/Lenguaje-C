using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCoche
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de la clase coche
            //dimos un estado inicial al objeto coche1
            Coche coche1 = new Coche();
            Console.WriteLine(coche1.getInfoCoche());


            Coche coche2 = new Coche(4500.25, 1200.35);
            Console.WriteLine(coche2.getInfoCoche());
            coche2.setExtras(true,"Cuero");
            Console.WriteLine(coche2.getExtras());

        }
    }

    //la palabra reservada partial, nos permite dividir nuestra clase en trozos
    //en este caso dividimos los contructores por un lado, y los metodos getters y setters mas
    //los campos de clase por otro lado
    partial class Coche
    {
        //Constructor es lo que determina el estao inicial
        public Coche()
        {
            //Establecemos el estado inicial 
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";

        }

        //sobrecarga de constructor (cuando una clase tiene mas de un constructor)
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
    }

    /******************************************************************/

    partial class Coche
    {
        //Son los que obtienen las propiedades a los objetos
        public String getInfoCoche()
        {
            // /n es para un salto de linea
            return "Informacion del coche \n" + "Ruedas: " + ruedas + "\n" + "Largo: " + largo + "\n" + "Ancho " + ancho + "\n" + "Tapiceria: " + tapiceria;
        }
        
        //Son los que establecen las propiedades a los objetos
        public void setExtras(bool climatizador, String tapiceria)
        {
            //Con el this, hacemos referencia al campo de clase
            this.climatizador    =  climatizador;
            this.tapiceria       =  tapiceria;
        }
        public String getExtras()
        {
            return "Extras del coche: \n" + "Tapicerica: " + tapiceria + "\n" + "Climatizador: " + climatizador;
        }

        //campos de clase
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;//tela o cuero
        /******Fin campos de clase******/
    }
}
