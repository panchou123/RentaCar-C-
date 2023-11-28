
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
            this.components = new System.ComponentModel.Container();
            this.txtAgregarEmp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.grpAgregarEmp = new System.Windows.Forms.GroupBox();
            this.pboxFoto = new System.Windows.Forms.PictureBox();
            this.txtEmpleados = new System.Windows.Forms.TextBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tipBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.tipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tipSalir = new System.Windows.Forms.ToolTip(this.components);
            this.grpAgregarEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoto)).BeginInit();
            this.grpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarEmp
            // 
            this.txtAgregarEmp.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAgregarEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarEmp.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtAgregarEmp.ForeColor = System.Drawing.Color.White;
            this.txtAgregarEmp.Location = new System.Drawing.Point(-1, -1);
            this.txtAgregarEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgregarEmp.Name = "txtAgregarEmp";
            this.txtAgregarEmp.ReadOnly = true;
            this.txtAgregarEmp.Size = new System.Drawing.Size(1199, 44);
            this.txtAgregarEmp.TabIndex = 1;
            this.txtAgregarEmp.Text = "AGREGAR EMPLEADOS";
            this.txtAgregarEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgregarEmp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.Location = new System.Drawing.Point(173, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 34);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Empleado_KeyPress);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.BackColor = System.Drawing.Color.White;
            this.rdbMasculino.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.ForeColor = System.Drawing.Color.Orange;
            this.rdbMasculino.Location = new System.Drawing.Point(184, 111);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(174, 45);
            this.rdbMasculino.TabIndex = 3;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.BackColor = System.Drawing.Color.White;
            this.rdbFemenino.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.ForeColor = System.Drawing.Color.Orange;
            this.rdbFemenino.Location = new System.Drawing.Point(364, 111);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(171, 45);
            this.rdbFemenino.TabIndex = 4;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(173, 190);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 34);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Vendedor",
            "Encargado de Almacen",
            "Administrativo"});
            this.cmbPuesto.Location = new System.Drawing.Point(173, 271);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(200, 36);
            this.cmbPuesto.TabIndex = 9;
            this.cmbPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Empleado_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Orange;
            this.lblNombre.Location = new System.Drawing.Point(-7, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 41);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.White;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Orange;
            this.lblGenero.Location = new System.Drawing.Point(-7, 111);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(116, 41);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Orange;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(-7, 178);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(170, 82);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de \r\nNacimiento";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.White;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.Orange;
            this.lblPuesto.Location = new System.Drawing.Point(-7, 272);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(109, 41);
            this.lblPuesto.TabIndex = 14;
            this.lblPuesto.Text = "Puesto";
            // 
            // grpAgregarEmp
            // 
            this.grpAgregarEmp.BackColor = System.Drawing.Color.White;
            this.grpAgregarEmp.Controls.Add(this.rdbFemenino);
            this.grpAgregarEmp.Controls.Add(this.lblFechaNacimiento);
            this.grpAgregarEmp.Controls.Add(this.dtpFechaNacimiento);
            this.grpAgregarEmp.Controls.Add(this.rdbMasculino);
            this.grpAgregarEmp.Controls.Add(this.lblNombre);
            this.grpAgregarEmp.Controls.Add(this.lblPuesto);
            this.grpAgregarEmp.Controls.Add(this.pboxFoto);
            this.grpAgregarEmp.Controls.Add(this.txtNombre);
            this.grpAgregarEmp.Controls.Add(this.cmbPuesto);
            this.grpAgregarEmp.Controls.Add(this.lblGenero);
            this.grpAgregarEmp.Location = new System.Drawing.Point(38, 52);
            this.grpAgregarEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarEmp.Name = "grpAgregarEmp";
            this.grpAgregarEmp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarEmp.Size = new System.Drawing.Size(933, 344);
            this.grpAgregarEmp.TabIndex = 15;
            this.grpAgregarEmp.TabStop = false;
            // 
            // pboxFoto
            // 
            this.pboxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxFoto.Image = global::WinAppSAP.Properties.Resources.usuario;
            this.pboxFoto.Location = new System.Drawing.Point(672, 76);
            this.pboxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxFoto.Name = "pboxFoto";
            this.pboxFoto.Size = new System.Drawing.Size(200, 200);
            this.pboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFoto.TabIndex = 8;
            this.pboxFoto.TabStop = false;
            this.pboxFoto.Click += new System.EventHandler(this.pboxFoto_Click);
            // 
            // txtEmpleados
            // 
            this.txtEmpleados.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleados.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtEmpleados.ForeColor = System.Drawing.Color.White;
            this.txtEmpleados.Location = new System.Drawing.Point(-1, 417);
            this.txtEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpleados.Name = "txtEmpleados";
            this.txtEmpleados.ReadOnly = true;
            this.txtEmpleados.Size = new System.Drawing.Size(1199, 44);
            this.txtEmpleados.TabIndex = 20;
            this.txtEmpleados.Text = "EMPLEADOS";
            this.txtEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBotones
            // 
            this.grpBotones.BackColor = System.Drawing.Color.White;
            this.grpBotones.Controls.Add(this.btnGuardar);
            this.grpBotones.Controls.Add(this.btnSalir);
            this.grpBotones.Controls.Add(this.btnBuscar);
            this.grpBotones.ForeColor = System.Drawing.Color.White;
            this.grpBotones.Location = new System.Drawing.Point(980, 65);
            this.grpBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBotones.Size = new System.Drawing.Size(179, 297);
            this.grpBotones.TabIndex = 22;
            this.grpBotones.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WinAppSAP.Properties.Resources.disk;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(101, 38);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 58);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::WinAppSAP.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(101, 205);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 58);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::WinAppSAP.Properties.Resources._030_browse;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(101, 123);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 58);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(21, 473);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 29;
            this.dgvEmpleados.Size = new System.Drawing.Size(1153, 188);
            this.dgvEmpleados.TabIndex = 23;
            this.dgvEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleados_MouseClick);
            this.dgvEmpleados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleados_MouseDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::WinAppSAP.Properties.Resources.button_cancel;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(999, 270);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 58);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::WinAppSAP.Properties.Resources.limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(999, 188);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(59, 58);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::WinAppSAP.Properties.Resources._200_add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(999, 103);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 58);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 673);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAgregarEmp);
            this.Controls.Add(this.grpAgregarEmp);
            this.Controls.Add(this.grpBotones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(303, 9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEmpleados";
            this.grpAgregarEmp.ResumeLayout(false);
            this.grpAgregarEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoto)).EndInit();
            this.grpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAgregarEmp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pboxFoto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
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
        private System.Windows.Forms.ToolTip tipAgregar;
        private System.Windows.Forms.ToolTip tipGuardar;
        private System.Windows.Forms.ToolTip tipLimpiar;
        private System.Windows.Forms.ToolTip tipBuscar;
        private System.Windows.Forms.ToolTip tipEliminar;
        private System.Windows.Forms.ToolTip tipSalir;
    }
}