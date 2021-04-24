using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace APP_SIVENTU
{


    public partial class FormCompras : Form
    {
        ventura ventucomp = new ventura();
        public FormCompras()
        {
            InitializeComponent();
        }

        private void Txtcodigocompras_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void Txtproveedorcompras_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtnumcomprasw_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void Txtsolicitadocompras_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtcantidadcompras_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void Txttotalcompras_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void Txtdescripcioncompras_KeyPres(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtobservacionescompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void btlimpiar_com_Click(object sender, EventArgs e)
        {
            Txtcodigocompras.Text = "";
            Txtproveedorcompras.Text = "";
            Txtdireccioncompras.Text = "";
            Txttelefonocompras.Text = "";
            Txtnumcompras.Text = "";
            Txtsolicitadocompras.Text = "";
            Txtcantidadcompras.Text = "";
            Txttelefonocompras.Text = "";
            Txtdescripcioncompras.Text = "";
            Txtobservacionescompras.Text = "";
            Txtfechacompras.Text = "";
        }

        private void btguardar_com_Click(object sender, EventArgs e)
        {
            string codigo = Txtcodigocompras.Text.Trim(),
                proveedor = Txtproveedorcompras.Text.Trim(),
                direccion = Txtdescripcioncompras.Text.Trim(),
                telefono = Txttelefonocompras.Text.Trim(),
                numerocom = Txtnumcompras.Text.Trim(),
                prododucosoli = Txtsolicitadocompras.Text.Trim(),
                cantidad = Txtcantidadcompras.Text.Trim(),
                total = Txttotalcompras.Text.Trim(),
                descrip = Txtdescripcioncompras.Text.Trim(),
                observa = Txtobservacionescompras.Text.Trim(),
                fecha = Txtfechacompras.Text.Trim();

            bool result = ventucomp.Registercom(codigo, proveedor, direccion, telefono, numerocom, prododucosoli, cantidad, total, descrip, observa, fecha);
            if (result)
            {
                MessageBox.Show("Compra registrada");
            }
            else
            {
                MessageBox.Show("compra no registrada");
            }
        }
    }
}
