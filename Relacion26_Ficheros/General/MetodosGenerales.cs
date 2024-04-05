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



        public static byte CaptarByte(byte NumOpciones)
        {
            string aux = "";
            byte option = 0;


            aux = Console.ReadLine();
            option = Convert.ToByte(aux);

            if (option >= NumOpciones) throw new OverflowException();

            return option;
        }

        // MÉTODOS FILE

    }
}
