using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoZServer.ServerConnections;
using ProyectoZServer.SQL;
using System.Threading;
using ProyectoZServer.Objetos;

namespace ProyectoZServer
{
    public partial class Form1 : Form
    {

        private LeerIni inis;
        public Form1()
        {
            InitializeComponent();
            Globals.setForm(this);
        }
        private static bool isRunning = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.inis = new LeerIni("ProyectoZ.ini");
            Globals.setSQLData(this.inis.Read("Server", "SQL").Trim(), this.inis.Read("User", "SQL").Trim(), this.inis.Read("Password", "SQL").Trim(), this.inis.Read("Database", "SQL").Trim());
            Globals.getSQL().SQL_Connect(this.inis.Read("Server", "SQL").Trim(), this.inis.Read("User", "SQL").Trim(), this.inis.Read("Password", "SQL").Trim(), this.inis.Read("Database", "SQL").Trim());
            isRunning = true;
            Thread mainThread = new Thread(new ThreadStart(MainThread));
            mainThread.Start();
            Server.Start(50, 26951);
        }
        private static void MainThread()
        {
            Console.WriteLine($"Main thread started. Running at {30f} ticks per second.");
            DateTime _nextLoop = DateTime.Now;

            while (isRunning)
            {
                while (_nextLoop < DateTime.Now)
                {
                    // If the time for the next loop is in the past, aka it's time to execute another tick
                    ThreadManager.UpdateMain();

                    _nextLoop = _nextLoop.AddMilliseconds(1000f/30f); // Calculate at what point in time the next tick should be executed

                    if (_nextLoop > DateTime.Now)
                    {
                        // If the execution time for the next tick is in the future, aka the server is NOT running behind
                        Thread.Sleep(_nextLoop - DateTime.Now); // Let the thread sleep until it's needed again.
                    }
                }
            }
        }
         public void addToLog(string text)
        {
            Invoke(new Action(() => richTextBox1.Text += text + "\n"));
        }


    }
}
