using Relacion26_Ficheros.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion26_Ficheros.General
{
    public static class ControladorPrincipal
    {

        public static void ControllerPrincipal()
        {

            // RECURSOS

            const string DIRECTORIO_ORIGEN = "c:\\Ficheros\\";
            const string DIRECTORIO_DESTINO = "c:\\OtrosFicheros\\";

          
            MenuOpciones opcion = 0;
            string Fichero = "";
            string FicheroNuevo = "";
            string error = "";
            bool esValido;


            do
            {
                UIPrincipal.UIPrincipal.UIP();

                esValido = true;
                try
                {
                    
                    opcion = (MenuOpciones)MetodosGenerales.CaptarByte((byte)Enum.GetValues<MenuOpciones>().Length);
                
                    switch (opcion)
                    {
                        case MenuOpciones.Salir:
                            break;
                        case MenuOpciones.Añadir:
                            Funciones.Funciones.Añadir(DIRECTORIO_ORIGEN);
                            break;
                        case MenuOpciones.Copiar:
                            Funciones.Funciones.Copiar(DIRECTORIO_ORIGEN, DIRECTORIO_DESTINO, out Fichero, out FicheroNuevo);
                            break;
                        case MenuOpciones.Mover:
                            Funciones.Funciones.Mover(DIRECTORIO_ORIGEN, DIRECTORIO_DESTINO, out Fichero);
                            break;
                        case MenuOpciones.Eliminar:
                            Funciones.Funciones.Eliminar(DIRECTORIO_DESTINO);
                            break;
                        case MenuOpciones.Consultar:
                            UIPrincipal.UIPrincipal.Pausa();



                            // Mostrar por medio de un foreach el nombre del archivo usando GetFileName
                            Funciones.Funciones.MostrarDirectorio("ORIGEN", DIRECTORIO_ORIGEN);
                            Funciones.Funciones.MostrarDirectorio("DESTINO", DIRECTORIO_DESTINO);
                            UIPrincipal.UIPrincipal.Pausa();
                            break;

                    }
                }
                catch (Exception Error)
                {
                    esValido = false;
                    error = Error.Message;
                }
                finally
                {
                    if (!esValido) MetodosGenerales.MostrarError(error);
                }
            } while (!esValido || opcion != MenuOpciones.Salir);
        }


    }
}
