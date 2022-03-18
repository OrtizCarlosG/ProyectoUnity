
namespace ProyectoZLauncher
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.passTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.userTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.repassTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.emailTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.captchaTxt = new Guna.UI.WinForms.GunaLineTextBox();
            this.backBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.regBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passTxt
            // 
            this.passTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.passTxt.LineColor = System.Drawing.Color.Gainsboro;
            this.passTxt.Location = new System.Drawing.Point(45, 185);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(269, 26);
            this.passTxt.TabIndex = 13;
            this.passTxt.Text = "Ingrese aqui su contraseña";
            this.passTxt.Enter += new System.EventHandler(this.passTxt_Enter);
            this.passTxt.Leave += new System.EventHandler(this.passTxt_Leave);
            // 
            // userTxt
            // 
            this.userTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.userTxt.LineColor = System.Drawing.Color.Gainsboro;
            this.userTxt.Location = new System.Drawing.Point(45, 120);
            this.userTxt.Name = "userTxt";
            this.userTxt.PasswordChar = '\0';
            this.userTxt.Size = new System.Drawing.Size(269, 26);
            this.userTxt.TabIndex = 11;
            this.userTxt.Text = "Ingrese aqui su usuario";
            this.userTxt.Enter += new System.EventHandler(this.userTxt_Enter);
            this.userTxt.Leave += new System.EventHandler(this.userTxt_Leave);
            // 
            // repassTxt
            // 
            this.repassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.repassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repassTxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.repassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repassTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.repassTxt.LineColor = System.Drawing.Color.Gainsboro;
            this.repassTxt.Location = new System.Drawing.Point(45, 249);
            this.repassTxt.Name = "repassTxt";
            this.repassTxt.PasswordChar = '*';
            this.repassTxt.Size = new System.Drawing.Size(269, 26);
            this.repassTxt.TabIndex = 17;
            this.repassTxt.Text = "Ingrese aqui su contraseña";
            this.repassTxt.Enter += new System.EventHandler(this.repassTxt_Enter);
            this.repassTxt.Leave += new System.EventHandler(this.repassTxt_Leave);
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emailTxt.LineColor = System.Drawing.Color.Gainsboro;
            this.emailTxt.Location = new System.Drawing.Point(45, 313);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.Size = new System.Drawing.Size(269, 26);
            this.emailTxt.TabIndex = 20;
            this.emailTxt.Text = "Ingrese aqui su email";
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // captchaTxt
            // 
            this.captchaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.captchaTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captchaTxt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.captchaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captchaTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.captchaTxt.LineColor = System.Drawing.Color.Gainsboro;
            this.captchaTxt.Location = new System.Drawing.Point(45, 377);
            this.captchaTxt.Name = "captchaTxt";
            this.captchaTxt.PasswordChar = '\0';
            this.captchaTxt.Size = new System.Drawing.Size(269, 26);
            this.captchaTxt.TabIndex = 23;
            this.captchaTxt.Text = "Ingrese aqui el captcha";
            this.captchaTxt.Enter += new System.EventHandler(this.captchaTxt_Enter);
            this.captchaTxt.Leave += new System.EventHandler(this.captchaTxt_Leave);
            // 
            // backBtn
            // 
            this.backBtn.Animated = true;
            this.backBtn.AnimationHoverSpeed = 0.07F;
            this.backBtn.AnimationSpeed = 0.03F;
            this.backBtn.BaseColor1 = System.Drawing.Color.Transparent;
            this.backBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.backBtn.BorderColor = System.Drawing.Color.Black;
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backBtn.FocusedColor = System.Drawing.Color.Empty;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::ProyectoZLauncher.Properties.Resources.backArrow;
            this.backBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.backBtn.Location = new System.Drawing.Point(3, 409);
            this.backBtn.Name = "backBtn";
            this.backBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.backBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.backBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.backBtn.OnHoverImage = null;
            this.backBtn.OnPressedColor = System.Drawing.Color.Black;
            this.backBtn.Size = new System.Drawing.Size(153, 42);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "Regresar";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Animated = true;
            this.regBtn.AnimationHoverSpeed = 0.07F;
            this.regBtn.AnimationSpeed = 0.03F;
            this.regBtn.BaseColor1 = System.Drawing.Color.Transparent;
            this.regBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.regBtn.BorderColor = System.Drawing.Color.Black;
            this.regBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.regBtn.FocusedColor = System.Drawing.Color.Empty;
            this.regBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.Image = global::ProyectoZLauncher.Properties.Resources.Register;
            this.regBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.regBtn.Location = new System.Drawing.Point(169, 409);
            this.regBtn.Name = "regBtn";
            this.regBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.regBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.regBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.regBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.regBtn.OnHoverImage = null;
            this.regBtn.OnPressedColor = System.Drawing.Color.Black;
            this.regBtn.Size = new System.Drawing.Size(153, 42);
            this.regBtn.TabIndex = 25;
            this.regBtn.Text = "Registrarme";
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::ProyectoZLauncher.Properties.Resources.Captcha;
            this.pictureBox11.Location = new System.Drawing.Point(14, 377);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::ProyectoZLauncher.Properties.Resources.CaptchaLogo;
            this.pictureBox10.Location = new System.Drawing.Point(23, 344);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ProyectoZLauncher.Properties.Resources.Email;
            this.pictureBox9.Location = new System.Drawing.Point(14, 313);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ProyectoZLauncher.Properties.Resources.EmailLogo;
            this.pictureBox8.Location = new System.Drawing.Point(23, 280);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(69, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ProyectoZLauncher.Properties.Resources.Password;
            this.pictureBox7.Location = new System.Drawing.Point(14, 249);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoZLauncher.Properties.Resources.RePassLogo;
            this.pictureBox6.Location = new System.Drawing.Point(23, 216);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(224, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoZLauncher.Properties.Resources.Password;
            this.pictureBox5.Location = new System.Drawing.Point(14, 185);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoZLauncher.Properties.Resources.User;
            this.pictureBox4.Location = new System.Drawing.Point(14, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoZLauncher.Properties.Resources.passwordLogo;
            this.pictureBox3.Location = new System.Drawing.Point(23, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoZLauncher.Properties.Resources.usuarioLogo;
            this.pictureBox2.Location = new System.Drawing.Point(23, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(326, 457);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.captchaTxt);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.repassTxt);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI.WinForms.GunaLineTextBox passTxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaLineTextBox userTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI.WinForms.GunaLineTextBox repassTxt;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Guna.UI.WinForms.GunaLineTextBox emailTxt;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private Guna.UI.WinForms.GunaLineTextBox captchaTxt;
        private Guna.UI.WinForms.GunaGradientButton regBtn;
        private Guna.UI.WinForms.GunaGradientButton backBtn;
    }
}