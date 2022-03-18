
namespace ProyectoZLauncher
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proyectoZLabel1 = new ProyectoZ.UI.ProyectoZLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.proyectoZSlider1 = new ProyectoZ.UI.ProyectoZSlider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.minBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.proyectoZLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 35);
            this.panel1.TabIndex = 0;
            // 
            // minBtn
            // 
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(1137, 5);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(25, 25);
            this.minBtn.TabIndex = 8;
            this.minBtn.Text = "-";
            this.minBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1168, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoZLauncher.Properties.Resources.GameIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // proyectoZLabel1
            // 
            this.proyectoZLabel1.AutoSize = true;
            this.proyectoZLabel1.DrawingDirection = ProyectoZ.UI.ProyectoZLabel.Angles.LeftToRight;
            this.proyectoZLabel1.EnableGradient = true;
            this.proyectoZLabel1.enableOnHoverColors = false;
            this.proyectoZLabel1.EnableShadow = false;
            this.proyectoZLabel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.proyectoZLabel1.EndColorAlpha = 255;
            this.proyectoZLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoZLabel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.proyectoZLabel1.Location = new System.Drawing.Point(42, 9);
            this.proyectoZLabel1.Name = "proyectoZLabel1";
            this.proyectoZLabel1.OnHoverColor = System.Drawing.Color.White;
            this.proyectoZLabel1.OnHoverColor2 = System.Drawing.Color.Red;
            this.proyectoZLabel1.ShadowColor = System.Drawing.Color.LightGray;
            this.proyectoZLabel1.ShadowOffset = 1;
            this.proyectoZLabel1.Size = new System.Drawing.Size(175, 20);
            this.proyectoZLabel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.proyectoZLabel1.StartColorAlpha = 255;
            this.proyectoZLabel1.TabIndex = 0;
            this.proyectoZLabel1.Text = "Proyecto Z Launcher";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaPanel1.Controls.Add(this.panel2);
            this.gunaPanel1.Controls.Add(this.pictureBox2);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 53);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(332, 621);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(14, 148);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(304, 10);
            this.gunaSeparator1.TabIndex = 2;
            this.gunaSeparator1.Thickness = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 454);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoZLauncher.Properties.Resources.GameLogo;
            this.pictureBox2.Location = new System.Drawing.Point(34, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // proyectoZSlider1
            // 
            this.proyectoZSlider1.Animation = true;
            this.proyectoZSlider1.AnnounceText = null;
            this.proyectoZSlider1.CaptionAnimationSpeed = 50;
            this.proyectoZSlider1.CaptionBackgrounColor = System.Drawing.Color.Black;
            this.proyectoZSlider1.CaptionHeight = 50;
            this.proyectoZSlider1.CaptionOpacity = 100;
            this.proyectoZSlider1.ImageTime = 4000;
            this.proyectoZSlider1.Location = new System.Drawing.Point(351, 53);
            this.proyectoZSlider1.Name = "proyectoZSlider1";
            this.proyectoZSlider1.Size = new System.Drawing.Size(833, 621);
            this.proyectoZSlider1.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1196, 686);
            this.Controls.Add(this.proyectoZSlider1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "ProyectoZ Launcher";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private ProyectoZ.UI.ProyectoZSlider proyectoZSlider1;
        private ProyectoZ.UI.ProyectoZLabel proyectoZLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label minBtn;
        private System.Windows.Forms.Label closeBtn;
    }
}

