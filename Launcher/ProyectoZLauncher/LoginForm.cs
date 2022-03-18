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
namespace ProyectoZLauncher
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Globals.setLoginForm(this);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ClientSend.LoginPacket(userTxt.Text, passTxt.Text);
        }

        private void registerLbl_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Globals.getMenu().openFormInPanel(new RegisterForm());
        }

        private void userTxt_Enter(object sender, EventArgs e)
        {
            if (userTxt.Text.Equals("Ingrese aqui su usuario"))
            {
                userTxt.Text = "";
                userTxt.ForeColor = Color.White;
            }
        }

        private void userTxt_Leave(object sender, EventArgs e)
        {
            if (userTxt.Text.Equals("Ingrese aqui su usuario") || string.IsNullOrEmpty(userTxt.Text))
            {
                userTxt.Text = "Ingrese aqui su usuario";
                userTxt.ForeColor = Color.DarkGray;
            }
        }

        private void passTxt_Enter(object sender, EventArgs e)
        {
            if (passTxt.Text.Equals("Ingrese aqui su contraseña"))
            {
                passTxt.Text = "";
                passTxt.ForeColor = Color.White;
            }
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            if (passTxt.Text.Equals("Ingrese aqui su contraseña") || string.IsNullOrEmpty(passTxt.Text))
            {
                passTxt.Text = "Ingrese aqui su contraseña";
                passTxt.ForeColor = Color.DarkGray;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            errorlbl.Text = "";
        }

        public void setErrorMessage(string _message)
        {
            Invoke(new Action(() => errorlbl.Text = _message));
        }
    }
}
