
namespace WinAppSAP
{
    partial class frmUsuarios
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
            this.txtAgregarUser = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.grpAgregarUser = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.grpUserEmpleado = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAgregarUser.SuspendLayout();
            this.grpUserEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarUser
            // 
            this.txtAgregarUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtAgregarUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarUser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAgregarUser.ForeColor = System.Drawing.Color.White;
            this.txtAgregarUser.Location = new System.Drawing.Point(0, 0);
            this.txtAgregarUser.Name = "txtAgregarUser";
            this.txtAgregarUser.Size = new System.Drawing.Size(569, 44);
            this.txtAgregarUser.TabIndex = 2;
            this.txtAgregarUser.Text = "AGREGAR USUARIO";
            this.txtAgregarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(235, 149);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 34);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(235, 226);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(237, 34);
            this.txtPass.TabIndex = 4;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(236, 308);
            this.dtpFechaRegistro.MinDate = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(237, 34);
            this.dtpFechaRegistro.TabIndex = 6;
            this.dtpFechaRegistro.Value = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(107, 152);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 28);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(107, 229);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(110, 28);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Contraseña";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblIdEmpleado.Location = new System.Drawing.Point(107, 80);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(100, 28);
            this.lblIdEmpleado.TabIndex = 13;
            this.lblIdEmpleado.Text = "Empleado";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.lblFechaRegistro.Location = new System.Drawing.Point(64, 308);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(166, 28);
            this.lblFechaRegistro.TabIndex = 14;
            this.lblFechaRegistro.Text = "Fecha de Registro";
            this.lblFechaRegistro.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpAgregarUser
            // 
            this.grpAgregarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpAgregarUser.Controls.Add(this.comboBox1);
            this.grpAgregarUser.Controls.Add(this.btnSalir);
            this.grpAgregarUser.Controls.Add(this.lblIdEmpleado);
            this.grpAgregarUser.Controls.Add(this.lblUsuario);
            this.grpAgregarUser.Controls.Add(this.lblPass);
            this.grpAgregarUser.Controls.Add(this.btnEliminar);
            this.grpAgregarUser.Controls.Add(this.txtUsuario);
            this.grpAgregarUser.Controls.Add(this.btnBuscar);
            this.grpAgregarUser.Controls.Add(this.btnLimpiar);
            this.grpAgregarUser.Controls.Add(this.txtPass);
            this.grpAgregarUser.Controls.Add(this.btnGuardar);
            this.grpAgregarUser.Controls.Add(this.btnAgregar);
            this.grpAgregarUser.Controls.Add(this.grpBotones);
            this.grpAgregarUser.Controls.Add(this.txtAgregarUser);
            this.grpAgregarUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpAgregarUser.Location = new System.Drawing.Point(1, 2);
            this.grpAgregarUser.Name = "grpAgregarUser";
            this.grpAgregarUser.Size = new System.Drawing.Size(569, 649);
            this.grpAgregarUser.TabIndex = 15;
            this.grpAgregarUser.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 36);
            this.comboBox1.TabIndex = 26;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::WinAppSAP.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(346, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 58);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::WinAppSAP.Properties.Resources.button_cancel;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(346, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 58);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::WinAppSAP.Properties.Resources._030_browse;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(235, 530);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 58);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::WinAppSAP.Properties.Resources.limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(235, 437);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(59, 58);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WinAppSAP.Properties.Resources.disk;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(126, 530);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 58);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::WinAppSAP.Properties.Resources._200_add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(126, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 58);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpBotones
            // 
            this.grpBotones.Location = new System.Drawing.Point(81, 412);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(370, 189);
            this.grpBotones.TabIndex = 25;
            this.grpBotones.TabStop = false;
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarios.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuarios.ForeColor = System.Drawing.Color.White;
            this.txtUsuarios.Location = new System.Drawing.Point(569, 2);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(631, 44);
            this.txtUsuarios.TabIndex = 16;
            this.txtUsuarios.Text = "USUARIOS";
            this.txtUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpUserEmpleado
            // 
            this.grpUserEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpUserEmpleado.Controls.Add(this.dataGridView1);
            this.grpUserEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpUserEmpleado.Location = new System.Drawing.Point(569, 2);
            this.grpUserEmpleado.Name = "grpUserEmpleado";
            this.grpUserEmpleado.Size = new System.Drawing.Size(631, 649);
            this.grpUserEmpleado.TabIndex = 18;
            this.grpUserEmpleado.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEmpleado,
            this.dgvUsuario,
            this.dgvPass,
            this.dgvFecha});
            this.dataGridView1.Location = new System.Drawing.Point(42, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(554, 592);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.HeaderText = "Empleado";
            this.dgvEmpleado.MinimumWidth = 6;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Width = 125;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.HeaderText = "Usuario";
            this.dgvUsuario.MinimumWidth = 6;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Width = 125;
            // 
            // dgvPass
            // 
            this.dgvPass.HeaderText = "Contraseña";
            this.dgvPass.MinimumWidth = 6;
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.Width = 125;
            // 
            // dgvFecha
            // 
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.MinimumWidth = 6;
            this.dgvFecha.Name = "dgvFecha";
            this.dgvFecha.Width = 125;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.grpAgregarUser);
            this.Controls.Add(this.grpUserEmpleado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(303, 9);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.grpAgregarUser.ResumeLayout(false);
            this.grpAgregarUser.PerformLayout();
            this.grpUserEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAgregarUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.GroupBox grpAgregarUser;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.GroupBox grpUserEmpleado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
    }
}