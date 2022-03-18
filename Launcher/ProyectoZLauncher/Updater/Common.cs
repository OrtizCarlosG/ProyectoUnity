using Cyclic.Redundancy.Check;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProyectoZLauncher.Objetos;

namespace ProyectoZLauncher.Updater
{
    class Common
    {
        public static void ChangeStatus(string Key, params string[] Arguments)
        {
            //Globals.pForm.statusLbl.Text = Texts.GetText(Key, Arguments);
        }

        public static void UpdateCompleteProgress(long Value)
        {
            if (Value < 0 || Value > 100)
                return;
            Globals.getGameForm().disableStart();
            Globals.getGameForm().completeProgress.Value = Convert.ToInt32(Value);
            Globals.getGameForm().statusLbl.Text = Texts.GetText("COMPLETEPROGRESS", Value);
            if (Convert.ToInt32(Value) >= 100)
            {
                Globals.getGameForm().enableStart();
                Globals.getGameForm().statusLbl.Text = "Descarga finalizada, buen juego!";
            }
        }

        public static void UpdateCurrentProgress(long Value, double Speed)
        {
            if (Value < 0 || Value > 100)
                return;
       
            Globals.getGameForm().currentProgress.Value = Convert.ToInt32(Value);
            Globals.getGameForm().currentProgressText.Text = Texts.GetText("CURRENTPROGRESS", Value, Speed.ToString("0.00"));
        }

        public static string GetHash(string Name)
        {
            if (Name == string.Empty)
                return string.Empty;

            CRC crc = new CRC();

            string Hash = string.Empty;

            using (FileStream fileStream = File.Open(Name, FileMode.Open))
            {
                foreach (byte b in crc.ComputeHash(fileStream))
                {
                    Hash += b.ToString("x2").ToLower();
                }
            }

            return Hash;
        }

        public static void EnableStart()
        {
           // Globals.pForm.enableStart();
        }

       public static bool IsGameRunning()
       {
           return Process.GetProcessesByName(Globals.BinaryName).FirstOrDefault(p => p.MainModule.FileName.StartsWith("")) != default(Process);
       }

        public static void StartGame()
        {
            var process = new Process
            {
                StartInfo =
              {
                  FileName = Globals.BinaryName,
                  Arguments = "-ClientKey="+ Globals._ClientKey +""
              }
            };
            process.Start();
            //Cerramos la aplicacion
            Environment.Exit(0);
        }
    }
}
