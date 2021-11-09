using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reservaciones
{
    class Validaciones
    {

        public void numerosEnteros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        public void letrasNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) | char.IsControl(e.KeyChar) | char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }

        public void letras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) | char.IsControl(e.KeyChar) | char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void decimales(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
