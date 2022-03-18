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
using ProyectoZLauncher.Updater;
using ProyectoZLauncher.Connections;
using System.Threading;

namespace ProyectoZLauncher
{
    public partial class GameForm : Form
    {

        private static Thread mainThread;
        public GameForm()
        {
            InitializeComponent();
            Globals.setGameForm(this);
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            mainThread = new Thread(new ThreadStart(MainThread));
            mainThread.Start();
            //Networking.CheckNetwork();
            ClientSend.getProfileImage();
            ClientSend.StartAccount();
        }

        private static void MainThread()
        {
            DateTime _nextLoop = DateTime.Now;

            while (true)
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

        public void disableStart()
        {
            playBtn.Enabled = false;
        }

        public void enableStart()
        {
            playBtn.Enabled = true;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Common.StartGame();
        }

        private void profileImage_Click(object sender, EventArgs e)
        {

        }

        private void proyectoZLabel4_Click(object sender, EventArgs e)
        {
           
        }

        public void showOpenFileDialog()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(of.FileName);
                Bitmap b = new Bitmap(img);
                ClientSend.changeProfileImage(imageConverter.convertImageToString(imageConverter.resizeImage(b, new Size(75, 75))));
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(showOpenFileDialog));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
    }
}
