using System;
using System.Collections.Generic;

namespace ProyectoZLauncher.Updater
{
    class Texts
    {
        private static Dictionary<string, string> Text = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "No es posible conectarse al servidor: \n{0}"},
            {"MISSINGBINARY",                   "El juego no puede iniciar {0} esta faltando."},
            {"CANNOTSTART",                     "No es posible iniciar el juego!"},
            {"NONETWORK",                       "No es posible conectarse al servidor."},
            {"CONNECTING",                      "Conectandose al servidor.."},
            {"LISTDOWNLOAD",                    "Descargando informacion del servidor..."},
            {"CHECKFILE",                       "{0} Verificando..."},
            {"DOWNLOADFILE",                    "{0} Descargando... {1}/ {2}"},
            {"COMPLETEPROGRESS",                "Descargando... {0}%"},
            {"CURRENTPROGRESS",                 "Descargando Archivos: {0}%  |  {1} kb/s"},
            {"CHECKCOMPLETE",                   "Los archivos estan actualizados, Buen juego!."},
            {"DOWNLOADCOMPLETE",                "Los archivos estan actualizados, Buen juego!."},
            {"DOWNLOADSPEED",                   "{0} kb/s"}
        };

        public static string GetText(string Key, params object[] Arguments)
        {
            foreach (var currentItem in Text)
            {
                if(currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments); 
                }
            }

            return null;
        }
    }
}
