
namespace APP_SIVENTU
{
    partial class FormFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbventu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbventu2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbventu3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txtcliente_factura = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtdireccion_factura = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtfecha_factura = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contener_factura = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtvendedor_factura = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Lbcred_factura = new System.Windows.Forms.Label();
            this.Lbcont_factura = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dvb_factura = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventas_af = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Txt_cant = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txt_descri = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txt_preciou = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_total = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btlimpiarpro_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btlimpiar_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bttotal_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvb_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbventu
            // 
            this.Lbventu.AutoSize = true;
            this.Lbventu.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbventu.Location = new System.Drawing.Point(5, 13);
            this.Lbventu.Name = "Lbventu";
            this.Lbventu.Size = new System.Drawing.Size(339, 41);
            this.Lbventu.TabIndex = 1;
            this.Lbventu.Text = "CEREALES VENTURA";
            this.Lbventu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbventu2
            // 
            this.Lbventu2.AutoSize = true;
            this.Lbventu2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbventu2.Location = new System.Drawing.Point(63, 45);
            this.Lbventu2.Name = "Lbventu2";
            this.Lbventu2.Size = new System.Drawing.Size(209, 22);
            this.Lbventu2.TabIndex = 2;
            this.Lbventu2.Text = "VENTA DE CEREALES";
            this.Lbventu2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbventu3
            // 
            this.Lbventu3.AutoSize = true;
            this.Lbventu3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbventu3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbventu3.Location = new System.Drawing.Point(14, 63);
            this.Lbventu3.Name = "Lbventu3";
            this.Lbventu3.Size = new System.Drawing.Size(317, 66);
            this.Lbventu3.TabIndex = 3;
            this.Lbventu3.Text = "1a. Calle Oriente No.48, Usulután.\r\nEl Salvador, C.A.\r\nTel.: 2662-1843";
            this.Lbventu3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 114);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(271, 18);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "NELSON ORLANDO VENTURA SORTO";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(446, 17);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(171, 33);
            this.bunifuProgressBar1.TabIndex = 5;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.LightCyan;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(456, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(194, 22);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "FACTURA 20NU000F";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(461, 98);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(189, 19);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "NIT: 1123-300383-101-5";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(461, 83);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(124, 19);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "NRC: 291931-9";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(460, 54);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(174, 28);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "No         0783";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txtcliente_factura
            // 
            this.Txtcliente_factura.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txtcliente_factura.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txtcliente_factura.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txtcliente_factura.BorderThickness = 3;
            this.Txtcliente_factura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtcliente_factura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcliente_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txtcliente_factura.isPassword = false;
            this.Txtcliente_factura.Location = new System.Drawing.Point(9, 129);
            this.Txtcliente_factura.Margin = new System.Windows.Forms.Padding(4);
            this.Txtcliente_factura.Name = "Txtcliente_factura";
            this.Txtcliente_factura.Size = new System.Drawing.Size(370, 41);
            this.Txtcliente_factura.TabIndex = 9;
            this.Txtcliente_factura.Text = "CLIENTE:";
            this.Txtcliente_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMetroTextbox1.Enabled = false;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(444, 36);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(173, 92);
            this.bunifuMetroTextbox1.TabIndex = 11;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtdireccion_factura
            // 
            this.Txtdireccion_factura.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txtdireccion_factura.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txtdireccion_factura.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txtdireccion_factura.BorderThickness = 3;
            this.Txtdireccion_factura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtdireccion_factura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdireccion_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txtdireccion_factura.isPassword = false;
            this.Txtdireccion_factura.Location = new System.Drawing.Point(9, 168);
            this.Txtdireccion_factura.Margin = new System.Windows.Forms.Padding(4);
            this.Txtdireccion_factura.Name = "Txtdireccion_factura";
            this.Txtdireccion_factura.Size = new System.Drawing.Size(370, 41);
            this.Txtdireccion_factura.TabIndex = 12;
            this.Txtdireccion_factura.Text = "DIRECCION:";
            this.Txtdireccion_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtfecha_factura
            // 
            this.Txtfecha_factura.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txtfecha_factura.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txtfecha_factura.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txtfecha_factura.BorderThickness = 3;
            this.Txtfecha_factura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtfecha_factura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtfecha_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txtfecha_factura.isPassword = false;
            this.Txtfecha_factura.Location = new System.Drawing.Point(383, 129);
            this.Txtfecha_factura.Margin = new System.Windows.Forms.Padding(4);
            this.Txtfecha_factura.Name = "Txtfecha_factura";
            this.Txtfecha_factura.Size = new System.Drawing.Size(234, 26);
            this.Txtfecha_factura.TabIndex = 13;
            this.Txtfecha_factura.Text = "FECHA:";
            this.Txtfecha_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contener_factura
            // 
            this.contener_factura.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.contener_factura.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.contener_factura.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.contener_factura.BorderThickness = 3;
            this.contener_factura.Cursor = System.Windows.Forms.Cursors.Default;
            this.contener_factura.Enabled = false;
            this.contener_factura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contener_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.contener_factura.isPassword = false;
            this.contener_factura.Location = new System.Drawing.Point(383, 176);
            this.contener_factura.Margin = new System.Windows.Forms.Padding(4);
            this.contener_factura.Name = "contener_factura";
            this.contener_factura.Size = new System.Drawing.Size(234, 34);
            this.contener_factura.TabIndex = 14;
            this.contener_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtvendedor_factura
            // 
            this.Txtvendedor_factura.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txtvendedor_factura.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txtvendedor_factura.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txtvendedor_factura.BorderThickness = 3;
            this.Txtvendedor_factura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtvendedor_factura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtvendedor_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txtvendedor_factura.isPassword = false;
            this.Txtvendedor_factura.Location = new System.Drawing.Point(383, 153);
            this.Txtvendedor_factura.Margin = new System.Windows.Forms.Padding(4);
            this.Txtvendedor_factura.Name = "Txtvendedor_factura";
            this.Txtvendedor_factura.Size = new System.Drawing.Size(234, 26);
            this.Txtvendedor_factura.TabIndex = 15;
            this.Txtvendedor_factura.Text = "VENDEDOR:";
            this.Txtvendedor_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Lbcred_factura
            // 
            this.Lbcred_factura.AutoSize = true;
            this.Lbcred_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbcred_factura.Location = new System.Drawing.Point(408, 187);
            this.Lbcred_factura.Name = "Lbcred_factura";
            this.Lbcred_factura.Size = new System.Drawing.Size(55, 17);
            this.Lbcred_factura.TabIndex = 16;
            this.Lbcred_factura.Text = "CRED.";
            // 
            // Lbcont_factura
            // 
            this.Lbcont_factura.AutoSize = true;
            this.Lbcont_factura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbcont_factura.Location = new System.Drawing.Point(520, 187);
            this.Lbcont_factura.Name = "Lbcont_factura";
            this.Lbcont_factura.Size = new System.Drawing.Size(56, 17);
            this.Lbcont_factura.TabIndex = 17;
            this.Lbcont_factura.Text = "CONT.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(464, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(581, 187);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dvb_factura
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dvb_factura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvb_factura.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dvb_factura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvb_factura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvb_factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvb_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvb_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cant,
            this.descripcion,
            this.precio_u,
            this.ventas_af});
            this.dvb_factura.DoubleBuffered = true;
            this.dvb_factura.EnableHeadersVisualStyles = false;
            this.dvb_factura.GridColor = System.Drawing.SystemColors.Control;
            this.dvb_factura.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dvb_factura.HeaderForeColor = System.Drawing.Color.LightCyan;
            this.dvb_factura.Location = new System.Drawing.Point(17, 327);
            this.dvb_factura.Name = "dvb_factura";
            this.dvb_factura.ReadOnly = true;
            this.dvb_factura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvb_factura.RowHeadersWidth = 51;
            this.dvb_factura.Size = new System.Drawing.Size(595, 152);
            this.dvb_factura.TabIndex = 22;
            // 
            // cant
            // 
            this.cant.HeaderText = "CANT.";
            this.cant.MinimumWidth = 6;
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // precio_u
            // 
            this.precio_u.HeaderText = "PRECIO UNITARIO";
            this.precio_u.MinimumWidth = 6;
            this.precio_u.Name = "precio_u";
            this.precio_u.ReadOnly = true;
            this.precio_u.Width = 125;
            // 
            // ventas_af
            // 
            this.ventas_af.HeaderText = "VENTAS AFECTAS";
            this.ventas_af.MinimumWidth = 6;
            this.ventas_af.Name = "ventas_af";
            this.ventas_af.ReadOnly = true;
            this.ventas_af.Width = 125;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(2, 182);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(500, 28);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Txt_cant
            // 
            this.Txt_cant.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txt_cant.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txt_cant.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txt_cant.BorderThickness = 3;
            this.Txt_cant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_cant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cant.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txt_cant.isPassword = false;
            this.Txt_cant.Location = new System.Drawing.Point(75, 230);
            this.Txt_cant.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cant.Name = "Txt_cant";
            this.Txt_cant.Size = new System.Drawing.Size(75, 41);
            this.Txt_cant.TabIndex = 24;
            this.Txt_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_descri
            // 
            this.Txt_descri.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txt_descri.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txt_descri.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txt_descri.BorderThickness = 3;
            this.Txt_descri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_descri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Txt_descri.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txt_descri.isPassword = false;
            this.Txt_descri.Location = new System.Drawing.Point(293, 230);
            this.Txt_descri.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_descri.Name = "Txt_descri";
            this.Txt_descri.Size = new System.Drawing.Size(323, 41);
            this.Txt_descri.TabIndex = 25;
            this.Txt_descri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_preciou
            // 
            this.Txt_preciou.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txt_preciou.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txt_preciou.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txt_preciou.BorderThickness = 3;
            this.Txt_preciou.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_preciou.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Txt_preciou.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txt_preciou.isPassword = false;
            this.Txt_preciou.Location = new System.Drawing.Point(162, 282);
            this.Txt_preciou.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_preciou.Name = "Txt_preciou";
            this.Txt_preciou.Size = new System.Drawing.Size(118, 41);
            this.Txt_preciou.TabIndex = 26;
            this.Txt_preciou.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 240);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(70, 23);
            this.bunifuCustomLabel6.TabIndex = 31;
            this.bunifuCustomLabel6.Text = "CANT.";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(165, 240);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(149, 23);
            this.bunifuCustomLabel7.TabIndex = 32;
            this.bunifuCustomLabel7.Text = "DESCRIPCION:";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(12, 291);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(186, 23);
            this.bunifuCustomLabel8.TabIndex = 33;
            this.bunifuCustomLabel8.Text = "PRECIO UNITARIO:";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(312, 291);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(141, 23);
            this.bunifuCustomLabel14.TabIndex = 40;
            this.bunifuCustomLabel14.Text = "VENTA TOTAL:";
            this.bunifuCustomLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_total
            // 
            this.Txt_total.BorderColorFocused = System.Drawing.Color.MidnightBlue;
            this.Txt_total.BorderColorIdle = System.Drawing.Color.MidnightBlue;
            this.Txt_total.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.Txt_total.BorderThickness = 3;
            this.Txt_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_total.Enabled = false;
            this.Txt_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Txt_total.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Txt_total.isPassword = false;
            this.Txt_total.Location = new System.Drawing.Point(435, 282);
            this.Txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(181, 41);
            this.Txt_total.TabIndex = 41;
            this.Txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btlimpiarpro_fac
            // 
            this.btlimpiarpro_fac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiarpro_fac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiarpro_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiarpro_fac.BorderRadius = 0;
            this.btlimpiarpro_fac.ButtonText = "ELIMINAR PRODUCTO";
            this.btlimpiarpro_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiarpro_fac.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiarpro_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiarpro_fac.Iconimage = global::APP_SIVENTU.Properties.Resources.eliminar;
            this.btlimpiarpro_fac.Iconimage_right = null;
            this.btlimpiarpro_fac.Iconimage_right_Selected = null;
            this.btlimpiarpro_fac.Iconimage_Selected = null;
            this.btlimpiarpro_fac.IconMarginLeft = 0;
            this.btlimpiarpro_fac.IconMarginRight = 0;
            this.btlimpiarpro_fac.IconRightVisible = true;
            this.btlimpiarpro_fac.IconRightZoom = 0D;
            this.btlimpiarpro_fac.IconVisible = true;
            this.btlimpiarpro_fac.IconZoom = 90D;
            this.btlimpiarpro_fac.IsTab = false;
            this.btlimpiarpro_fac.Location = new System.Drawing.Point(424, 486);
            this.btlimpiarpro_fac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlimpiarpro_fac.Name = "btlimpiarpro_fac";
            this.btlimpiarpro_fac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiarpro_fac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiarpro_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiarpro_fac.selected = false;
            this.btlimpiarpro_fac.Size = new System.Drawing.Size(188, 59);
            this.btlimpiarpro_fac.TabIndex = 68;
            this.btlimpiarpro_fac.Text = "ELIMINAR PRODUCTO";
            this.btlimpiarpro_fac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btlimpiarpro_fac.Textcolor = System.Drawing.Color.White;
            this.btlimpiarpro_fac.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiarpro_fac.Click += new System.EventHandler(this.btlimpiarpro_fac_Click);
            // 
            // btlimpiar_fac
            // 
            this.btlimpiar_fac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_fac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlimpiar_fac.BorderRadius = 0;
            this.btlimpiar_fac.ButtonText = "LIMPIAR";
            this.btlimpiar_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlimpiar_fac.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.btlimpiar_fac.Iconimage = global::APP_SIVENTU.Properties.Resources.disquete;
            this.btlimpiar_fac.Iconimage_right = null;
            this.btlimpiar_fac.Iconimage_right_Selected = null;
            this.btlimpiar_fac.Iconimage_Selected = null;
            this.btlimpiar_fac.IconMarginLeft = 0;
            this.btlimpiar_fac.IconMarginRight = 0;
            this.btlimpiar_fac.IconRightVisible = true;
            this.btlimpiar_fac.IconRightZoom = 0D;
            this.btlimpiar_fac.IconVisible = true;
            this.btlimpiar_fac.IconZoom = 90D;
            this.btlimpiar_fac.IsTab = false;
            this.btlimpiar_fac.Location = new System.Drawing.Point(214, 486);
            this.btlimpiar_fac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlimpiar_fac.Name = "btlimpiar_fac";
            this.btlimpiar_fac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.btlimpiar_fac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.btlimpiar_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.btlimpiar_fac.selected = false;
            this.btlimpiar_fac.Size = new System.Drawing.Size(193, 59);
            this.btlimpiar_fac.TabIndex = 67;
            this.btlimpiar_fac.Text = "LIMPIAR";
            this.btlimpiar_fac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btlimpiar_fac.Textcolor = System.Drawing.Color.White;
            this.btlimpiar_fac.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar_fac.Click += new System.EventHandler(this.btlimpiar_fac_Click);
            // 
            // bttotal_fac
            // 
            this.bttotal_fac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.bttotal_fac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bttotal_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttotal_fac.BorderRadius = 0;
            this.bttotal_fac.ButtonText = "TOTAL";
            this.bttotal_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttotal_fac.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.bttotal_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.bttotal_fac.Iconimage = global::APP_SIVENTU.Properties.Resources.boton_editar__1_;
            this.bttotal_fac.Iconimage_right = null;
            this.bttotal_fac.Iconimage_right_Selected = null;
            this.bttotal_fac.Iconimage_Selected = null;
            this.bttotal_fac.IconMarginLeft = 0;
            this.bttotal_fac.IconMarginRight = 0;
            this.bttotal_fac.IconRightVisible = true;
            this.bttotal_fac.IconRightZoom = 0D;
            this.bttotal_fac.IconVisible = true;
            this.bttotal_fac.IconZoom = 90D;
            this.bttotal_fac.IsTab = false;
            this.bttotal_fac.Location = new System.Drawing.Point(31, 486);
            this.bttotal_fac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttotal_fac.Name = "bttotal_fac";
            this.bttotal_fac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(57)))), ((int)(((byte)(74)))));
            this.bttotal_fac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.bttotal_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.bttotal_fac.selected = false;
            this.bttotal_fac.Size = new System.Drawing.Size(160, 59);
            this.bttotal_fac.TabIndex = 66;
            this.bttotal_fac.Text = "TOTAL";
            this.bttotal_fac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttotal_fac.Textcolor = System.Drawing.Color.White;
            this.bttotal_fac.TextFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttotal_fac.Click += new System.EventHandler(this.bttotal_fac_Click);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(630, 555);
            this.Controls.Add(this.btlimpiarpro_fac);
            this.Controls.Add(this.btlimpiar_fac);
            this.Controls.Add(this.bttotal_fac);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.Txt_preciou);
            this.Controls.Add(this.Txt_descri);
            this.Controls.Add(this.Txt_cant);
            this.Controls.Add(this.dvb_factura);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Lbcont_factura);
            this.Controls.Add(this.Lbcred_factura);
            this.Controls.Add(this.Txtvendedor_factura);
            this.Controls.Add(this.contener_factura);
            this.Controls.Add(this.Txtfecha_factura);
            this.Controls.Add(this.Txtdireccion_factura);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Txtcliente_factura);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Lbventu3);
            this.Controls.Add(this.Lbventu2);
            this.Controls.Add(this.Lbventu);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvb_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu2;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbventu3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtcliente_factura;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtdireccion_factura;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtfecha_factura;
        private Bunifu.Framework.UI.BunifuMetroTextbox contener_factura;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtvendedor_factura;
        private System.Windows.Forms.Label Lbcred_factura;
        private System.Windows.Forms.Label Lbcont_factura;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dvb_factura;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txt_cant;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txt_descri;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txt_preciou;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventas_af;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiarpro_fac;
        private Bunifu.Framework.UI.BunifuFlatButton btlimpiar_fac;
        private Bunifu.Framework.UI.BunifuFlatButton bttotal_fac;
    }
}