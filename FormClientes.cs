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
    public partial class FormClientes : Form
    {
        ventura ventuclient = new ventura();
        public FormClientes()
        {
            InitializeComponent();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string codigo = txtnumcliente.Text.Trim(),
                nombre = txtnombrecliente.Text.Trim(),
                sexo = comboBox1.Text.Trim(),
                Telefono = txttelefonoclientes.Text.Trim(),
                email = txtcorreocliente.Text.Trim(),
                direccion = Txtdireccioncliente.Text.Trim(),
                ciudad = Txtciudadcliente.Text.Trim(),
                fecha = Txtfechacliente.Text.Trim();

            bool result = ventuclient.Registrar(codigo, nombre, sexo, Telefono, email, direccion, fecha);
            if (result)
            {

                MessageBox.Show("Cliente registrado");

                txtnumcliente.Text = "";
                txtnombrecliente.Text = "";
                txttelefonoclientes.Text = "";
                txtcorreocliente.Text = "";
                Txtdireccioncliente.Text = "";
                Txtciudadcliente.Text = "";
                Txtfechacliente.Text = "";
            }
            else
            {
                MessageBox.Show("Cliente no registrado");
            }

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
   
        }
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
       
        private void N_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO NUMEROS
            validacion.SoloNumeros(e);
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO LETRAS
            validacion.SoloLetras(e);
        }

        private void Txtciudadclientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

       

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txtnumcliente.Text = "";
            txtnombrecliente.Text = "";
            txttelefonoclientes.Text = "";
            txtcorreocliente.Text = "";
            Txtdireccioncliente.Text = "";
            Txtciudadcliente.Text = "";
            Txtfechacliente.Text = "";
        }

        private void Txtcorreocliente_TextChanged(object sender, EventArgs e)
        {
            //correo validado
            if (Email_Valido(txtcorreocliente.Text) == false)// llamado del metodo Email_Valido
            {
                errorcliente.SetError(txtcorreocliente, " Ingrese un Email Válido");
                txtcorreocliente.Focus();
                btlimpiar_clientes.Enabled = false;
                return;
            }
            else
            {
                errorcliente.Clear();
                btguardar_clientes.Visible = true;
                btlimpiar_clientes.Enabled = true;

            }
        }

        private void btmodificar_clientes_Click(object sender, EventArgs e)
        {

        }
    }
}
