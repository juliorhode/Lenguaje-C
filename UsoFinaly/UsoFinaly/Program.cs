using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFinaly
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos un objeto para lectura de archivo
            System.IO.StreamReader archivo = null;
            try
            {
                //variable para almacenar las lineas que tenga el fichero
                string linea;
                int contador = 0;
                //guardamos la ruta del archivo
                string path = @"D:\Proyectos\GitHub\C#\Lenguaje-C\EjemploFinaly.txt";
                //pasamos la ruta del archivo
                archivo = new System.IO.StreamReader(path);
                //recorremos mientras haya lineas de texto
                while ((linea=archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {
                //esto siempre se va a ejecutar
                //tenemos que cerrar el canal de lectura, ya que esto genera recursos
                //ESTO SE UTILIZA MUCHO CON CONEXIONES A BASE DE DATOS Y CON ARCHIVOS
                if (archivo!=null)
                {
                    archivo.Close();
                    Console.WriteLine("Conexion cerrada con el archivo");
                }
            }

        }
    }
}
