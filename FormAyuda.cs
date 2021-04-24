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
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
        }
        //LLAMADO DE FORMULARIOS
        private void changeForms(object fh)
        {
            if (panel9info.Controls.Count > 0)
            {
               panel9info.Controls.Clear();
            }

            Form fromhijonuevo = fh as Form;
            fromhijonuevo.TopLevel = false; //acoplo del  nuevo form que viene
            fromhijonuevo.Dock = DockStyle.Fill; //llene todo
            panel9info.Controls.Add(fromhijonuevo);
            panel9info.Tag = fromhijonuevo;//se le indica que esta entrando el nuevo
            fromhijonuevo.Show();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            changeForms(new Ayuda1());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            changeForms(new Ayuda2());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            changeForms(new Ayuda3());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            changeForms(new Ayuda4());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            changeForms(new Ayuda5());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            changeForms(new Ayuda6());
        }
    }
}
