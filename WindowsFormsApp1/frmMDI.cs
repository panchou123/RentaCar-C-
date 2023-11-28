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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            var frmEmpleados = new frmEmpleados();
            frmEmpleados.TopLevel = false;
            frmEmpleados.Parent = this;
            frmEmpleados.Show();

        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {

        }

        private void btnUsurios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new frmUsuarios();
            frmUsuarios.TopLevel = false;
            frmUsuarios.Parent = this;
            frmUsuarios.Show();



        }
    }


}
