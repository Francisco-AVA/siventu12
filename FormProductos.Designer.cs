
namespace APP_SIVENTU
{
    partial class FormProductos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfechapro = new System.Windows.Forms.MaskedTextBox();
            this.txtexistenciasproduc = new System.Windows.Forms.TextBox();
            this.Txtprecioproduc = new System.Windows.Forms.TextBox();
            this.labelfechaproduc = new System.Windows.Forms.Label();
            this.Labelprecioproduc = new System.Windows.Forms.Label();
            this.Labelexistenciaspeoduc = new System.Windows.Forms.Label();
            this.Labeldescripcionproduc = new System.Windows.Forms.Label();
            this.labelnombreproduc = new System.Windows.Forms.Label();
            this.txtdireccionproduc = new System.Windows.Forms.TextBox();
            this.txtcodigoproduc = new System.Windows.Forms.TextBox();
            this.labeltituloproveedores = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btlimpiar_produc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btguardar_produc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btmodificar_produc = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APP_SIVENTU.Properties.Resources.logo_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // txtfechapro
            // 
            this.txtfechapro.Location = new System.Drawing.Point(280, 360);
            this.txtfechapro.Mask = "00/00/0000";
            this.txtfechapro.Name = "txtfechapro";
            this.txtfechapro.Size = new System.Drawing.Size(100, 20);
            this.txtfechapro.TabIndex = 74;
            // 
            // txtexistenciasproduc
            // 
            this.txtexistenciasproduc.Location = new System.Drawing.Point(280, 297);
            this.txtexistenciasproduc.Name = "txtexistenciasproduc";
            this.txtexistenciasproduc.Size = new System.Drawing.Size(216, 20);
            this.txtexistenciasproduc.TabIndex = 72;
            this.txtexistenciasproduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtexistenciasproduc_KeyPress);
            // 
            // Txtprecioproduc
            // 
            this.Txtprecioproduc.Location = new System.Drawing.Point(280, 232);
            this.Txtprecioproduc.Name = "Txtprecioproduc";
            this.Txtprecioproduc.Size = new System.Drawing.Size(216, 20);
            this.Txtprecioproduc.TabIndex = 70;
            this.Txtprecioproduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtprecioproduc_KeyPress);
            // 
            // labelfechaproduc
            // 
            this.labelfechaproduc.AutoSize = true;
            this.labelfechaproduc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelfechaproduc.Location = new System.Drawing.Point(192, 361);
            this.labelfechaproduc.Name = "labelfechaproduc";
            this.labelfechaproduc.Size = new System.Drawing.Size(67, 19);
            this.labelfechaproduc.TabIndex = 69;
            this.labelfechaproduc.Text = "FECHA:";
            // 
            // Labelprecioproduc
            // 
            this.Labelprecioproduc.AutoSize = true;
            this.Labelprecioproduc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labelprecioproduc.Location = new System.Drawing.Point(136, 214);
            this.Labelprecioproduc.Name = "Labelprecioproduc";
            this.Labelprecioproduc.Size = new System.Drawing.Size(93, 38);
            this.Labelprecioproduc.TabIndex = 66;
            this.Labelprecioproduc.Text = "PRECIO \r\nUNITARIO:";
            // 
            // Labelexistenciaspeoduc
            // 
            this.Labelexistenciaspeoduc.AutoSize = true;
            this.Labelexistenciaspeoduc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labelexistenciaspeoduc.Location = new System.Drawing.Point(146, 280);
            this.Labelexistenciaspeoduc.Name = "Labelexistenciaspeoduc";
            this.Labelexistenciaspeoduc.Size = new System.Drawing.Size(114, 38);
            this.Labelexistenciaspeoduc.TabIndex = 63;
            this.Labelexistenciaspeoduc.Text = "EXISTENCIAS\r\nINICIALES:";
            // 
            // Labeldescripcionproduc
            // 
            this.Labeldescripcionproduc.AutoSize = true;
            this.Labeldescripcionproduc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labeldescripcionproduc.Location = new System.Drawing.Point(136, 183);
            this.Labeldescripcionproduc.Name = "Labeldescripcionproduc";
            this.Labeldescripcionproduc.Size = new System.Drawing.Size(124, 19);
            this.Labeldescripcionproduc.TabIndex = 62;
            this.Labeldescripcionproduc.Text = "DESCRIPCION:";
            // 
            // labelnombreproduc
            // 
            this.labelnombreproduc.AutoSize = true;
            this.labelnombreproduc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombreproduc.Location = new System.Drawing.Point(138, 121);
            this.labelnombreproduc.Name = "labelnombreproduc";
            this.labelnombreproduc.Size = new System.Drawing.Size(113, 38);
            this.labelnombreproduc.TabIndex = 60;
            this.labelnombreproduc.Text = "CODÍGO DEL \r\nPRODUCTO:";
            // 
            // txtdireccionproduc
            // 
            this.txtdireccionproduc.Location = new System.Drawing.Point(280, 182);
            this.txtdireccionproduc.Name = "txtdireccionproduc";
            this.txtdireccionproduc.Size = new System.Drawing.Size(216, 20);
            this.txtdireccionproduc.TabIndex = 58;
            this.txtdireccionproduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcionproduc_KeyPress);
            // 
            // txtcodigoproduc
            // 
            this.txtcodigoproduc.Location = new System.Drawing.Point(280, 139);
            this.txtcodigoproduc.Name = "txtcodigoproduc";
            this.txtcodigoproduc.Size = new System.Drawing.Size(216, 20);
            this.txtcodigoproduc.TabIndex = 57;
            this.txtcodigoproduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombreproduc_KeyPress);
            // 
            // labeltituloproveedores
            // 
            this.labeltituloproveedores.AutoSize = true;
            this.labeltituloproveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.labeltituloproveedores.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltituloproveedores.ForeColor = System.Drawing.Color.White;
            this.labeltituloproveedores.Location = new System.Drawing.Point(253, -1);
            this.labeltituloproveedores.Name = "labeltituloproveedores";
            this.labeltituloproveedores.Size = new System.Drawing.Size(206, 36);
            this.labeltituloproveedores.TabIndex = 52;
            this.labeltituloproveedores.Text = "PRODUCTOS";
            // 
            // btlimpiar_produc
            // 
            this.btlimpiar_produc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_produc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_produc.BorderRadius = 0;
            this.btlimpiar_produc.ButtonText = "ELIMINAR";
            this.btlimpiar_produc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_produc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_produc.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_produc.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_produc.Iconimage_right = null;
            this.btlimpiar_produc.Iconimage_right_Selected = null;
            this.btlimpiar_produc.Iconimage_Selected = null;
            this.btlimpiar_produc.IconMarginLeft = 0;
            this.btlimpiar_produc.IconMarginRight = 0;
            this.btlimpiar_produc.IconRightVisible = true;
            this.btlimpiar_produc.IconRightZoom = 0D;
            this.btlimpiar_produc.IconVisible = true;
            this.btlimpiar_produc.IconZoom = 90D;
            this.btlimpiar_produc.IsTab = false;
            this.btlimpiar_produc.Location = new System.Drawing.Point(433, 468);
            this.btlimpiar_produc.Name = "btlimpiar_produc";
            this.btlimpiar_produc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_produc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_produc.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_produc.selected = false;
            this.btlimpiar_produc.Size = new System.Drawing.Size(153, 57);
            this.btlimpiar_produc.TabIndex = 81;
            this.btlimpiar_produc.Text = "ELIMINAR";
            this.btlimpiar_produc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlimpiar_produc.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_produc.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_produc.Click += new System.EventHandler(this.btlimpiar_produc_Click);
            // 
            // btguardar_produc
            // 
            this.btguardar_produc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_produc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btguardar_produc.BorderRadius = 0;
            this.btguardar_produc.ButtonText = "GUARDAR";
            this.btguardar_produc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguardar_produc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_produc.Iconcolor = System.Drawing.Color.Transparent;
            this.btguardar_produc.Iconimage = global::APP_SIVENTU.Properties.Resources.disquete;
            this.btguardar_produc.Iconimage_right = null;
            this.btguardar_produc.Iconimage_right_Selected = null;
            this.btguardar_produc.Iconimage_Selected = null;
            this.btguardar_produc.IconMarginLeft = 0;
            this.btguardar_produc.IconMarginRight = 0;
            this.btguardar_produc.IconRightVisible = true;
            this.btguardar_produc.IconRightZoom = 0D;
            this.btguardar_produc.IconVisible = true;
            this.btguardar_produc.IconZoom = 90D;
            this.btguardar_produc.IsTab = false;
            this.btguardar_produc.Location = new System.Drawing.Point(241, 468);
            this.btguardar_produc.Name = "btguardar_produc";
            this.btguardar_produc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_produc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_produc.OnHoverTextColor = System.Drawing.Color.White;
            this.btguardar_produc.selected = false;
            this.btguardar_produc.Size = new System.Drawing.Size(154, 57);
            this.btguardar_produc.TabIndex = 80;
            this.btguardar_produc.Text = "GUARDAR";
            this.btguardar_produc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btguardar_produc.Textcolor = System.Drawing.Color.White;
            this.btguardar_produc.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar_produc.Click += new System.EventHandler(this.btguardar_produc_Click);
            // 
            // btmodificar_produc
            // 
            this.btmodificar_produc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btmodificar_produc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmodificar_produc.BorderRadius = 0;
            this.btmodificar_produc.ButtonText = "MODIFICAR";
            this.btmodificar_produc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmodificar_produc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_produc.Iconcolor = System.Drawing.Color.Transparent;
            this.btmodificar_produc.Iconimage = global::APP_SIVENTU.Properties.Resources.boton_editar__1_;
            this.btmodificar_produc.Iconimage_right = null;
            this.btmodificar_produc.Iconimage_right_Selected = null;
            this.btmodificar_produc.Iconimage_Selected = null;
            this.btmodificar_produc.IconMarginLeft = 0;
            this.btmodificar_produc.IconMarginRight = 0;
            this.btmodificar_produc.IconRightVisible = true;
            this.btmodificar_produc.IconRightZoom = 0D;
            this.btmodificar_produc.IconVisible = true;
            this.btmodificar_produc.IconZoom = 90D;
            this.btmodificar_produc.IsTab = false;
            this.btmodificar_produc.Location = new System.Drawing.Point(45, 468);
            this.btmodificar_produc.Name = "btmodificar_produc";
            this.btmodificar_produc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btmodificar_produc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_produc.OnHoverTextColor = System.Drawing.Color.White;
            this.btmodificar_produc.selected = false;
            this.btmodificar_produc.Size = new System.Drawing.Size(157, 57);
            this.btmodificar_produc.TabIndex = 79;
            this.btmodificar_produc.Text = "MODIFICAR";
            this.btmodificar_produc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmodificar_produc.Textcolor = System.Drawing.Color.White;
            this.btmodificar_produc.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(630, 555);
            this.Controls.Add(this.btlimpiar_produc);
            this.Controls.Add(this.btguardar_produc);
            this.Controls.Add(this.btmodificar_produc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfechapro);
            this.Controls.Add(this.txtexistenciasproduc);
            this.Controls.Add(this.Txtprecioproduc);
            this.Controls.Add(this.labelfechaproduc);
            this.Controls.Add(this.Labelprecioproduc);
            this.Controls.Add(this.Labelexistenciaspeoduc);
            this.Controls.Add(this.Labeldescripcionproduc);
            this.Controls.Add(this.labelnombreproduc);
            this.Controls.Add(this.txtdireccionproduc);
            this.Controls.Add(this.txtcodigoproduc);
            this.Controls.Add(this.labeltituloproveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtfechapro;
        private System.Windows.Forms.TextBox txtexistenciasproduc;
        private System.Windows.Forms.TextBox Txtprecioproduc;
        private System.Windows.Forms.Label labelfechaproduc;
        private System.Windows.Forms.Label Labelprecioproduc;
        private System.Windows.Forms.Label Labelexistenciaspeoduc;
        private System.Windows.Forms.Label Labeldescripcionproduc;
        private System.Windows.Forms.Label labelnombreproduc;
        private System.Windows.Forms.TextBox txtdireccionproduc;
        private System.Windows.Forms.TextBox txtcodigoproduc;
        private Bunifu.Framework.UI.BunifuCustomLabel labeltituloproveedores;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_produc;
        private Bunifu.Framework.UI.BunifuFlatButton btguardar_produc;
        private Bunifu.Framework.UI.BunifuFlatButton btmodificar_produc;
    }
}