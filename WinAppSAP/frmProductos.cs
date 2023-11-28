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
using Entities;

namespace WinAppSAP
{
    public partial class frmProductos : Form
    {
        Validacion n = new Validacion();
        List<Entities.Productos> traertodo;
        Negocio.Productos p = new Negocio.Productos();
        int fill;
        int id;
        string col1 = "";
        public frmProductos()
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
            txtPrecio.Text = "";
            txtProducto.Text = "";
            id = 0;
            fill = 0;
            col1 = "";
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show(@"¿ELIMINAR PRODUCTO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    p.EliminarProducto(id);
                    btnBuscar_Click(sender, e);
                    btnLimpiar_Click(sender, e);
                    MessageBox.Show(@"PRODUCTO ELIMINADO", "M E N S A J E D E L S I S T E M A");
                }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            traertodo = p.SelectProductos();
            foreach (var idEmp in traertodo)
            {
                if ((idEmp.Producto.ToUpper()).Replace(" ", "") == (txtProducto.Text.ToUpper()).Replace(" ", "") && (txtProducto.Text.ToUpper()).Replace(" ", "") != (col1.ToUpper()).Replace(" ", ""))
                {
                    MessageBox.Show(@"ESTE PRODUCTO YA EXISTE", "M E N S A J E D E L S I S T E M A");
                    return;
                }
            }

            if (txtProducto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                    if (MessageBox.Show(@"¿MODIFICAR PRODUCTO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        p.InsertarProducto(id, txtProducto.Text, Convert.ToDecimal(txtPrecio.Text), true, DateTime.Now.Date);
                        btnLimpiar_Click(sender, e);
                        btnBuscar_Click(sender, e);
                        MessageBox.Show(@"PRODUCTO MODIFICADO", "M E N S A J E D E L S I S T E M A");
                    }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = p.SelectProductos();
            dgvProductos.Columns["idProducto"].Visible = false;
            dgvProductos.Columns["Activo"].ReadOnly = true;

            dgvProductos.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.Columns["Producto"].Width = 580;
            dgvProductos.Columns["Producto"].ReadOnly = true;

            dgvProductos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.Columns["Precio"].Width = 200;
            dgvProductos.Columns["Precio"].ReadOnly = true;

            dgvProductos.Columns["Fecha"].HeaderText = "Fecha de Registro";
            dgvProductos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductos.Columns["Fecha"].Width = 250;
            dgvProductos.Columns["Fecha"].ReadOnly = true;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvProductos.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvProductos.Rows[fill].Cells[0].Value);
            }
        }

        private void dgvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos.CurrentCell != null)
            {
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                fill = 0;
                id = 0;
                fill = dgvProductos.CurrentCell.RowIndex;
                int col0 = Convert.ToInt32(dgvProductos.Rows[fill].Cells[0].Value);         //id
                col1 = Convert.ToString(dgvProductos.Rows[fill].Cells[1].Value);            //Producto
                string col2 = Convert.ToString(dgvProductos.Rows[fill].Cells[2].Value);     //Precio

                id = col0;
                txtProducto.Text = col1;
                txtPrecio.Text = col2;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_TeclasNumericas(txtPrecio, sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            this.Visible = false;
            
            dgvProductos.DataSource = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            traertodo = p.SelectProductos();
            foreach (var idEmp in traertodo)
            {
                if ((idEmp.Producto.ToUpper()).Replace(" ", "") == (txtProducto.Text.ToUpper()).Replace(" ", ""))
                {
                    MessageBox.Show(@"ESTE PRODUCTO YA EXISTE", "M E N S A J E D E L S I S T E M A");
                    return;
                }
            }

            if (txtProducto.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                if (MessageBox.Show(@"¿AGREGAR PRODUCTO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    p.InsertarProducto(id, txtProducto.Text, Convert.ToDecimal(txtPrecio.Text), true, DateTime.Now.Date);
                    btnLimpiar.PerformClick();
                    btnBuscar.PerformClick();
                    MessageBox.Show(@"PRODUCTO AGREGADO", "M E N S A J E D E L S I S T E M A");
                }
            }
        }
    }
}
