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
    public partial class frmVentas : Form
    {
        Productos P = new Productos();
        Almacen A = new Almacen();
        Clientes C = new Clientes();
        Ventas V = new Ventas();
        Facturas F = new Facturas();
        Validacion n = new Validacion();
        List<Entities.Facturas> traetodo;
        List<Entities.Ventas> traerVentas;
        List<Entities.Almacen> stock;
        List<Entities.Productos> Precio;
        int c = 0;
        double sub = 0;
        int id = 0;
        int fill = 0;
        public frmVentas()
        {
            InitializeComponent();
            tipAgregar.SetToolTip(btnAgregar, "Agregar");
            tipGuardar.SetToolTip(btnGuardar, "Guardar");
            tipLimpiar.SetToolTip(btnLimpiar, "Limpiar");
            tipVenta.SetToolTip(btnVenta, "Realizar Venta");
            tipEliminar.SetToolTip(btnEliminar, "Eliminar");
            tipSalir.SetToolTip(btnSalir, "Salir");
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void cmbCliente_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCliente.DataSource = C.SelectClientes();
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DisplayMember = "Cliente";
        }

        private void cmbProducto_MouseClick(object sender, MouseEventArgs e)
        {
            traerVentas = V.SelectVentas();
            c = traerVentas.Count + 1;
            cmbProducto.DataSource = P.ConsultaAlmacenExistente(c);
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.DisplayMember = "Producto";
            numCantidad.Value = 0;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            sub = 0;
            txtIVA.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            cmbCliente.Text = "";
            cmbProducto.Text = "";
            F.CancelaFacturas();
            buscar();
;        }

        private void lblIVA_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(numCantidad.Value==0 || numCantidad.Text =="" || cmbProducto.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else { 
            decimal pr = 0;
            traerVentas = V.SelectVentas();
            c = traerVentas.Count+1;
            Precio = P.Precio(Convert.ToInt32(cmbProducto.SelectedValue));
            foreach (var ID in Precio)
            {
                pr = ID.Precio;
            }
            F.InsertarFactura(c, Convert.ToInt32(cmbProducto.SelectedValue), Convert.ToInt32(numCantidad.Value), pr * Convert.ToInt32(numCantidad.Value), DateTime.Now.Date);
            limpiarM();
            buscar();
            traetodo = F.SelectFactura(c);
            sub = 0;
            foreach (var ID in traetodo)
            {
                sub += Convert.ToDouble(ID.Total);
            }
            txtSubtotal.Text = Convert.ToString(sub);
            txtIVA.Text = Convert.ToString(sub*.16);
            txtTotal.Text = Convert.ToString(sub * 1.16);
            }
        }

        private void buscar()
        {
            traerVentas = V.SelectVentas();
            c = traerVentas.Count + 1;
            dgvFactura.DataSource = F.SelectFactura(c);

            dgvFactura.Columns["Factura"].Visible = false;
            dgvFactura.Columns["IdProducto"].Visible = false;
            dgvFactura.Columns["Fecha"].Visible = false;

            dgvFactura.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvFactura.Columns["Producto"].Width = 240;
            dgvFactura.Columns["Producto"].ReadOnly = true;

            dgvFactura.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvFactura.Columns["Cantidad"].Width = 200;
            dgvFactura.Columns["Cantidad"].ReadOnly = true;

            dgvFactura.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvFactura.Columns["Total"].Width = 200;
            dgvFactura.Columns["Total"].ReadOnly = true;
        }

        private void limpiarM()
        {

            cmbProducto.Text = "";
            numCantidad.Value = 0;
            cmbProducto.Enabled = true;
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numCantidad.Value == 0 || numCantidad.Text == "" || cmbProducto.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                decimal pr = 0;
                traerVentas = V.SelectVentas();
                c = traerVentas.Count + 1;
                Precio = P.Precio(Convert.ToInt32(cmbProducto.SelectedValue));
                foreach (var ID in Precio)
                {
                    pr = ID.Precio;
                }
                F.InsertarFactura(c, Convert.ToInt32(cmbProducto.SelectedValue), Convert.ToInt32(numCantidad.Value), pr * Convert.ToInt32(numCantidad.Value), DateTime.Now.Date);
                limpiarM();
                buscar();
                traetodo = F.SelectFactura(c);
                sub = 0;
                foreach (var ID in traetodo)
                {
                    sub += Convert.ToDouble(ID.Total);
                }
                txtSubtotal.Text = Convert.ToString(sub);
                txtIVA.Text = Convert.ToString(sub * .16);
                txtTotal.Text = Convert.ToString(sub * 1.16);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            F.EliminaFactura(id);
            limpiarM();
            buscar();
            traetodo = F.SelectFactura(c);
            sub = 0;
            foreach (var ID in traetodo)
            {
                sub += Convert.ToDouble(ID.Total);
            }
            txtSubtotal.Text = Convert.ToString(sub);
            txtIVA.Text = Convert.ToString(sub * .16);
            txtTotal.Text = Convert.ToString(sub * 1.16);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (cmbCliente.Text == "" || txtTotal.Text=="")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                if (MessageBox.Show(@"¿REALIZAR VENTA?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                
                traetodo = F.SelectFactura(c);
                foreach (var ID in traetodo)
                {
                    stock = A.ReduceStock(ID.idProducto, ID.Cantidad);
                }
                V.InsertarVenta(c, Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToDecimal(sub), Convert.ToDecimal(sub * 0.16), Convert.ToDecimal(sub * 1.16), DateTime.Now.Date);
                stock = A.SelectStock(1);
                btnLimpiar.PerformClick();
                MessageBox.Show(@"VENTA REALIZADA CON EXITO", "M E N S A J E D E L S I S T E M A");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            this.Visible = false;
           
            dgvFactura.DataSource = null;
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            stock = A.SelectStock(Convert.ToInt32(cmbProducto.SelectedValue));
            foreach (var ID in stock)
            {
                    numCantidad.Maximum = ID.Cantidad;
            }
        }

        private void dgvFactura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFactura.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvFactura.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvFactura.Rows[fill].Cells[1].Value);
            }
        }

        private void dgvFactura_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFactura.CurrentCell != null)
            {
                cmbProducto.DataSource = P.SelectProductos();
                cmbProducto.ValueMember = "idProducto";
                cmbProducto.DisplayMember = "Producto";
                fill = 0;
                fill = dgvFactura.CurrentCell.RowIndex;
                int col1 = Convert.ToInt32(dgvFactura.Rows[fill].Cells[1].Value);         //idProducto
                decimal col3 = Convert.ToDecimal(dgvFactura.Rows[fill].Cells[3].Value);    //Cantidad

                id = col1;
                cmbProducto.SelectedValue = col1;
                numCantidad.Value = col3;
                cmbProducto.Enabled = false;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_NoTeclas(cmbCliente, sender, e);
        }

        private void cmbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_NoTeclas(cmbProducto, sender, e);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
