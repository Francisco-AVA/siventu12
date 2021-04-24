using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void bttotal_fac_Click(object sender, EventArgs e)
        {
            //-----MANDAR LOS DATOS A LA DATAVRISVIEW------//
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dvb_factura);
            fila.Cells[0].Value = Txt_cant.Text;
            fila.Cells[1].Value = Txt_descri.Text;
            fila.Cells[2].Value = Txt_preciou.Text;
            dvb_factura.Rows.Add(fila);

            //MULTIPLICAR LA CANTIDAD * UNIDAD
            double cantidad = 0;
            foreach (DataGridViewRow row in dvb_factura.Rows)
            {
                cantidad += Convert.ToDouble(row.Cells["cant"].Value) * Convert.ToDouble(row.Cells["precio_u"].Value);

            }
            fila.Cells[3].Value = Convert.ToDouble(cantidad);
            Txt_total.Text = Convert.ToString(cantidad);
        }

        private void btlimpiar_fac_Click(object sender, EventArgs e)
        {

            //LIMPIAR LOS TEXBOX DE ARRIBA
            Txtcliente_factura.Text = "";
            Txtdireccion_factura.Text = "";
            Txtvendedor_factura.Text = "";
            Txtfecha_factura.Text = "";
            Txt_cant.Text = "";
            Txt_descri.Text = "";
            Txt_preciou.Text = "";
        }

        private void btlimpiarpro_fac_Click(object sender, EventArgs e)
        {
            //------LIMPIAR DAYAGRIDVIEW-----//
            dvb_factura.Rows.Remove(dvb_factura.CurrentRow);

            //LIMPIAR TEXBOX DE RESULTADO
            Txt_total.Text = "";
        }
    }
}
