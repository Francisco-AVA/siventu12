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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BTacces_Click_1(object sender, EventArgs e)
        {
            //----BUENO SOLO QUITADO PARA PROBAR EL MENU MAS RAPIDO----//
            InicioDeSeccion Form = new InicioDeSeccion();
            Form.Show();
            this.Hide();

          
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {

        }
    }
}
