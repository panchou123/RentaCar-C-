using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace WinAppSAP
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            pboxFoto.Image = Properties.Resources.usuario;
        }

        private void pboxFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "image files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pboxFoto.Image = new Bitmap(dlg.FileName);


                }

            }
        }
        private void txt_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            var n = new Validacion();
            n.neg_TeclasAlfabeticas(txtNombre, sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
