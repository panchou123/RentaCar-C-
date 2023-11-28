using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Negocio;

namespace WinAppSAP
{
    public partial class frmAlmacen : Form
    {
        Validacion n = new Validacion();
        Negocio.Productos p = new Negocio.Productos();
        Negocio.Almacen a = new Negocio.Almacen();
        int id = 0;
        int fill = 0;
        public frmAlmacen()
        {
            InitializeComponent();
            tipAgregar.SetToolTip(btnAgregar, "Agregar");
            tipGuardar.SetToolTip(btnGuardar, "Guardar");
            tipLimpiar.SetToolTip(btnLimpiar, "Limpiar");
            tipBuscar.SetToolTip(btnBuscar, "Buscar");
            tipEliminar.SetToolTip(btnEliminar, "Eliminar");
            tipSalir.SetToolTip(btnSalir, "Salir");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fill = 0;
            id = 0;
            txtCantidad.Text = "";
            cmbProducto.Text = "";
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbProducto.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show(@"¿ELIMINAR REGISTRO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    a.EliminarAlmacen(id);
                    btnLimpiar_Click(sender, e);
                    btnBuscar_Click(sender, e);
                    MessageBox.Show(@"REGISTRO ELIMINADO", "M E N S A J E D E L S I S T E M A");
                }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                    if (MessageBox.Show(@"¿MODIFICAR REGISTRO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        a.InsertarAlmacen(id, Convert.ToInt32(cmbProducto.SelectedValue), Convert.ToInt32(txtCantidad.Text), DateTime.Now.Date);
                        btnLimpiar.PerformClick();
                        btnBuscar.PerformClick();
                        MessageBox.Show(@"REGISTRO MODIFICADO", "M E N S A J E D E L S I S T E M A");
                    }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlmacen.DataSource = a.SelectAlmacen();
            dgvAlmacen.Columns["idAlmacen"].Visible = false;
            dgvAlmacen.Columns["idProducto"].Visible = false;

            dgvAlmacen.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAlmacen.Columns["Producto"].Width = 680;
            dgvAlmacen.Columns["Producto"].ReadOnly = true;

            dgvAlmacen.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAlmacen.Columns["Cantidad"].Width = 200;
            dgvAlmacen.Columns["Cantidad"].ReadOnly = true;

            dgvAlmacen.Columns["Fecha"].HeaderText = "Fecha de Registro";
            dgvAlmacen.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAlmacen.Columns["Fecha"].Width = 250;
            dgvAlmacen.Columns["Fecha"].ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            this.Visible = false;
           
            dgvAlmacen.DataSource = null;
        }

        private void cmbProducto_MouseClick(object sender, MouseEventArgs e)
        {
            cmbProducto.DataSource = p.ProductoNoRegistrado();
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.DisplayMember = "Producto";
        }

        private void dgvAlmacen_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAlmacen.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvAlmacen.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvAlmacen.Rows[fill].Cells[0].Value);
            }
        }

        private void dgvAlmacen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvAlmacen.CurrentCell != null)
            {
            cmbProducto.DataSource = p.SelectProductos();
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.DisplayMember = "Producto";
            fill = 0;
            fill = dgvAlmacen.CurrentCell.RowIndex;
            int col0 = Convert.ToInt32(dgvAlmacen.Rows[fill].Cells[0].Value);        //id Almacen  
            int col1 = Convert.ToInt32(dgvAlmacen.Rows[fill].Cells[1].Value);         //idProducto
            string col3 = Convert.ToString(dgvAlmacen.Rows[fill].Cells[3].Value);    //Cantidad

            id = col0;
            cmbProducto.SelectedValue = col1;
            txtCantidad.Text = col3;
            cmbProducto.Enabled = false;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                if (MessageBox.Show(@"¿AGREGAR REGISTRO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    a.InsertarAlmacen(id, Convert.ToInt32(cmbProducto.SelectedValue), Convert.ToInt32(txtCantidad.Text), DateTime.Now.Date);
                    btnLimpiar.PerformClick();
                    btnBuscar.PerformClick();
                    MessageBox.Show(@"REGISTRO AGREGADO", "M E N S A J E D E L S I S T E M A");
                }
            }
        }

        private void cmbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_NoTeclas(cmbProducto, sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_TeclasNumericas(txtCantidad, sender, e);
        }

        private void txtAgregarAlmacen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
