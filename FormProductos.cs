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
    public partial class FormProductos : Form
    {
        ventura ventuproduc = new ventura();
        public FormProductos()
        {
            InitializeComponent();
        }

        private void Txtnombreproduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtdescripcionproduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtprecioproduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void Txtexistenciasproduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }



        private void btlimpiar_produc_Click(object sender, EventArgs e)
        {
            txtcodigoproduc.Text = "";
            txtdireccionproduc.Text = "";
            Txtprecioproduc.Text = "";
            txtexistenciasproduc.Text = "";
            txtfechapro.Text = "";
        }

        private void btguardar_produc_Click(object sender, EventArgs e)
        {
            string codigo_prod = txtcodigoproduc.Text.Trim(),
                descripcion = txtdireccionproduc.Text.Trim(),
                precio = Txtprecioproduc.Text.Trim(),
                existencias = txtexistenciasproduc.Text.Trim(),
                fecha = txtfechapro.Text.Trim();

            bool result = ventuproduc.Registradorpro(codigo_prod, descripcion, precio, existencias, fecha);
            if (result)
            {
                MessageBox.Show("producto registrado");
            }
            else
            {
                MessageBox.Show("producto no registrado");
            }
        }
    }
}

