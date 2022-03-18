
namespace ProyectoZLauncher
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.passTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.registerLbl = new ProyectoZ.UI.ProyectoZLabel();
            this.passLbl = new ProyectoZ.UI.ProyectoZLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.loginBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorlbl = new ProyectoZ.UI.ProyectoZLabel();
            this.proyectoZToggleButton1 = new ProyectoZ.UI.ProyectoZToggleButton();
            this.proyectoZLabel1 = new ProyectoZ.UI.ProyectoZLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userTxt
            // 
            this.userTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.FocusedLineColor = System.Drawing.Color.Gainsboro;
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.userTxt.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.userTxt.Location = new System.Drawing.Point(45, 149);
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.Size = new System.Drawing.Size(269, 26);
            this.userTxt.TabIndex = 2;
            this.userTxt.Text = "Ingrese aqui su usuario";
            this.userTxt.Enter += new System.EventHandler(this.userTxt_Enter);
            this.userTxt.Leave += new System.EventHandler(this.userTxt_Leave);
            // 
            // passTxt
            // 
            this.passTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.FocusedLineColor = System.Drawing.Color.Gainsboro;
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.passTxt.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.passTxt.Location = new System.Drawing.Point(45, 214);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(269, 26);
            this.passTxt.TabIndex = 4;
            this.passTxt.Text = "Ingrese aqui su contraseña";
            this.passTxt.Enter += new System.EventHandler(this.passTxt_Enter);
            this.passTxt.Leave += new System.EventHandler(this.passTxt_Leave);
            // 
            // registerLbl
            // 
            this.registerLbl.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.registerLbl.EnableGradient = true;
            this.registerLbl.enableOnHoverColors = true;
            this.registerLbl.EnableShadow = false;
            this.registerLbl.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.registerLbl.EndColorAlpha = 255;
            this.registerLbl.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.registerLbl.Location = new System.Drawing.Point(20, 326);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.OnHoverColor = System.Drawing.Color.SpringGreen;
            this.registerLbl.OnHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.registerLbl.ShadowColor = System.Drawing.Color.LightGray;
            this.registerLbl.ShadowOffset = 1;
            this.registerLbl.Size = new System.Drawing.Size(223, 23);
            this.registerLbl.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.registerLbl.StartColorAlpha = 255;
            this.registerLbl.TabIndex = 6;
            this.registerLbl.Text = "¿No tienes una cuenta? registrate ahora!";
            this.registerLbl.Click += new System.EventHandler(this.registerLbl_Click);
            // 
            // passLbl
            // 
            this.passLbl.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.passLbl.EnableGradient = true;
            this.passLbl.enableOnHoverColors = true;
            this.passLbl.EnableShadow = false;
            this.passLbl.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.passLbl.EndColorAlpha = 255;
            this.passLbl.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.passLbl.Location = new System.Drawing.Point(20, 303);
            this.passLbl.Name = "passLbl";
            this.passLbl.OnHoverColor = System.Drawing.Color.Crimson;
            this.passLbl.OnHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.passLbl.ShadowColor = System.Drawing.Color.LightGray;
            this.passLbl.ShadowOffset = 1;
            this.passLbl.Size = new System.Drawing.Size(223, 23);
            this.passLbl.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.passLbl.StartColorAlpha = 255;
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "¿Tienes problemas para iniciar sesion?";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoZLauncher.Properties.Resources.optionsLogo;
            this.pictureBox6.Location = new System.Drawing.Point(23, 246);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoZLauncher.Properties.Resources.Password;
            this.pictureBox5.Location = new System.Drawing.Point(14, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoZLauncher.Properties.Resources.User;
            this.pictureBox4.Location = new System.Drawing.Point(14, 148);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AnimationHoverSpeed = 0.07F;
            this.loginBtn.AnimationSpeed = 0.03F;
            this.loginBtn.BaseColor1 = System.Drawing.Color.Transparent;
            this.loginBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.loginBtn.BorderColor = System.Drawing.Color.Black;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Image = global::ProyectoZLauncher.Properties.Resources.Login;
            this.loginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.loginBtn.Location = new System.Drawing.Point(83, 388);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.loginBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.loginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.loginBtn.OnHoverImage = null;
            this.loginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.loginBtn.Size = new System.Drawing.Size(160, 42);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Ingresar";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoZLauncher.Properties.Resources.passwordLogo;
            this.pictureBox3.Location = new System.Drawing.Point(23, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoZLauncher.Properties.Resources.usuarioLogo;
            this.pictureBox2.Location = new System.Drawing.Point(23, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoZLauncher.Properties.Resources.loginLogo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorlbl
            // 
            this.errorlbl.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.errorlbl.EnableGradient = true;
            this.errorlbl.enableOnHoverColors = false;
            this.errorlbl.EnableShadow = false;
            this.errorlbl.EndColor = System.Drawing.Color.Maroon;
            this.errorlbl.EndColorAlpha = 255;
            this.errorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlbl.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.errorlbl.Location = new System.Drawing.Point(12, 349);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.OnHoverColor = System.Drawing.Color.White;
            this.errorlbl.OnHoverColor2 = System.Drawing.Color.Red;
            this.errorlbl.ShadowColor = System.Drawing.Color.LightGray;
            this.errorlbl.ShadowOffset = 1;
            this.errorlbl.Size = new System.Drawing.Size(311, 18);
            this.errorlbl.StartColor = System.Drawing.Color.Red;
            this.errorlbl.StartColorAlpha = 255;
            this.errorlbl.TabIndex = 13;
            this.errorlbl.Text = "Usuario o contraseña incorrectos [1/5]";
            this.errorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proyectoZToggleButton1
            // 
            this.proyectoZToggleButton1.AutoSize = true;
            this.proyectoZToggleButton1.Location = new System.Drawing.Point(23, 280);
            this.proyectoZToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.proyectoZToggleButton1.Name = "proyectoZToggleButton1";
            this.proyectoZToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.proyectoZToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.proyectoZToggleButton1.OnBackColor = System.Drawing.Color.SpringGreen;
            this.proyectoZToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.proyectoZToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.proyectoZToggleButton1.TabIndex = 14;
            this.proyectoZToggleButton1.UseVisualStyleBackColor = true;
            // 
            // proyectoZLabel1
            // 
            this.proyectoZLabel1.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.proyectoZLabel1.EnableGradient = true;
            this.proyectoZLabel1.enableOnHoverColors = false;
            this.proyectoZLabel1.EnableShadow = false;
            this.proyectoZLabel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.proyectoZLabel1.EndColorAlpha = 255;
            this.proyectoZLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoZLabel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.proyectoZLabel1.Location = new System.Drawing.Point(69, 279);
            this.proyectoZLabel1.Name = "proyectoZLabel1";
            this.proyectoZLabel1.OnHoverColor = System.Drawing.Color.Crimson;
            this.proyectoZLabel1.OnHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.proyectoZLabel1.ShadowColor = System.Drawing.Color.LightGray;
            this.proyectoZLabel1.ShadowOffset = 1;
            this.proyectoZLabel1.Size = new System.Drawing.Size(191, 23);
            this.proyectoZLabel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.proyectoZLabel1.StartColorAlpha = 255;
            this.proyectoZLabel1.TabIndex = 15;
            this.proyectoZLabel1.Text = "Iniciar sesion automaticamente";
            this.proyectoZLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(326, 457);
            this.Controls.Add(this.proyectoZLabel1);
            this.Controls.Add(this.proyectoZToggleButton1);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLineTextBox userTxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaLineTextBox passTxt;
        private ProyectoZ.UI.ProyectoZLabel passLbl;
        private ProyectoZ.UI.ProyectoZLabel registerLbl;
        private Guna.UI.WinForms.GunaGradientButton loginBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ProyectoZ.UI.ProyectoZLabel errorlbl;
        private ProyectoZ.UI.ProyectoZToggleButton proyectoZToggleButton1;
        private ProyectoZ.UI.ProyectoZLabel proyectoZLabel1;
    }
}