
namespace APP_SIVENTU
{
    partial class Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btmini = new System.Windows.Forms.PictureBox();
            this.btsalir = new System.Windows.Forms.PictureBox();
            this.btacces = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.Btmini);
            this.panel1.Controls.Add(this.btsalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 49);
            this.panel1.TabIndex = 0;
            // 
            // Btmini
            // 
            this.Btmini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btmini.BackgroundImage")));
            this.Btmini.Image = ((System.Drawing.Image)(resources.GetObject("Btmini.Image")));
            this.Btmini.Location = new System.Drawing.Point(961, 6);
            this.Btmini.Margin = new System.Windows.Forms.Padding(4);
            this.Btmini.Name = "Btmini";
            this.Btmini.Size = new System.Drawing.Size(40, 37);
            this.Btmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btmini.TabIndex = 1;
            this.Btmini.TabStop = false;
            this.Btmini.Click += new System.EventHandler(this.BtMini_Click);
            // 
            // btsalir
            // 
            this.btsalir.Image = ((System.Drawing.Image)(resources.GetObject("btsalir.Image")));
            this.btsalir.Location = new System.Drawing.Point(1021, 6);
            this.btsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(40, 37);
            this.btsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btsalir.TabIndex = 0;
            this.btsalir.TabStop = false;
            this.btsalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // btacces
            // 
            this.btacces.Activecolor = System.Drawing.SystemColors.ControlDark;
            this.btacces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btacces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btacces.BorderRadius = 0;
            this.btacces.ButtonText = "INGRESAR";
            this.btacces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btacces.DisabledColor = System.Drawing.Color.Gray;
            this.btacces.Iconcolor = System.Drawing.Color.Transparent;
            this.btacces.Iconimage = ((System.Drawing.Image)(resources.GetObject("btacces.Iconimage")));
            this.btacces.Iconimage_right = null;
            this.btacces.Iconimage_right_Selected = null;
            this.btacces.Iconimage_Selected = null;
            this.btacces.IconMarginLeft = 0;
            this.btacces.IconMarginRight = 0;
            this.btacces.IconRightVisible = true;
            this.btacces.IconRightZoom = 0D;
            this.btacces.IconVisible = true;
            this.btacces.IconZoom = 90D;
            this.btacces.IsTab = false;
            this.btacces.Location = new System.Drawing.Point(397, 553);
            this.btacces.Margin = new System.Windows.Forms.Padding(5);
            this.btacces.Name = "btacces";
            this.btacces.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btacces.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btacces.OnHoverTextColor = System.Drawing.Color.White;
            this.btacces.selected = false;
            this.btacces.Size = new System.Drawing.Size(316, 100);
            this.btacces.TabIndex = 1;
            this.btacces.Text = "INGRESAR";
            this.btacces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btacces.Textcolor = System.Drawing.Color.White;
            this.btacces.TextFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btacces.Click += new System.EventHandler(this.BTacces_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::APP_SIVENTU.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(191, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 708);
            this.Controls.Add(this.btacces);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btacces;
        private System.Windows.Forms.PictureBox btsalir;
        private System.Windows.Forms.PictureBox Btmini;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

