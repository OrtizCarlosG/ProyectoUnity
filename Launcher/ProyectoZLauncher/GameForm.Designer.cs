
namespace ProyectoZLauncher
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.playBtn = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.currentProgress = new Guna.UI.WinForms.GunaProgressBar();
            this.completeProgress = new Guna.UI.WinForms.GunaProgressBar();
            this.closeBtn = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.profileImage = new ProyectoZ.UI.ProyectoZPictureBox();
            this.currentProgressText = new ProyectoZ.UI.ProyectoZLabel();
            this.statusLbl = new ProyectoZ.UI.ProyectoZLabel();
            this.proyectoZLabel4 = new ProyectoZ.UI.ProyectoZLabel();
            this.proyectoZLabel1 = new ProyectoZ.UI.ProyectoZLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Animated = true;
            this.playBtn.AnimationHoverSpeed = 0.07F;
            this.playBtn.AnimationSpeed = 0.03F;
            this.playBtn.BaseColor1 = System.Drawing.Color.Transparent;
            this.playBtn.BaseColor2 = System.Drawing.Color.Transparent;
            this.playBtn.BorderColor = System.Drawing.Color.Black;
            this.playBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playBtn.FocusedColor = System.Drawing.Color.Empty;
            this.playBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Image = global::ProyectoZLauncher.Properties.Resources.JugarLogo;
            this.playBtn.ImageSize = new System.Drawing.Size(250, 100);
            this.playBtn.Location = new System.Drawing.Point(392, 165);
            this.playBtn.Name = "playBtn";
            this.playBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.playBtn.OnHoverBaseColor2 = System.Drawing.Color.MediumSpringGreen;
            this.playBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.playBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.playBtn.OnHoverImage = global::ProyectoZLauncher.Properties.Resources.JugarHover;
            this.playBtn.OnPressedColor = System.Drawing.Color.Black;
            this.playBtn.Size = new System.Drawing.Size(343, 343);
            this.playBtn.TabIndex = 0;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // currentProgress
            // 
            this.currentProgress.BackColor = System.Drawing.Color.Transparent;
            this.currentProgress.BorderColor = System.Drawing.Color.Black;
            this.currentProgress.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.currentProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.currentProgress.Location = new System.Drawing.Point(16, 36);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.currentProgress.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.currentProgress.Radius = 10;
            this.currentProgress.Size = new System.Drawing.Size(1136, 23);
            this.currentProgress.TabIndex = 2;
            // 
            // completeProgress
            // 
            this.completeProgress.BackColor = System.Drawing.Color.Transparent;
            this.completeProgress.BorderColor = System.Drawing.Color.Black;
            this.completeProgress.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.completeProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.completeProgress.Location = new System.Drawing.Point(16, 99);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.ProgressMaxColor = System.Drawing.Color.MediumSpringGreen;
            this.completeProgress.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.completeProgress.Radius = 10;
            this.completeProgress.Size = new System.Drawing.Size(1136, 23);
            this.completeProgress.TabIndex = 5;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1159, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // minBtn
            // 
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(1128, 9);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(25, 25);
            this.minBtn.TabIndex = 7;
            this.minBtn.Text = "-";
            this.minBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.currentProgressText);
            this.panel1.Controls.Add(this.currentProgress);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.completeProgress);
            this.panel1.Location = new System.Drawing.Point(12, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 134);
            this.panel1.TabIndex = 8;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(28, 165);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton1.TabIndex = 10;
            this.gunaGradientButton1.Text = "Cambiar foto";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // profileImage
            // 
            this.profileImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profileImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.profileImage.BorderColor2 = System.Drawing.SystemColors.InactiveCaptionText;
            this.profileImage.BorderEffect = true;
            this.profileImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profileImage.BorderSize = 3;
            this.profileImage.GradientAngle = 50F;
            this.profileImage.HoverAngle = 50F;
            this.profileImage.HoverBorderColor = System.Drawing.Color.RoyalBlue;
            this.profileImage.HoverBorderColor2 = System.Drawing.Color.HotPink;
            this.profileImage.Location = new System.Drawing.Point(28, 9);
            this.profileImage.Name = "profileImage";
            this.profileImage.OnHover = true;
            this.profileImage.Size = new System.Drawing.Size(100, 100);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 11;
            this.profileImage.TabStop = false;
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.currentProgressText.EnableGradient = true;
            this.currentProgressText.enableOnHoverColors = false;
            this.currentProgressText.EnableShadow = false;
            this.currentProgressText.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.currentProgressText.EndColorAlpha = 255;
            this.currentProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProgressText.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.currentProgressText.Location = new System.Drawing.Point(24, 13);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.OnHoverColor = System.Drawing.Color.White;
            this.currentProgressText.OnHoverColor2 = System.Drawing.Color.Red;
            this.currentProgressText.ShadowColor = System.Drawing.Color.LightGray;
            this.currentProgressText.ShadowOffset = 1;
            this.currentProgressText.Size = new System.Drawing.Size(101, 18);
            this.currentProgressText.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.currentProgressText.StartColorAlpha = 255;
            this.currentProgressText.TabIndex = 3;
            this.currentProgressText.Text = "Descargando:";
            // 
            // statusLbl
            // 
            this.statusLbl.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.statusLbl.EnableGradient = true;
            this.statusLbl.enableOnHoverColors = false;
            this.statusLbl.EnableShadow = false;
            this.statusLbl.EndColor = System.Drawing.Color.SpringGreen;
            this.statusLbl.EndColorAlpha = 255;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.statusLbl.Location = new System.Drawing.Point(24, 78);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.OnHoverColor = System.Drawing.Color.White;
            this.statusLbl.OnHoverColor2 = System.Drawing.Color.Red;
            this.statusLbl.ShadowColor = System.Drawing.Color.LightGray;
            this.statusLbl.ShadowOffset = 1;
            this.statusLbl.Size = new System.Drawing.Size(255, 18);
            this.statusLbl.StartColor = System.Drawing.Color.MediumAquamarine;
            this.statusLbl.StartColorAlpha = 255;
            this.statusLbl.TabIndex = 4;
            this.statusLbl.Text = "Descarga finalizada, buen juego!";
            // 
            // proyectoZLabel4
            // 
            this.proyectoZLabel4.AutoSize = true;
            this.proyectoZLabel4.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.proyectoZLabel4.EnableGradient = true;
            this.proyectoZLabel4.enableOnHoverColors = true;
            this.proyectoZLabel4.EnableShadow = false;
            this.proyectoZLabel4.EndColor = System.Drawing.Color.Maroon;
            this.proyectoZLabel4.EndColorAlpha = 255;
            this.proyectoZLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoZLabel4.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.proyectoZLabel4.Location = new System.Drawing.Point(41, 145);
            this.proyectoZLabel4.Name = "proyectoZLabel4";
            this.proyectoZLabel4.OnHoverColor = System.Drawing.Color.Red;
            this.proyectoZLabel4.OnHoverColor2 = System.Drawing.Color.Brown;
            this.proyectoZLabel4.ShadowColor = System.Drawing.Color.LightGray;
            this.proyectoZLabel4.ShadowOffset = 1;
            this.proyectoZLabel4.Size = new System.Drawing.Size(101, 16);
            this.proyectoZLabel4.StartColor = System.Drawing.Color.Red;
            this.proyectoZLabel4.StartColorAlpha = 255;
            this.proyectoZLabel4.TabIndex = 6;
            this.proyectoZLabel4.Text = "Cerrar sesion";
            this.proyectoZLabel4.Click += new System.EventHandler(this.proyectoZLabel4_Click);
            // 
            // proyectoZLabel1
            // 
            this.proyectoZLabel1.AutoSize = true;
            this.proyectoZLabel1.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.proyectoZLabel1.EnableGradient = true;
            this.proyectoZLabel1.enableOnHoverColors = false;
            this.proyectoZLabel1.EnableShadow = false;
            this.proyectoZLabel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.proyectoZLabel1.EndColorAlpha = 255;
            this.proyectoZLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoZLabel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.proyectoZLabel1.Location = new System.Drawing.Point(35, 115);
            this.proyectoZLabel1.Name = "proyectoZLabel1";
            this.proyectoZLabel1.OnHoverColor = System.Drawing.Color.White;
            this.proyectoZLabel1.OnHoverColor2 = System.Drawing.Color.Red;
            this.proyectoZLabel1.ShadowColor = System.Drawing.Color.LightGray;
            this.proyectoZLabel1.ShadowOffset = 1;
            this.proyectoZLabel1.Size = new System.Drawing.Size(81, 24);
            this.proyectoZLabel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.proyectoZLabel1.StartColorAlpha = 255;
            this.proyectoZLabel1.TabIndex = 1;
            this.proyectoZLabel1.Text = "Charles";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1196, 686);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.proyectoZLabel4);
            this.Controls.Add(this.proyectoZLabel1);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientCircleButton playBtn;
        private ProyectoZ.UI.ProyectoZLabel proyectoZLabel1;
        private ProyectoZ.UI.ProyectoZLabel proyectoZLabel4;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label minBtn;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaProgressBar currentProgress;
        public Guna.UI.WinForms.GunaProgressBar completeProgress;
        public ProyectoZ.UI.ProyectoZLabel statusLbl;
        public ProyectoZ.UI.ProyectoZLabel currentProgressText;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        public ProyectoZ.UI.ProyectoZPictureBox profileImage;
    }
}