﻿using System;
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


        public static void MostrarDirectorio(string[] archivos, string text)
        {
            Console.WriteLine($"\nDIRECTORIO {text}\n");

            foreach (string cadena in archivos)
            {
                Console.WriteLine(Path.GetFileName($"\t{cadena}\t"));
                Console.WriteLine("--------------------");

            }
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
        public static void Añadir(string DIRECTORIO_ORIGEN)
        {
            string Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
            File.Create($"{DIRECTORIO_ORIGEN}{Fichero}.txt");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void Copiar(string DIRECTORIO_ORIGEN, string DIRECTORIO_DESTINO, out string Fichero, out string FicheroNuevo)
        {
            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
            FicheroNuevo = MetodosGenerales.CaptarCadena("nombre del nuevo fichero");

            File.Copy($"{DIRECTORIO_ORIGEN}{Fichero}.txt", $"{DIRECTORIO_DESTINO}{FicheroNuevo}.bak");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void Mover(string DIRECTORIO_ORIGEN, string DIRECTORIO_DESTINO, out string Fichero)
        {
            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");

            File.Move($"{DIRECTORIO_ORIGEN}{Fichero}.txt", $"{DIRECTORIO_DESTINO}{Fichero}.bak");
            UIPrincipal.UIPrincipal.Pausa();
        }

        public static void Eliminar(string DIRECTORIO_DESTINO)
        {
            string Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
            File.Delete($"{DIRECTORIO_DESTINO}{Fichero}");
            UIPrincipal.UIPrincipal.Pausa();
        }

    }
}
