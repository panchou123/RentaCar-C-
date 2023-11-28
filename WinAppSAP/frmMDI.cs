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
        private frmEmpleados frmEmpleados;
        private frmUsuarios frmUsuarios;
        private frmProductos frmProductos;
        private frmAlmacen frmAlmacen;
        private frmClientes frmClientes;
        private frmVentas frmVentas;
        private frmRegistros frmRegistros;
        Facturas F = new Facturas();
        public frmMDI()
        {
            InitializeComponent();
            frmEmpleados = new frmEmpleados();
            frmUsuarios = new frmUsuarios();
            frmProductos = new frmProductos();
            frmAlmacen = new frmAlmacen();
            frmClientes = new frmClientes();
            frmVentas = new frmVentas();
            frmRegistros = new frmRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmEmpleados.Visible || frmUsuarios.Visible || frmProductos.Visible || frmAlmacen.Visible || frmClientes.Visible || frmVentas.Visible || frmRegistros.Visible)
            {
                if (MessageBox.Show(@"TIENE FORMULARIOS ABIERTOS ¿CERRAR SESION?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    frmEmpleados.Close();
                    frmUsuarios.Close();
                    frmProductos.Close();
                    frmAlmacen.Close();
                    frmClientes.Close();
                    frmVentas.Close();
                    frmRegistros.Close();
                    F.CancelaFacturas();
                    this.Close();
                    
                }
            }
            else
            {
                frmEmpleados.Close();
                frmUsuarios.Close();
                frmProductos.Close();
                frmAlmacen.Close();
                frmClientes.Close();
                frmVentas.Close();
                frmRegistros.Close();
                F.CancelaFacturas();
                this.Close();
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (!frmEmpleados.Visible)
            {
                frmEmpleados.TopLevel = false;
                frmEmpleados.Parent = this;
                frmEmpleados.Show();
                frmEmpleados.BringToFront();
            } else
            {
                frmEmpleados.BringToFront();
            }

        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            if (!frmAlmacen.Visible)
            {
                frmAlmacen.TopLevel = false;
                frmAlmacen.Parent = this;
                frmAlmacen.Show();
                frmAlmacen.BringToFront();
                
            }
            else
            {
                frmAlmacen.BringToFront();
            }
        }

        private void btnUsurios_Click(object sender, EventArgs e)
        {
            if (!frmUsuarios.Visible)
            {
                frmUsuarios.TopLevel = false;
                frmUsuarios.Parent = this;
                frmUsuarios.Show();
                frmUsuarios.BringToFront();
            }
            else
            {
                frmUsuarios.BringToFront();
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (!frmProductos.Visible)
            {
                frmProductos.TopLevel = false;
                frmProductos.Parent = this;
                frmProductos.Show();
                frmProductos.BringToFront();
            }
            else
            {
                frmProductos.BringToFront();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            if (!frmClientes.Visible)
            {
                frmClientes.TopLevel = false;
                frmClientes.Parent = this;
                frmClientes.Show();
                frmClientes.BringToFront();
            }
            else
            {
                frmClientes.BringToFront();
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (!frmVentas.Visible)
            {
                frmVentas.TopLevel = false;
                frmVentas.Parent = this;
                frmVentas.Show();
                frmVentas.BringToFront();
            }
            else
            {
                frmVentas.BringToFront();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!frmRegistros.Visible)
            {
                frmRegistros.TopLevel = false;
                frmRegistros.Parent = this;
                frmRegistros.Show();
                frmRegistros.BringToFront();
            }
            else
            {
                frmRegistros.BringToFront();
            }
        }

       
    }
}
