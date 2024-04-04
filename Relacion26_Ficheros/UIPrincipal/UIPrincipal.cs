using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion26_Ficheros.UIPrincipal
{
    public static class UIPrincipal
    {
        public static void UIP()
        {
            Console.WriteLine("0. Salír. ");
            Console.WriteLine("1. Crear. ");
            Console.WriteLine("2. Copiar. ");
            Console.WriteLine("3. Mover. ");
            Console.WriteLine("4. Borrar. ");
            Console.WriteLine("5. Consultar. ");


            Console.Write("Escriba una opción: ");
        }
        public static void Pausa()
        {
            Console.Write("\nPulse ENTER para Continuar...");
            Console.ReadLine();
            Console.Clear();
        }


    }
}
