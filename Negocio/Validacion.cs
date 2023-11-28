using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entities;

namespace Negocio
{
    public class Validacion
    {
        public void neg_TeclasNumericas(TextBox txt_num, object sender, KeyPressEventArgs e)
        {
            if (txt_num.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == '\b')
                    e.Handled = false;
            }
        }
        public void neg_NoTeclas(ComboBox txt_num, object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = true;

            if ((e.KeyChar == '\b') || (e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }
        public void neg_TeclasAlfabeticas(TextBox txtChar, object sender, KeyPressEventArgs e)
        {
            string CadenaTemporal;
            if (char.IsLetter(e.KeyChar))
            {
                if ((e.KeyChar == '\b') && (e.KeyChar == '.'))
                {
                    e.Handled = false;
                }
                else
                {
                    CadenaTemporal = e.KeyChar.ToString();
                    // e.KeyChar = Convert.ToChar(CadenaTemporal.ToUpper());
                }
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '\b') && (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
        }

       


    }
}
