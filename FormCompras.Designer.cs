
namespace APP_SIVENTU
{
    partial class FormCompras
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
            this.logoventucompras = new System.Windows.Forms.PictureBox();
            this.Txtfechacompras = new System.Windows.Forms.MaskedTextBox();
            this.Txttotalcompras = new System.Windows.Forms.TextBox();
            this.Txtdescripcioncompras = new System.Windows.Forms.TextBox();
            this.Txtcantidadcompras = new System.Windows.Forms.TextBox();
            this.Txtnumcompras = new System.Windows.Forms.TextBox();
            this.labelfechacompras = new System.Windows.Forms.Label();
            this.Labeltotalcompras = new System.Windows.Forms.Label();
            this.Labelcantidadcompras = new System.Windows.Forms.Label();
            this.Labelnumcompras = new System.Windows.Forms.Label();
            this.Txttelefonocompras = new System.Windows.Forms.MaskedTextBox();
            this.Labeldescripcioncompras = new System.Windows.Forms.Label();
            this.labeldireccioncompras = new System.Windows.Forms.Label();
            this.labeltelefonocompras = new System.Windows.Forms.Label();
            this.labelnombrecompras = new System.Windows.Forms.Label();
            this.labelcodigocompras = new System.Windows.Forms.Label();
            this.Txtdireccioncompras = new System.Windows.Forms.TextBox();
            this.Txtproveedorcompras = new System.Windows.Forms.TextBox();
            this.Txtcodigocompras = new System.Windows.Forms.TextBox();
            this.titulocompras = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txtsolicitadocompras = new System.Windows.Forms.TextBox();
            this.labelproductocompras = new System.Windows.Forms.Label();
            this.Txtobservacionescompras = new System.Windows.Forms.TextBox();
            this.Labelobservacionescompras = new System.Windows.Forms.Label();
            this.btlimpiar_com = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btguardar_com = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btmodificar_com = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoventucompras)).BeginInit();
            this.SuspendLayout();
            // 
            // logoventucompras
            // 
            this.logoventucompras.Image = global::APP_SIVENTU.Properties.Resources.logo_removebg_preview1;
            this.logoventucompras.Location = new System.Drawing.Point(14, 12);
            this.logoventucompras.Name = "logoventucompras";
            this.logoventucompras.Size = new System.Drawing.Size(157, 94);
            this.logoventucompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoventucompras.TabIndex = 76;
            this.logoventucompras.TabStop = false;
            // 
            // Txtfechacompras
            // 
            this.Txtfechacompras.Location = new System.Drawing.Point(310, 438);
            this.Txtfechacompras.Mask = "00/00/0000";
            this.Txtfechacompras.Name = "Txtfechacompras";
            this.Txtfechacompras.Size = new System.Drawing.Size(100, 20);
            this.Txtfechacompras.TabIndex = 73;
            // 
            // Txttotalcompras
            // 
            this.Txttotalcompras.Location = new System.Drawing.Point(310, 327);
            this.Txttotalcompras.Name = "Txttotalcompras";
            this.Txttotalcompras.Size = new System.Drawing.Size(216, 20);
            this.Txttotalcompras.TabIndex = 72;
            this.Txttotalcompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttotalcompras_KeyPres);
            // 
            // Txtdescripcioncompras
            // 
            this.Txtdescripcioncompras.Location = new System.Drawing.Point(310, 360);
            this.Txtdescripcioncompras.Name = "Txtdescripcioncompras";
            this.Txtdescripcioncompras.Size = new System.Drawing.Size(216, 20);
            this.Txtdescripcioncompras.TabIndex = 71;
            this.Txtdescripcioncompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcioncompras_KeyPres);
            // 
            // Txtcantidadcompras
            // 
            this.Txtcantidadcompras.Location = new System.Drawing.Point(310, 283);
            this.Txtcantidadcompras.Name = "Txtcantidadcompras";
            this.Txtcantidadcompras.Size = new System.Drawing.Size(216, 20);
            this.Txtcantidadcompras.TabIndex = 70;
            this.Txtcantidadcompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcantidadcompras_KeyPres);
            // 
            // Txtnumcompras
            // 
            this.Txtnumcompras.Location = new System.Drawing.Point(310, 203);
            this.Txtnumcompras.Name = "Txtnumcompras";
            this.Txtnumcompras.Size = new System.Drawing.Size(216, 20);
            this.Txtnumcompras.TabIndex = 69;
            this.Txtnumcompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumcomprasw_KeyPres);
            // 
            // labelfechacompras
            // 
            this.labelfechacompras.AutoSize = true;
            this.labelfechacompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelfechacompras.Location = new System.Drawing.Point(221, 439);
            this.labelfechacompras.Name = "labelfechacompras";
            this.labelfechacompras.Size = new System.Drawing.Size(67, 19);
            this.labelfechacompras.TabIndex = 68;
            this.labelfechacompras.Text = "FECHA:";
            // 
            // Labeltotalcompras
            // 
            this.Labeltotalcompras.AutoSize = true;
            this.Labeltotalcompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labeltotalcompras.Location = new System.Drawing.Point(140, 326);
            this.Labeltotalcompras.Name = "Labeltotalcompras";
            this.Labeltotalcompras.Size = new System.Drawing.Size(166, 19);
            this.Labeltotalcompras.TabIndex = 67;
            this.Labeltotalcompras.Text = "TOTAL DE COMPRA:";
            // 
            // Labelcantidadcompras
            // 
            this.Labelcantidadcompras.AutoSize = true;
            this.Labelcantidadcompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labelcantidadcompras.Location = new System.Drawing.Point(206, 284);
            this.Labelcantidadcompras.Name = "Labelcantidadcompras";
            this.Labelcantidadcompras.Size = new System.Drawing.Size(99, 19);
            this.Labelcantidadcompras.TabIndex = 66;
            this.Labelcantidadcompras.Text = "CANTIDAD:";
            // 
            // Labelnumcompras
            // 
            this.Labelnumcompras.AutoSize = true;
            this.Labelnumcompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labelnumcompras.Location = new System.Drawing.Point(161, 202);
            this.Labelnumcompras.Name = "Labelnumcompras";
            this.Labelnumcompras.Size = new System.Drawing.Size(133, 19);
            this.Labelnumcompras.TabIndex = 65;
            this.Labelnumcompras.Text = "N° DE COMPRA:";
            // 
            // Txttelefonocompras
            // 
            this.Txttelefonocompras.Location = new System.Drawing.Point(310, 173);
            this.Txttelefonocompras.Mask = "0000-0000";
            this.Txttelefonocompras.Name = "Txttelefonocompras";
            this.Txttelefonocompras.Size = new System.Drawing.Size(100, 20);
            this.Txttelefonocompras.TabIndex = 64;
            // 
            // Labeldescripcioncompras
            // 
            this.Labeldescripcioncompras.AutoSize = true;
            this.Labeldescripcioncompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labeldescripcioncompras.Location = new System.Drawing.Point(171, 359);
            this.Labeldescripcioncompras.Name = "Labeldescripcioncompras";
            this.Labeldescripcioncompras.Size = new System.Drawing.Size(124, 19);
            this.Labeldescripcioncompras.TabIndex = 62;
            this.Labeldescripcioncompras.Text = "DESCRIPCION:";
            // 
            // labeldireccioncompras
            // 
            this.labeldireccioncompras.AutoSize = true;
            this.labeldireccioncompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labeldireccioncompras.Location = new System.Drawing.Point(183, 144);
            this.labeldireccioncompras.Name = "labeldireccioncompras";
            this.labeldireccioncompras.Size = new System.Drawing.Size(106, 19);
            this.labeldireccioncompras.TabIndex = 61;
            this.labeldireccioncompras.Text = "DIRECCIÓN:";
            // 
            // labeltelefonocompras
            // 
            this.labeltelefonocompras.AutoSize = true;
            this.labeltelefonocompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labeltelefonocompras.Location = new System.Drawing.Point(195, 172);
            this.labeltelefonocompras.Name = "labeltelefonocompras";
            this.labeltelefonocompras.Size = new System.Drawing.Size(99, 19);
            this.labeltelefonocompras.TabIndex = 60;
            this.labeltelefonocompras.Text = "TELÉFONO:";
            // 
            // labelnombrecompras
            // 
            this.labelnombrecompras.AutoSize = true;
            this.labelnombrecompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrecompras.Location = new System.Drawing.Point(176, 108);
            this.labelnombrecompras.Name = "labelnombrecompras";
            this.labelnombrecompras.Size = new System.Drawing.Size(114, 19);
            this.labelnombrecompras.TabIndex = 59;
            this.labelnombrecompras.Text = "PROVEEDOR:";
            // 
            // labelcodigocompras
            // 
            this.labelcodigocompras.AutoSize = true;
            this.labelcodigocompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodigocompras.Location = new System.Drawing.Point(210, 70);
            this.labelcodigocompras.Name = "labelcodigocompras";
            this.labelcodigocompras.Size = new System.Drawing.Size(79, 19);
            this.labelcodigocompras.TabIndex = 58;
            this.labelcodigocompras.Text = "CÓDIGO:";
            this.labelcodigocompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txtdireccioncompras
            // 
            this.Txtdireccioncompras.Location = new System.Drawing.Point(310, 144);
            this.Txtdireccioncompras.Name = "Txtdireccioncompras";
            this.Txtdireccioncompras.Size = new System.Drawing.Size(216, 20);
            this.Txtdireccioncompras.TabIndex = 57;
            // 
            // Txtproveedorcompras
            // 
            this.Txtproveedorcompras.Location = new System.Drawing.Point(310, 107);
            this.Txtproveedorcompras.Name = "Txtproveedorcompras";
            this.Txtproveedorcompras.Size = new System.Drawing.Size(216, 20);
            this.Txtproveedorcompras.TabIndex = 56;
            this.Txtproveedorcompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtproveedorcompras_KeyPres);
            // 
            // Txtcodigocompras
            // 
            this.Txtcodigocompras.Location = new System.Drawing.Point(310, 71);
            this.Txtcodigocompras.Name = "Txtcodigocompras";
            this.Txtcodigocompras.Size = new System.Drawing.Size(100, 20);
            this.Txtcodigocompras.TabIndex = 55;
            this.Txtcodigocompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcodigocompras_KeyPres);
            // 
            // titulocompras
            // 
            this.titulocompras.AutoSize = true;
            this.titulocompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.titulocompras.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulocompras.ForeColor = System.Drawing.Color.White;
            this.titulocompras.Location = new System.Drawing.Point(272, -2);
            this.titulocompras.Name = "titulocompras";
            this.titulocompras.Size = new System.Drawing.Size(167, 36);
            this.titulocompras.TabIndex = 53;
            this.titulocompras.Text = "COMPRAS";
            // 
            // Txtsolicitadocompras
            // 
            this.Txtsolicitadocompras.Location = new System.Drawing.Point(310, 248);
            this.Txtsolicitadocompras.Name = "Txtsolicitadocompras";
            this.Txtsolicitadocompras.Size = new System.Drawing.Size(216, 20);
            this.Txtsolicitadocompras.TabIndex = 79;
            this.Txtsolicitadocompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtsolicitadocompras_KeyPres);
            // 
            // labelproductocompras
            // 
            this.labelproductocompras.AutoSize = true;
            this.labelproductocompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelproductocompras.Location = new System.Drawing.Point(177, 230);
            this.labelproductocompras.Name = "labelproductocompras";
            this.labelproductocompras.Size = new System.Drawing.Size(112, 38);
            this.labelproductocompras.TabIndex = 78;
            this.labelproductocompras.Text = "PRODUCTO \r\nSOLICITADO:";
            // 
            // Txtobservacionescompras
            // 
            this.Txtobservacionescompras.Location = new System.Drawing.Point(310, 399);
            this.Txtobservacionescompras.Name = "Txtobservacionescompras";
            this.Txtobservacionescompras.Size = new System.Drawing.Size(216, 20);
            this.Txtobservacionescompras.TabIndex = 81;
            // 
            // Labelobservacionescompras
            // 
            this.Labelobservacionescompras.AutoSize = true;
            this.Labelobservacionescompras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Labelobservacionescompras.Location = new System.Drawing.Point(158, 400);
            this.Labelobservacionescompras.Name = "Labelobservacionescompras";
            this.Labelobservacionescompras.Size = new System.Drawing.Size(147, 19);
            this.Labelobservacionescompras.TabIndex = 80;
            this.Labelobservacionescompras.Text = "OBSERVACIONES:";
            // 
            // btlimpiar_com
            // 
            this.btlimpiar_com.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_com.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_com.BorderRadius = 0;
            this.btlimpiar_com.ButtonText = "ELIMINAR";
            this.btlimpiar_com.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_com.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_com.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_com.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiar_com.Iconimage_right = null;
            this.btlimpiar_com.Iconimage_right_Selected = null;
            this.btlimpiar_com.Iconimage_Selected = null;
            this.btlimpiar_com.IconMarginLeft = 0;
            this.btlimpiar_com.IconMarginRight = 0;
            this.btlimpiar_com.IconRightVisible = true;
            this.btlimpiar_com.IconRightZoom = 0D;
            this.btlimpiar_com.IconVisible = true;
            this.btlimpiar_com.IconZoom = 90D;
            this.btlimpiar_com.IsTab = false;
            this.btlimpiar_com.Location = new System.Drawing.Point(428, 474);
            this.btlimpiar_com.Name = "btlimpiar_com";
            this.btlimpiar_com.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_com.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_com.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_com.selected = false;
            this.btlimpiar_com.Size = new System.Drawing.Size(153, 57);
            this.btlimpiar_com.TabIndex = 84;
            this.btlimpiar_com.Text = "ELIMINAR";
            this.btlimpiar_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlimpiar_com.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_com.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_com.Click += new System.EventHandler(this.btlimpiar_com_Click);
            // 
            // btguardar_com
            // 
            this.btguardar_com.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_com.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btguardar_com.BorderRadius = 0;
            this.btguardar_com.ButtonText = "GUARDAR";
            this.btguardar_com.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguardar_com.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_com.Iconcolor = System.Drawing.Color.Transparent;
            this.btguardar_com.Iconimage = global::APP_SIVENTU.Properties.Resources.disquete;
            this.btguardar_com.Iconimage_right = null;
            this.btguardar_com.Iconimage_right_Selected = null;
            this.btguardar_com.Iconimage_Selected = null;
            this.btguardar_com.IconMarginLeft = 0;
            this.btguardar_com.IconMarginRight = 0;
            this.btguardar_com.IconRightVisible = true;
            this.btguardar_com.IconRightZoom = 0D;
            this.btguardar_com.IconVisible = true;
            this.btguardar_com.IconZoom = 90D;
            this.btguardar_com.IsTab = false;
            this.btguardar_com.Location = new System.Drawing.Point(236, 474);
            this.btguardar_com.Name = "btguardar_com";
            this.btguardar_com.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btguardar_com.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btguardar_com.OnHoverTextColor = System.Drawing.Color.White;
            this.btguardar_com.selected = false;
            this.btguardar_com.Size = new System.Drawing.Size(154, 57);
            this.btguardar_com.TabIndex = 83;
            this.btguardar_com.Text = "GUARDAR";
            this.btguardar_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btguardar_com.Textcolor = System.Drawing.Color.White;
            this.btguardar_com.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar_com.Click += new System.EventHandler(this.btguardar_com_Click);
            // 
            // btmodificar_com
            // 
            this.btmodificar_com.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btmodificar_com.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmodificar_com.BorderRadius = 0;
            this.btmodificar_com.ButtonText = "MODIFICAR";
            this.btmodificar_com.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmodificar_com.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_com.Iconcolor = System.Drawing.Color.Transparent;
            this.btmodificar_com.Iconimage = global::APP_SIVENTU.Properties.Resources.boton_editar__1_;
            this.btmodificar_com.Iconimage_right = null;
            this.btmodificar_com.Iconimage_right_Selected = null;
            this.btmodificar_com.Iconimage_Selected = null;
            this.btmodificar_com.IconMarginLeft = 0;
            this.btmodificar_com.IconMarginRight = 0;
            this.btmodificar_com.IconRightVisible = true;
            this.btmodificar_com.IconRightZoom = 0D;
            this.btmodificar_com.IconVisible = true;
            this.btmodificar_com.IconZoom = 90D;
            this.btmodificar_com.IsTab = false;
            this.btmodificar_com.Location = new System.Drawing.Point(40, 474);
            this.btmodificar_com.Name = "btmodificar_com";
            this.btmodificar_com.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btmodificar_com.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btmodificar_com.OnHoverTextColor = System.Drawing.Color.White;
            this.btmodificar_com.selected = false;
            this.btmodificar_com.Size = new System.Drawing.Size(157, 57);
            this.btmodificar_com.TabIndex = 82;
            this.btmodificar_com.Text = "MODIFICAR";
            this.btmodificar_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmodificar_com.Textcolor = System.Drawing.Color.White;
            this.btmodificar_com.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(630, 555);
            this.Controls.Add(this.btlimpiar_com);
            this.Controls.Add(this.btguardar_com);
            this.Controls.Add(this.btmodificar_com);
            this.Controls.Add(this.Txtobservacionescompras);
            this.Controls.Add(this.Labelobservacionescompras);
            this.Controls.Add(this.Txtsolicitadocompras);
            this.Controls.Add(this.labelproductocompras);
            this.Controls.Add(this.logoventucompras);
            this.Controls.Add(this.Txtfechacompras);
            this.Controls.Add(this.Txttotalcompras);
            this.Controls.Add(this.Txtdescripcioncompras);
            this.Controls.Add(this.Txtcantidadcompras);
            this.Controls.Add(this.Txtnumcompras);
            this.Controls.Add(this.labelfechacompras);
            this.Controls.Add(this.Labeltotalcompras);
            this.Controls.Add(this.Labelcantidadcompras);
            this.Controls.Add(this.Labelnumcompras);
            this.Controls.Add(this.Txttelefonocompras);
            this.Controls.Add(this.Labeldescripcioncompras);
            this.Controls.Add(this.labeldireccioncompras);
            this.Controls.Add(this.labeltelefonocompras);
            this.Controls.Add(this.labelnombrecompras);
            this.Controls.Add(this.labelcodigocompras);
            this.Controls.Add(this.Txtdireccioncompras);
            this.Controls.Add(this.Txtproveedorcompras);
            this.Controls.Add(this.Txtcodigocompras);
            this.Controls.Add(this.titulocompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            ((System.ComponentModel.ISupportInitialize)(this.logoventucompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoventucompras;
        private System.Windows.Forms.MaskedTextBox Txtfechacompras;
        private System.Windows.Forms.TextBox Txttotalcompras;
        private System.Windows.Forms.TextBox Txtdescripcioncompras;
        private System.Windows.Forms.TextBox Txtcantidadcompras;
        private System.Windows.Forms.TextBox Txtnumcompras;
        private System.Windows.Forms.Label labelfechacompras;
        private System.Windows.Forms.Label Labeltotalcompras;
        private System.Windows.Forms.Label Labelcantidadcompras;
        private System.Windows.Forms.Label Labelnumcompras;
        private System.Windows.Forms.MaskedTextBox Txttelefonocompras;
        private System.Windows.Forms.Label Labeldescripcioncompras;
        private System.Windows.Forms.Label labeldireccioncompras;
        private System.Windows.Forms.Label labeltelefonocompras;
        private System.Windows.Forms.Label labelnombrecompras;
        private System.Windows.Forms.Label labelcodigocompras;
        private System.Windows.Forms.TextBox Txtdireccioncompras;
        private System.Windows.Forms.TextBox Txtproveedorcompras;
        private System.Windows.Forms.TextBox Txtcodigocompras;
        private Bunifu.Framework.UI.BunifuCustomLabel titulocompras;
        private System.Windows.Forms.TextBox Txtsolicitadocompras;
        private System.Windows.Forms.Label labelproductocompras;
        private System.Windows.Forms.TextBox Txtobservacionescompras;
        private System.Windows.Forms.Label Labelobservacionescompras;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_com;
        private Bunifu.Framework.UI.BunifuFlatButton btguardar_com;
        private Bunifu.Framework.UI.BunifuFlatButton btmodificar_com;
    }
}