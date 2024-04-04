using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion26_Ficheros.General
{
    public enum MenuOpciones: byte { Salir, Añadir, Copiar, Mover, Eliminar, Consultar } // TODOO: SI
    public static class MetodosGenerales
    {
        public static void MostrarError(string error)
        {
            Console.WriteLine(error);
            Console.Write("\nPulse Enter para Continuar...");
            Console.ReadLine();
            Console.Clear();

        }


        public static string CaptarCadena(string text)
        {
            string cadena = "";

            Console.Write($"Escriba {text}: ");
            cadena = Console.ReadLine();

            return cadena;
        }

        public static byte CaptarByte()
        {
            string aux = "";
            byte opcion = 0;

            aux = Console.ReadLine();
            opcion = Convert.ToByte(aux);

            return opcion;

        }

        public static void MostrarDirectorio(string[] archivos, string text)
        {
            Console.WriteLine($"\nDIRECTORIO {text}\n");

            foreach (string cadena in archivos)
            {
                Console.WriteLine(Path.GetFileName($"\t{cadena}\t"));
                Console.WriteLine("--------------------");

            }
        }

        public static byte captarByte()
        {
            string aux = "";
            byte option = 0;

            aux = Console.ReadLine();
            option = Convert.ToByte(aux);

            return option;
        }


    }
}
