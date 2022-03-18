using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoZLauncher.Objetos;
using ProyectoZLauncher.Connections;
using System.Threading;
namespace ProyectoZLauncher
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Globals.setMenu(this);
        }

        private static bool isConnected = false;
        private static Thread mainThread;

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Client.ConnectToServer();
            isConnected = true;
             mainThread = new Thread(new ThreadStart(MainThread));
             mainThread.Start();
            //Globals.startTimer();
            proyectoZSlider1.AddImage(Properties.Resources.Foto_1, "Airdrop test");
            proyectoZSlider1.AddImage(Properties.Resources.Foto_5, "Polygon apocalypse game");
            proyectoZSlider1.AddImage(Properties.Resources.Foto_6, "Bienvenido a proyecto z");
            proyectoZSlider1.AddImage(Properties.Resources.Foto_8, "Zombie boss test");
            proyectoZSlider1.AddImage(Properties.Resources.Foto_9, "Zombie boss test");
            proyectoZSlider1.AddImage(Properties.Resources.Foto_10, "Zombie boss test");
            openFormInPanel(new LoginForm());
        }

        private static void MainThread()
        {
            DateTime _nextLoop = DateTime.Now;

            while (isConnected)
            {
                while (_nextLoop < DateTime.Now)
                {
                    // If the time for the next loop is in the past, aka it's time to execute another tick
                    ThreadManager.UpdateMain();

                    _nextLoop = _nextLoop.AddMilliseconds(1000f / 16f); // Calculate at what point in time the next tick should be executed

                    if (_nextLoop > DateTime.Now)
                    {
                        // If the execution time for the next tick is in the future, aka the server is NOT running behind
                        Thread.Sleep(_nextLoop - DateTime.Now); // Let the thread sleep until it's needed again.
                    }
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            closeWindow();
        }

        public void hideWindow()
        {
            Invoke(new Action(() => this.Hide()));
        }

        public void closeWindow()
        {
            Invoke(new Action(() => this.Close()));
        }

        public void openFormInPanel(Form form)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.AutoScroll = true;
            this.panel2.Controls.Add(form);
            form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Client.onApplicationStop();
            mainThread.Abort();
            this.Hide();
            this.Close();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(100, 255, 0, 0);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Transparent;
        }

        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            minBtn.BackColor = Color.FromArgb(125, 201, 201, 201);
        }

        private void minBtn_MouseLeave(object sender, EventArgs e)
        {
            minBtn.BackColor = Color.Transparent;
        }
    }
}
