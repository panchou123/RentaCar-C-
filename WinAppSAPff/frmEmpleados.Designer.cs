
namespace WinAppSAP
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAgregarEmp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pboxFoto = new System.Windows.Forms.PictureBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.grpAgregarEmp = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEmpleados = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFechaReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoto)).BeginInit();
            this.grpAgregarEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarEmp
            // 
            this.txtAgregarEmp.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtAgregarEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarEmp.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAgregarEmp.ForeColor = System.Drawing.Color.White;
            this.txtAgregarEmp.Location = new System.Drawing.Point(-1, -1);
            this.txtAgregarEmp.Name = "txtAgregarEmp";
            this.txtAgregarEmp.Size = new System.Drawing.Size(1199, 44);
            this.txtAgregarEmp.TabIndex = 1;
            this.txtAgregarEmp.Text = "AGREGAR EMPLEADOS";
            this.txtAgregarEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgregarEmp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(180, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 34);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Empleado_KeyPress);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbMasculino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMasculino.ForeColor = System.Drawing.Color.White;
            this.rdbMasculino.Location = new System.Drawing.Point(142, 98);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(122, 32);
            this.rdbMasculino.TabIndex = 3;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbFemenino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFemenino.ForeColor = System.Drawing.Color.White;
            this.rdbFemenino.Location = new System.Drawing.Point(295, 98);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(119, 32);
            this.rdbFemenino.TabIndex = 4;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = false;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(238, 204);
            this.dtpFechaRegistro.MinDate = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(222, 34);
            this.dtpFechaRegistro.TabIndex = 5;
            this.dtpFechaRegistro.Value = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(238, 149);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(222, 34);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::WinAppSAP.Properties.Resources._200_add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(999, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 58);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pboxFoto
            // 
            this.pboxFoto.Image = global::WinAppSAP.Properties.Resources.usuario;
            this.pboxFoto.Location = new System.Drawing.Point(719, 84);
            this.pboxFoto.Name = "pboxFoto";
            this.pboxFoto.Size = new System.Drawing.Size(200, 200);
            this.pboxFoto.TabIndex = 8;
            this.pboxFoto.TabStop = false;
            this.pboxFoto.Click += new System.EventHandler(this.pboxFoto_Click);
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Vendedor",
            "Encargado de Almacen",
            "Administrativo"});
            this.cmbPuesto.Location = new System.Drawing.Point(719, 326);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(200, 36);
            this.cmbPuesto.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(59, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 28);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(59, 150);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(76, 28);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 154);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(195, 28);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.lblFechaRegistro.Location = new System.Drawing.Point(20, 204);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(166, 28);
            this.lblFechaRegistro.TabIndex = 13;
            this.lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(629, 329);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(71, 28);
            this.lblPuesto.TabIndex = 14;
            this.lblPuesto.Text = "Puesto";
            // 
            // grpAgregarEmp
            // 
            this.grpAgregarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpAgregarEmp.Controls.Add(this.rdbFemenino);
            this.grpAgregarEmp.Controls.Add(this.lblFechaNacimiento);
            this.grpAgregarEmp.Controls.Add(this.dtpFechaNacimiento);
            this.grpAgregarEmp.Controls.Add(this.lblFechaRegistro);
            this.grpAgregarEmp.Controls.Add(this.dtpFechaRegistro);
            this.grpAgregarEmp.Controls.Add(this.rdbMasculino);
            this.grpAgregarEmp.Location = new System.Drawing.Point(38, 52);
            this.grpAgregarEmp.Name = "grpAgregarEmp";
            this.grpAgregarEmp.Size = new System.Drawing.Size(933, 344);
            this.grpAgregarEmp.TabIndex = 15;
            this.grpAgregarEmp.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::WinAppSAP.Properties.Resources.limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(999, 188);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(59, 58);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::WinAppSAP.Properties.Resources._030_browse;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(1081, 188);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 58);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::WinAppSAP.Properties.Resources.button_cancel;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(999, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 58);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WinAppSAP.Properties.Resources.disk;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(1081, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 58);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtEmpleados
            // 
            this.txtEmpleados.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleados.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpleados.ForeColor = System.Drawing.Color.White;
            this.txtEmpleados.Location = new System.Drawing.Point(-1, 417);
            this.txtEmpleados.Name = "txtEmpleados";
            this.txtEmpleados.Size = new System.Drawing.Size(1199, 44);
            this.txtEmpleados.TabIndex = 20;
            this.txtEmpleados.Text = "EMPLEADOS";
            this.txtEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::WinAppSAP.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(1081, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 58);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpBotones
            // 
            this.grpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpBotones.Location = new System.Drawing.Point(980, 65);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(179, 297);
            this.grpBotones.TabIndex = 22;
            this.grpBotones.TabStop = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcNombre,
            this.dgcGenero,
            this.dgcFechaNac,
            this.dgcPuesto,
            this.dgcFechaReg});
            this.dgvEmpleados.Location = new System.Drawing.Point(21, 473);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 29;
            this.dgvEmpleados.Size = new System.Drawing.Size(1153, 188);
            this.dgvEmpleados.TabIndex = 23;
            // 
            // dgcNombre
            // 
            this.dgcNombre.HeaderText = "Nombre";
            this.dgcNombre.MinimumWidth = 6;
            this.dgcNombre.Name = "dgcNombre";
            this.dgcNombre.Width = 400;
            // 
            // dgcGenero
            // 
            this.dgcGenero.HeaderText = "Genero";
            this.dgcGenero.MinimumWidth = 6;
            this.dgcGenero.Name = "dgcGenero";
            this.dgcGenero.Width = 150;
            // 
            // dgcFechaNac
            // 
            this.dgcFechaNac.HeaderText = "Fecha de Nacimiento";
            this.dgcFechaNac.MinimumWidth = 6;
            this.dgcFechaNac.Name = "dgcFechaNac";
            this.dgcFechaNac.Width = 200;
            // 
            // dgcPuesto
            // 
            this.dgcPuesto.HeaderText = "Puesto";
            this.dgcPuesto.MinimumWidth = 6;
            this.dgcPuesto.Name = "dgcPuesto";
            this.dgcPuesto.Width = 150;
            // 
            // dgcFechaReg
            // 
            this.dgcFechaReg.HeaderText = "Fecha de Registro";
            this.dgcFechaReg.MinimumWidth = 6;
            this.dgcFechaReg.Name = "dgcFechaReg";
            this.dgcFechaReg.Width = 200;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1198, 673);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtEmpleados);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.pboxFoto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtAgregarEmp);
            this.Controls.Add(this.grpAgregarEmp);
            this.Controls.Add(this.grpBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(303, 9);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoto)).EndInit();
            this.grpAgregarEmp.ResumeLayout(false);
            this.grpAgregarEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAgregarEmp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pboxFoto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.GroupBox grpAgregarEmp;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFechaReg;
    }
}