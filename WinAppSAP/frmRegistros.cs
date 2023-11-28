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
    public partial class frmRegistros : Form
    {
        Ventas V = new Ventas();
        Facturas F = new Facturas();
        int fill = 0;
        int id = 0;
        int col2 = 0;

        public frmRegistros()
        {
            InitializeComponent();
            tipBuscar.SetToolTip(btnBuscar, "Buscar");
            tipEliminar.SetToolTip(btnEliminar, "Eliminar");
            tipSalir.SetToolTip(btnSalir, "Salir");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            dgvVenta.DataSource = null;
            dgvFactura.DataSource = null;
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVenta.DataSource = V.SelectVentas();
            dgvVenta.Columns["idVenta"].Visible = false;
            dgvVenta.Columns["idCliente"].Visible = false;
            dgvVenta.Columns["Factura"].Visible = false;

            dgvVenta.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVenta.Columns["Cliente"].Width = 280;
            dgvVenta.Columns["Cliente"].ReadOnly = true;

            dgvVenta.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVenta.Columns["Subtotal"].Width = 280;
            dgvVenta.Columns["Subtotal"].ReadOnly = true;

            dgvVenta.Columns["IVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVenta.Columns["IVA"].Width = 100;
            dgvVenta.Columns["IVA"].ReadOnly = true;

            dgvVenta.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVenta.Columns["Total"].Width = 180;
            dgvVenta.Columns["Total"].ReadOnly = true;
        }

        private void dgvVenta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvVenta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            col2 = 0;
            if (dgvVenta.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvVenta.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvVenta.Rows[fill].Cells[0].Value);
                col2 = Convert.ToInt32(dgvVenta.Rows[fill].Cells[1].Value);
                btnEliminar.Enabled = true;

                dgvFactura.DataSource = F.SelectFactura(col2);

                dgvFactura.Columns["Factura"].Visible = false;
                dgvFactura.Columns["IdProducto"].Visible = false;

                dgvFactura.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvFactura.Columns["Producto"].Width = 280;
                dgvFactura.Columns["Producto"].ReadOnly = true;

                dgvFactura.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvFactura.Columns["Cantidad"].Width = 280;
                dgvFactura.Columns["Cantidad"].ReadOnly = true;

                dgvFactura.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvFactura.Columns["Total"].Width = 200;
                dgvFactura.Columns["Total"].ReadOnly = true;

                dgvFactura.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvFactura.Columns["Fecha"].Width = 200;
                dgvFactura.Columns["Fecha"].ReadOnly = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"SE BORRARA EL REGISTRO Y TODAS SUS FACTURAS ¿ELIMINAR?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                V.EliminarVenta(id);
                F.CancelaFacturas();
                dgvFactura.DataSource = null;
                btnBuscar.PerformClick();
                MessageBox.Show(@"REGISTRO ELIMINADO", "M E N S A J E D E L S I S T E M A");
            }
        }
    }
}

