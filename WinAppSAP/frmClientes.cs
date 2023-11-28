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
    public partial class frmClientes : Form
    {
        int fill;
        int id;
        string col1="";
        Clientes C = new Clientes();
        Ventas V = new Ventas();
        Facturas F = new Facturas();
        Validacion n = new Validacion();
        List<Entities.Clientes> traertodo;

        public frmClientes()
        {
            InitializeComponent();
            tipAgregar.SetToolTip(btnAgregar, "Agregar");
            tipGuardar.SetToolTip(btnGuardar, "Guardar");
            tipLimpiar.SetToolTip(btnLimpiar, "Limpiar");
            tipBuscar.SetToolTip(btnBuscar, "Buscar");
            tipEliminar.SetToolTip(btnEliminar, "Eliminar");
            tipSalir.SetToolTip(btnSalir, "Salir");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            traertodo = C.SelectClientes();
            foreach (var idCli in traertodo)
            {
                if ((idCli.Cliente.ToUpper()).Replace(" ", "") == (txtCliente.Text.ToUpper()).Replace(" ", ""))
                {
                    MessageBox.Show(@"ESTE CLIENTE YA EXISTE", "M E N S A J E D E L S I S T E M A");
                    return;
                }
            }

            if (txtCliente.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                    if (MessageBox.Show(@"¿AGREGAR CLIENTE?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        C.InsertarCliente(id, txtCliente.Text, txtTelefono.Text,txtDireccion.Text,txtCorreo.Text, DateTime.Now.Date);
                        btnLimpiar.PerformClick();
                        btnBuscar.PerformClick();
                        MessageBox.Show(@"CLIENTE AGREGADO", "M E N S A J E D E L S I S T E M A");
                    }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            id = 0;
            fill = 0;
            col1 = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"ALERTA, AL REALIZAR ESTA ACCION TODAS LAS COMPRAS Y FACTURAS DEL CLIENTE SERAN TAMBIEN ELIMINADAS ¿DESEA CONTINUAR?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                V.EliminarVentaCliente(id);
                F.CancelaFacturas();
                C.EliminarCliente(id);
                btnLimpiar.PerformClick();
                btnBuscar.PerformClick();
                MessageBox.Show(@"CLIENTE ELIMINADO", "M E N S A J E D E L S I S T E M A");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            traertodo = C.SelectClientes();
            foreach (var idCli in traertodo)
            {
                if ((idCli.Cliente.ToUpper()).Replace(" ", "") == (txtCliente.Text.ToUpper()).Replace(" ", "") && (txtCliente.Text.ToUpper()).Replace(" ", "") != (col1.ToUpper()).Replace(" ", ""))
                {
                    MessageBox.Show(@"ESTE CLIENTE YA EXISTE", "M E N S A J E D E L S I S T E M A");
                    return;
                }
            }

            if (MessageBox.Show(@"¿MODIFICAR CLIENTE?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                C.InsertarCliente(id, txtCliente.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text, DateTime.Now.Date);
                btnLimpiar.PerformClick();
                btnBuscar.PerformClick();
                MessageBox.Show(@"CLIENTE MODIFICADO", "M E N S A J E D E L S I S T E M A");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = C.SelectClientes();
            dgvClientes.Columns["idCliente"].Visible = false;

            dgvClientes.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.Columns["Cliente"].Width = 280;
            dgvClientes.Columns["Cliente"].ReadOnly = true;

            dgvClientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.Columns["Telefono"].Width = 100;
            dgvClientes.Columns["Telefono"].ReadOnly = true;

            dgvClientes.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.Columns["Direccion"].Width = 180;
            dgvClientes.Columns["Direccion"].ReadOnly = true;

            dgvClientes.Columns["Correo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.Columns["Correo"].Width = 180;
            dgvClientes.Columns["Correo"].ReadOnly = true;

            dgvClientes.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.Columns["Fecha"].Width = 100;
            dgvClientes.Columns["Fecha"].ReadOnly = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            this.Visible = false;
            
            dgvClientes.DataSource = null;
        }

        private void dgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvClientes.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvClientes.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvClientes.Rows[fill].Cells[0].Value);
            }
        }

        private void dgvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvClientes.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvClientes.CurrentCell.RowIndex;
                int col0 = Convert.ToInt32(dgvClientes.Rows[fill].Cells[0].Value);         //id
                col1 = Convert.ToString(dgvClientes.Rows[fill].Cells[1].Value);     //Cliente
                string col2 = Convert.ToString(dgvClientes.Rows[fill].Cells[2].Value);     //Telefono
                string col3 = Convert.ToString(dgvClientes.Rows[fill].Cells[3].Value);     //Direccion
                string col4 = Convert.ToString(dgvClientes.Rows[fill].Cells[4].Value);     //Correo

                id = col0;
                txtCliente.Text = col1;
                txtTelefono.Text = col2;
                txtDireccion.Text = col3;
                txtCorreo.Text = col4;

                btnGuardar.Enabled = true;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
            }
        }
        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_TeclasAlfabeticas(txtCliente, sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_TeclasNumericas(txtTelefono, sender, e);
        }
    }
}
