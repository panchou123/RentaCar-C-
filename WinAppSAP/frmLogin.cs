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
    public partial class frmLogin : Form
    {
         
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Negocio.Usuarios login = new Negocio.Usuarios();
        List<Entities.Usuarios> traertodo;
        public static Boolean flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
                traertodo = login.UsuarioActivo();
                foreach (var idUsu in traertodo)
                {
                    if ((idUsu.Usuario.TrimEnd().ToUpper() == txtUsuario.Text.TrimEnd().ToUpper()) && (idUsu.Password.TrimEnd().ToUpper() == txtPass.Text.TrimEnd().ToUpper()))
                    {
                    txtUsuario.Text = "";
                    txtPass.Text = "";
                        flag = true;
                        frmMDI newform = new frmMDI();
                        this.Hide();
                        newform.ShowDialog();
                        this.Show();
                    }
                }
                if (!flag){
                    MessageBox.Show(@"Acceso Denegado", "M E N S A J E D E L S I S T E M A");
                    txtUsuario.Text = "";
                    txtPass.Text = "";
                 }
            flag = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
           
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
       
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
              
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
             
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pboxPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
