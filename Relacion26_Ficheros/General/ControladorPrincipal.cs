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

                    opcion = (MenuOpciones)MetodosGenerales.captarByte();
                
                    switch (opcion)
                    {
                        case MenuOpciones.Salir:
                            break;
                        case MenuOpciones.Añadir:

                            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");

                            File.Create($"{DIRECTORIO_ORIGEN}{Fichero}");
                            UIPrincipal.UIPrincipal.Pausa();

                            break;
                        case MenuOpciones.Copiar:


                            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
                            FicheroNuevo = MetodosGenerales.CaptarCadena("nombre del nuevo fichero");

                            File.Copy($"{DIRECTORIO_ORIGEN}{Fichero}", $"{DIRECTORIO_DESTINO}{FicheroNuevo}");
                            UIPrincipal.UIPrincipal.Pausa();

                            break;
                        case MenuOpciones.Mover:
                            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");
                            FicheroNuevo = MetodosGenerales.CaptarCadena("nombre del nuevo fichero");

                            File.Move($"{DIRECTORIO_ORIGEN}{Fichero}", $"{DIRECTORIO_DESTINO}{FicheroNuevo}");
                            UIPrincipal.UIPrincipal.Pausa();

                            break;
                        case MenuOpciones.Eliminar:
                            Fichero = MetodosGenerales.CaptarCadena("nombre del fichero");

                            File.Delete($"{DIRECTORIO_DESTINO}{Fichero}");
                            UIPrincipal.UIPrincipal.Pausa();

                            break;

                        case MenuOpciones.Consultar:

                            UIPrincipal.UIPrincipal.Pausa();

                            // Asignar el direcctorio completo a un ARRAY usando getFiles 
                            string[] archivos = Directory.GetFiles(DIRECTORIO_ORIGEN);

                            string[] archivosD = Directory.GetFiles(DIRECTORIO_DESTINO); ;

                            // Mostrar por medio de un foreach el nombre del archivo usando GetFileName
                            General.MetodosGenerales.MostrarDirectorio(archivos, "ORIGEN");

                            General.MetodosGenerales.MostrarDirectorio(archivosD, "DESTINO");


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
            } while (!esValido || opcion != 0);
        }

    }
}
