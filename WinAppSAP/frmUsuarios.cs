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
    public partial class frmUsuarios : Form

    {
        int fill;
        int id;
        Usuarios A = new Usuarios();
        Empleados E = new Empleados();
        Validacion B = new Validacion();
        List<Entities.Usuarios> traertodo;
        string col3 = "";
        public frmUsuarios()
        {
            InitializeComponent();
            tipAgregar.SetToolTip(btnAgregar, "Agregar");
            tipGuardar.SetToolTip(btnGuardar, "Guardar");
            tipLimpiar.SetToolTip(btnLimpiar, "Limpiar");
            tipBuscar.SetToolTip(btnBuscar, "Buscar");
            tipEliminar.SetToolTip(btnEliminar, "Eliminar");
            tipSalir.SetToolTip(btnSalir, "Salir");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            this.Visible=false;
           
            dgvUsuarios.DataSource = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPass.Clear();
            cmbEmpleado.Enabled = true;
            cmbEmpleado.Text="";
            id = 0;
            fill = 0;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            traertodo = A.SelectUsuario();
            foreach (var idUsu in traertodo)
            {
                if ((idUsu.Usuario.ToUpper()).Replace(" ", "") == (txtUsuario.Text.ToUpper()).Replace(" ", ""))
                {
                    MessageBox.Show(@"ESTE USUARIO YA EXISTE", "M E N S A J E D E L S I S T E M A");
                    return;
                }
            }

            if (txtUsuario.Text == "" || cmbEmpleado.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                    if (MessageBox.Show(@"¿AGREGAR USUARIO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        A.InsertarUsuario(id, Convert.ToInt32(cmbEmpleado.SelectedValue), txtUsuario.Text, txtPass.Text, DateTime.Now.Date);
                    btnLimpiar.PerformClick();
                    btnBuscar.PerformClick();
                    MessageBox.Show(@"USUARIO AGREGADO", "M E N S A J E D E L S I S T E M A");

                    }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = A.SelectUsuario();


            dgvUsuarios.Columns["idUsuario"].Visible = false;
            dgvUsuarios.Columns["idEmpleado"].Visible = false;
            dgvUsuarios.Columns["Password"].Visible = false;

            dgvUsuarios.Columns["Empleado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsuarios.Columns["Empleado"].Width = 250;
            dgvUsuarios.Columns["Empleado"].ReadOnly = true;

            dgvUsuarios.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsuarios.Columns["Usuario"].Width = 130;
            dgvUsuarios.Columns["Usuario"].ReadOnly = true;

            dgvUsuarios.Columns["Fecha"].HeaderText = "Fecha de Registro";
            dgvUsuarios.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsuarios.Columns["Fecha"].Width = 140;
            dgvUsuarios.Columns["Fecha"].ReadOnly = true;


        }

        private void cmbEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            cmbEmpleado.DataSource = E.EmpleadoNoUsuario();
            cmbEmpleado.ValueMember = "idEmpleado";
            cmbEmpleado.DisplayMember = "Nombre";
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        { 
            if (dgvUsuarios.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvUsuarios.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvUsuarios.Rows[fill].Cells[0].Value);
            }

            
        }

        private void dgvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {   

            if (dgvUsuarios.CurrentCell != null)
            {
                cmbEmpleado.DataSource = E.SelectEmpledos();
                cmbEmpleado.ValueMember = "idEmpleado";
                cmbEmpleado.DisplayMember = "Nombre";
                fill = 0;
                id = 0;
                fill = dgvUsuarios.CurrentCell.RowIndex;
            
            int col0 = Convert.ToInt32(dgvUsuarios.Rows[fill].Cells[0].Value);         //id
            int col1 = Convert.ToInt32(dgvUsuarios.Rows[fill].Cells[1].Value);         //idEmpleado
            col3 = Convert.ToString(dgvUsuarios.Rows[fill].Cells[3].Value);            //Usuario

            id = col0;
            cmbEmpleado.SelectedValue = col1;
            txtUsuario.Text = col3;
            cmbEmpleado.Enabled = false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            traertodo = A.SelectUsuario();
            foreach (var idUsu in traertodo)
            {
                if ((idUsu.Usuario.ToUpper()).Replace(" ", "") == (txtUsuario.Text.ToUpper()).Replace(" ", "") && (txtUsuario.Text.ToUpper()).Replace(" ", "") != (col3.ToUpper()).Replace(" ", ""))
                {
                    MessageBox.Show(@"ESTE USUARIO YA EXISTE", "M E N S A J E D E L S I S T E M A");
                    return;
                }
            }

            if (txtUsuario.Text == "" || cmbEmpleado.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                if (MessageBox.Show(@"¿MODIFICAR USUARIO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    A.InsertarUsuario(id, Convert.ToInt32(cmbEmpleado.SelectedValue), txtUsuario.Text, txtPass.Text, DateTime.Now.Date);
                    btnLimpiar.PerformClick();
                    btnBuscar.PerformClick();
                    MessageBox.Show(@"USUARIO MODIFICADO", "M E N S A J E D E L S I S T E M A");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show(@"¿ELIMINAR USUARIO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    A.EliminarUsuario(id);
                    btnLimpiar_Click(sender, e);
                    btnBuscar_Click(sender, e);
                    MessageBox.Show(@"USUARIO ELIMINADO", "M E N S A J E D E L S I S T E M A");
                }

        }

        private void cmbEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            B.neg_NoTeclas(cmbEmpleado, sender, e);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
