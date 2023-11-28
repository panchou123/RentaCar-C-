
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
            this.components = new System.ComponentModel.Container();
            this.txtAgregarUser = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.grpAgregarUser = new System.Windows.Forms.GroupBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.grpUserEmpleado = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tipBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.tipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tipSalir = new System.Windows.Forms.ToolTip(this.components);
            this.grpAgregarUser.SuspendLayout();
            this.grpBotones.SuspendLayout();
            this.grpUserEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarUser
            // 
            this.txtAgregarUser.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAgregarUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarUser.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtAgregarUser.ForeColor = System.Drawing.Color.White;
            this.txtAgregarUser.Location = new System.Drawing.Point(0, 0);
            this.txtAgregarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgregarUser.Name = "txtAgregarUser";
            this.txtAgregarUser.ReadOnly = true;
            this.txtAgregarUser.Size = new System.Drawing.Size(569, 44);
            this.txtAgregarUser.TabIndex = 2;
            this.txtAgregarUser.Text = "AGREGAR USUARIO";
            this.txtAgregarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(202, 199);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 34);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.Location = new System.Drawing.Point(202, 276);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(237, 34);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Orange;
            this.lblUsuario.Location = new System.Drawing.Point(21, 191);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(119, 41);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.White;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Orange;
            this.lblPass.Location = new System.Drawing.Point(21, 268);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(168, 41);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Contraseña";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.BackColor = System.Drawing.Color.White;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.Orange;
            this.lblIdEmpleado.Location = new System.Drawing.Point(23, 128);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(151, 41);
            this.lblIdEmpleado.TabIndex = 13;
            this.lblIdEmpleado.Text = "Empleado";
            // 
            // grpAgregarUser
            // 
            this.grpAgregarUser.BackColor = System.Drawing.Color.White;
            this.grpAgregarUser.Controls.Add(this.cmbEmpleado);
            this.grpAgregarUser.Controls.Add(this.lblIdEmpleado);
            this.grpAgregarUser.Controls.Add(this.lblUsuario);
            this.grpAgregarUser.Controls.Add(this.lblPass);
            this.grpAgregarUser.Controls.Add(this.txtUsuario);
            this.grpAgregarUser.Controls.Add(this.txtPass);
            this.grpAgregarUser.Controls.Add(this.grpBotones);
            this.grpAgregarUser.Controls.Add(this.txtAgregarUser);
            this.grpAgregarUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpAgregarUser.ForeColor = System.Drawing.Color.Black;
            this.grpAgregarUser.Location = new System.Drawing.Point(1, 2);
            this.grpAgregarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarUser.Name = "grpAgregarUser";
            this.grpAgregarUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarUser.Size = new System.Drawing.Size(569, 649);
            this.grpAgregarUser.TabIndex = 15;
            this.grpAgregarUser.TabStop = false;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(201, 128);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(237, 36);
            this.cmbEmpleado.TabIndex = 26;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            this.cmbEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmpleado_KeyPress);
            this.cmbEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbEmpleado_MouseClick);
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnBuscar);
            this.grpBotones.Controls.Add(this.btnSalir);
            this.grpBotones.Controls.Add(this.btnLimpiar);
            this.grpBotones.Controls.Add(this.btnEliminar);
            this.grpBotones.Controls.Add(this.btnAgregar);
            this.grpBotones.Controls.Add(this.btnGuardar);
            this.grpBotones.Location = new System.Drawing.Point(81, 412);
            this.grpBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBotones.Size = new System.Drawing.Size(370, 189);
            this.grpBotones.TabIndex = 25;
            this.grpBotones.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::WinAppSAP.Properties.Resources._030_browse;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(154, 115);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 58);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::WinAppSAP.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(265, 115);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 58);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::WinAppSAP.Properties.Resources.limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(154, 24);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(59, 58);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::WinAppSAP.Properties.Resources.button_cancel;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(265, 24);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 58);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::WinAppSAP.Properties.Resources._200_add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(46, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 58);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WinAppSAP.Properties.Resources.disk;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(46, 114);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 59);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarios.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtUsuarios.ForeColor = System.Drawing.Color.White;
            this.txtUsuarios.Location = new System.Drawing.Point(569, 2);
            this.txtUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.ReadOnly = true;
            this.txtUsuarios.Size = new System.Drawing.Size(631, 44);
            this.txtUsuarios.TabIndex = 16;
            this.txtUsuarios.Text = "USUARIOS";
            this.txtUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpUserEmpleado
            // 
            this.grpUserEmpleado.BackColor = System.Drawing.Color.White;
            this.grpUserEmpleado.Controls.Add(this.dgvUsuarios);
            this.grpUserEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpUserEmpleado.Location = new System.Drawing.Point(569, 2);
            this.grpUserEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserEmpleado.Name = "grpUserEmpleado";
            this.grpUserEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserEmpleado.Size = new System.Drawing.Size(631, 649);
            this.grpUserEmpleado.TabIndex = 18;
            this.grpUserEmpleado.TabStop = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(42, 50);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 29;
            this.dgvUsuarios.Size = new System.Drawing.Size(554, 592);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseClick);
            this.dgvUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseDoubleClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.grpAgregarUser);
            this.Controls.Add(this.grpUserEmpleado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(303, 9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUsuarios";
            this.grpAgregarUser.ResumeLayout(false);
            this.grpAgregarUser.PerformLayout();
            this.grpBotones.ResumeLayout(false);
            this.grpUserEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAgregarUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblIdEmpleado;
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
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ToolTip tipAgregar;
        private System.Windows.Forms.ToolTip tipGuardar;
        private System.Windows.Forms.ToolTip tipLimpiar;
        private System.Windows.Forms.ToolTip tipBuscar;
        private System.Windows.Forms.ToolTip tipEliminar;
        private System.Windows.Forms.ToolTip tipSalir;
    }
}