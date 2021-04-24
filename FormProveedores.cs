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
    public partial class FormProveedores : Form   
    {
        ventura ventuprove = new ventura();
        public FormProveedores()
        {
            InitializeComponent();
        }
        private void btguardar_prove_Click(object sender, EventArgs e)
        {

            string codigo = txtnumpro.Text.Trim(),
             nombre = txtnombrepro.Text.Trim(),
             direccion = txtdireccionpro.Text.Trim(),
             pais = Txtpaispro.Text.Trim(),
             telefono = txttelefonopro.Text.Trim(),
             correo = Txtcorreopro.Text.Trim(),
             rubro = Txtrubropro.Text.Trim(),
             product = txtproductopro.Text.Trim(),
             fecha = txtfechapro.Text.Trim();

            bool result = ventuprove.Registrador(codigo, nombre, direccion, telefono, correo, rubro, product, fecha);
            if (result)
            {
                MessageBox.Show("Usuario registrado");


            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO LETRA
            validacion.SoloLetras(e);
        }

        private void N_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO NUMERO
            validacion.SoloNumeros(e);
        }

        private void Txtpaispro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtrubropro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void Txtproductopro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        //----------------------------------------------------------
        public static bool Email_Valido(String email) // Método para validar el Email ingresado
        {
            String validando;
            validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }

        }
  
        private void btlimpiar_prove_Click(object sender, EventArgs e)
        {
            txtnumpro.Text = "";
            txtnombrepro.Text = "";
            txttelefonopro.Text = "";
            txtdireccionpro.Text = "";
            Txtpaispro.Text = "";
            Txtcorreopro.Text = "";
            Txtrubropro.Text = "";
            txtproductopro.Text = "";
            txtfechapro.Text = "";
        }

       

        private void Txtcorreopro_TextChanged(object sender, EventArgs e)
        {
            //correo validado

            if (Email_Valido(Txtcorreopro.Text) == false)// llamado del metodo Email_Valido
            {
                errorpro.SetError(Txtcorreopro, " Ingrese un Email Válido");
                Txtcorreopro.Focus();
                btlimpiar_prove.Enabled = false;
                return;
            }
            else
            {
                errorpro.Clear();
                btguardar_prove.Visible = true;
                btlimpiar_prove.Enabled = true;
            }
        }
    }
}
