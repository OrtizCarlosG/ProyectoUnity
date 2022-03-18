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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Globals.getMenu().openFormInPanel(new LoginForm());
        }

        private void userTxt_Enter(object sender, EventArgs e)
        {
            if (userTxt.Text.Equals("Ingrese aqui su usuario"))
            {
                userTxt.Text = "";
                userTxt.ForeColor = Color.Black;
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
                passTxt.ForeColor = Color.Black;
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

        private void repassTxt_Enter(object sender, EventArgs e)
        {
            if (repassTxt.Text.Equals("Ingrese aqui su contraseña"))
            {
                repassTxt.Text = "";
                repassTxt.ForeColor = Color.Black;
            }
        }

        private void repassTxt_Leave(object sender, EventArgs e)
        {
            if (repassTxt.Text.Equals("Ingrese aqui su contraseña") || string.IsNullOrEmpty(repassTxt.Text))
            {
                repassTxt.Text = "Ingrese aqui su contraseña";
                repassTxt.ForeColor = Color.DarkGray;
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            if (emailTxt.Text.Equals("Ingrese aqui su email"))
            {
                emailTxt.Text = "";
                emailTxt.ForeColor = Color.Black;
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (emailTxt.Text.Equals("Ingrese aqui su email") || string.IsNullOrEmpty(emailTxt.Text))
            {
                emailTxt.Text = "Ingrese aqui su email";
                emailTxt.ForeColor = Color.DarkGray;
            }
        }

        private void captchaTxt_Enter(object sender, EventArgs e)
        {
            if (captchaTxt.Text.Equals("Ingrese aqui el captcha"))
            {
                captchaTxt.Text = "";
                captchaTxt.ForeColor = Color.Black;
            }
        }

        private void captchaTxt_Leave(object sender, EventArgs e)
        {
            if (captchaTxt.Text.Equals("Ingrese aqui el captcha") || string.IsNullOrEmpty(captchaTxt.Text))
            {
                captchaTxt.Text = "Ingrese aqui el captcha";
                captchaTxt.ForeColor = Color.DarkGray;
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Account _account = new Account(userTxt.Text, passTxt.Text, repassTxt.Text, emailTxt.Text, captchaTxt.Text);
            ClientSend.RegisterPakcet(_account);
            GC.Collect();
        }
    }
}
