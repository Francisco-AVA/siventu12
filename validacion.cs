using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace APP_SIVENTU
{
    class validacion
    {

        //---SOLO LETRAS
        public static void SoloLetras( KeyPressEventArgs k)
        {
            if (Char.IsLetter(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                k.Handled = true;
                MessageBox.Show("Solo se admiten letras");
            }
        }

        //-----SOLO NUMEROS

        public static void SoloNumeros(KeyPressEventArgs f)
        {
            if (char.IsDigit(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (char.IsSeparator(f.KeyChar))
            {
               f.Handled = false;
            }
            else if (char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else
            {
                f.Handled = true;
                MessageBox.Show("Solo se admiten números");
            }

        }

        //ALFANUMERICO


    }
}
