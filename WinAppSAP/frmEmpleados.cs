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
    public partial class frmEmpleados : Form
    {
        int fill;
        int id;
        string col1="";
        Validacion n = new Validacion();
        Negocio.Empleados E = new Negocio.Empleados();
        List<Entities.Empleados> traertodo;
        public frmEmpleados()
        {
            InitializeComponent();
            tipAgregar.SetToolTip(btnAgregar, "Agregar");
            tipGuardar.SetToolTip(btnGuardar, "Guardar");
            tipLimpiar.SetToolTip(btnLimpiar, "Limpiar");
            tipBuscar.SetToolTip(btnBuscar, "Buscar");
            tipEliminar.SetToolTip(btnEliminar, "Eliminar");
            tipSalir.SetToolTip(btnSalir, "Salir");
            dtpFechaNacimiento.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show(@"¿ELIMINAR EMPLEADO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    E.EliminarEmpledos(id);
                    btnBuscar.PerformClick();
                    btnLimpiar.PerformClick();
                    MessageBox.Show(@"EMPLEADO ELIMINADO", "M E N S A J E D E L S I S T E M A");
                }
 
        }
       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            pboxFoto.Image = Properties.Resources.usuario;
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
            cmbPuesto.Text = "";
            dtpFechaNacimiento.Text = "";
            id = 0;
            fill = 0;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        string Path;
        private void pboxFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "image files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pboxFoto.Image = new Bitmap(dlg.FileName);
                    Path = dlg.FileName;
                }
            }
        }
        private void txt_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        { 
            n.neg_TeclasAlfabeticas(txtNombre, sender, e);
        }

        private void cmb_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            n.neg_NoTeclas(cmbPuesto, sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            this.Visible = false;
            
            dgvEmpleados.DataSource=null;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = E.SelectEmpledos();
            dgvEmpleados.Columns["idEmpleado"].Visible = false;
            dgvEmpleados.Columns["Foto"].Visible = false;
            dgvEmpleados.Columns["Activo"].ReadOnly = true;

            dgvEmpleados.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmpleados.Columns["Nombre"].Width = 480;
            dgvEmpleados.Columns["Nombre"].ReadOnly = true;

            dgvEmpleados.Columns["Genero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmpleados.Columns["Genero"].Width = 100;
            dgvEmpleados.Columns["Genero"].ReadOnly = true;

            dgvEmpleados.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvEmpleados.Columns["FechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmpleados.Columns["FechaNacimiento"].Width = 150;
            dgvEmpleados.Columns["FechaNacimiento"].ReadOnly = true;

            dgvEmpleados.Columns["FechaRegistro"].HeaderText = "Fecha de Registro";
            dgvEmpleados.Columns["FechaRegistro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmpleados.Columns["FechaRegistro"].Width = 150;
            dgvEmpleados.Columns["FechaRegistro"].ReadOnly = true;

            dgvEmpleados.Columns["Puesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEmpleados.Columns["Puesto"].Width = 120;
            dgvEmpleados.Columns["Puesto"].ReadOnly = true;
        }

        private void dgvEmpleados_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEmpleados.CurrentCell != null)
            {
                fill = 0;
                id = 0;
                fill = dgvEmpleados.CurrentCell.RowIndex;
                id = Convert.ToInt32(dgvEmpleados.Rows[fill].Cells[0].Value);
            }
        }

        private void dgvEmpleados_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEmpleados.CurrentCell != null)
            {
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                pboxFoto.Image = null;
                fill = 0;
                id = 0;
                fill = dgvEmpleados.CurrentCell.RowIndex;
                int col0 = Convert.ToInt32(dgvEmpleados.Rows[fill].Cells[0].Value);         //id
                col1 = Convert.ToString(dgvEmpleados.Rows[fill].Cells[1].Value);     //Nombre
                string col2 = Convert.ToString(dgvEmpleados.Rows[fill].Cells[2].Value);     //Genero
                Path = Convert.ToString(dgvEmpleados.Rows[fill].Cells[3].Value);     //Foto
                string col4 = Convert.ToString(dgvEmpleados.Rows[fill].Cells[4].Value);     //Nacimiento
                string col5 = Convert.ToString(dgvEmpleados.Rows[fill].Cells[5].Value);     //Puesto

                id = col0;
                txtNombre.Text = col1;
                if (col2 == "Masculino")
                {
                    rdbMasculino.Checked = true;
                }
                else
                {
                    rdbFemenino.Checked = true;
                }
                dtpFechaNacimiento.Text = col4;
                cmbPuesto.Text = col5;
                if (Path != "")
                {
                    pboxFoto.Image = Image.FromFile(Path);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string genero;
            traertodo = E.SelectEmpledos();
            foreach (var idEmp in traertodo)
            {
                if((idEmp.Nombre.ToUpper()).Replace(" ","")==(txtNombre.Text.ToUpper()).Replace(" ","") && (txtNombre.Text.ToUpper()).Replace(" ", "") != (col1.ToUpper()).Replace(" ",""))
                {
                    if (MessageBox.Show(@"YA EXISTE UN EMPELADO CON ESTE NOMBRE ¿MODIFICAR?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if ((txtNombre.Text == "" || cmbPuesto.Text == "" || dtpFechaNacimiento.Text=="" || (!rdbFemenino.Checked && !rdbMasculino.Checked)))
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else {
                    if (MessageBox.Show(@"¿MODIFICAR EMPLEADO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (rdbMasculino.Checked)
                        {
                            genero = "Masculino";
                        }
                        else
                        {
                            genero = "Femenino";
                        }
                        E.AgregarEmpledos(id, txtNombre.Text, genero, Path, cmbPuesto.Text, true, DateTime.Now.Date, dtpFechaNacimiento.Value.Date);
                        btnBuscar.PerformClick();
                        btnLimpiar.PerformClick();
                        MessageBox.Show(@"EMPLEADO MODIFICADO", "M E N S A J E D E L S I S T E M A");
                    }
                }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string genero;
            traertodo = E.SelectEmpledos();
            foreach (var idEmp in traertodo)
            {
                if ((idEmp.Nombre.ToUpper()).Replace(" ", "") == (txtNombre.Text.ToUpper()).Replace(" ", ""))
                {
                    if (MessageBox.Show(@"YA EXISTE UN EMPELADO CON ESTE NOMBRE ¿AGREGAR?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if ((txtNombre.Text == "" || cmbPuesto.Text == "" || dtpFechaNacimiento.Text == "" || (!rdbFemenino.Checked && !rdbMasculino.Checked)))
            {
                MessageBox.Show(@"FALTAN DATOS", "M E N S A J E D E L S I S T E M A");
            }
            else
            {
                if (MessageBox.Show(@"¿AGREGAR EMPLEADO?", "M E N S A J E D E L S I S T E M A", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (rdbMasculino.Checked)
                    {
                        genero = "Masculino";
                    }
                    else
                    {
                        genero = "Femenino";
                    }
                    E.AgregarEmpledos(id, txtNombre.Text, genero, Path, cmbPuesto.Text, true, DateTime.Now.Date, dtpFechaNacimiento.Value.Date);
                    btnBuscar.PerformClick();
                    btnLimpiar.PerformClick();
                    MessageBox.Show(@"EMPLEADO AGREGADO", "M E N S A J E D E L S I S T E M A");
                }
            }
        }
    }
    }
