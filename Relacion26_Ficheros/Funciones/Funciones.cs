using Relacion26_Ficheros.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion26_Ficheros.Funciones
{
    public static class Funciones
    {
        const string EX_ORIGEN = ".txt";
        const string EX_DESTINO = ".bak";

        public static void Añadir(string DIRECTORIO_ORIGEN)
        {
            string Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
            File.Create($"{DIRECTORIO_ORIGEN}{Fichero}{EX_ORIGEN}");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void Copiar(string DIRECTORIO_ORIGEN, string DIRECTORIO_DESTINO, out string Fichero, out string FicheroNuevo)
        {
            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
            FicheroNuevo = MetodosGenerales.CaptarCadena("nombre del nuevo fichero");

            File.Copy($"{DIRECTORIO_ORIGEN}{Fichero}{EX_ORIGEN}", $"{DIRECTORIO_DESTINO}{FicheroNuevo}{EX_DESTINO}");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void Mover(string DIRECTORIO_ORIGEN, string DIRECTORIO_DESTINO, out string Fichero)
        {
            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");

            File.Move($"{DIRECTORIO_ORIGEN}{Fichero}{EX_ORIGEN}", $"{DIRECTORIO_DESTINO}{Fichero}{EX_DESTINO}");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void Eliminar(string DIRECTORIO_DESTINO)
        {
            string Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
            File.Delete($"{DIRECTORIO_DESTINO}{Fichero}");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void MostrarDirectorio(string text, string origen)
        {

            // Asignar el direcctorio completo a un ARRAY usando getFiles 
            string[] archivos = Directory.GetFiles(origen);

            Console.WriteLine($"\nDIRECTORIO {text}\n");

            foreach (string cadena in archivos)
            {
                Console.WriteLine(Path.GetFileName($"\t{cadena}\t"));
                Console.WriteLine("--------------------");

            }
        }


    }
}
