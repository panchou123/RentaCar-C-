
namespace WinAppSAP
{
    partial class frmClientes
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
            this.grpAgregarClientes = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAgregarCliente = new System.Windows.Forms.TextBox();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tipSalir = new System.Windows.Forms.ToolTip(this.components);
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tipBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.tipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.grpAgregarClientes.SuspendLayout();
            this.grpBotones.SuspendLayout();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarClientes
            // 
            this.grpAgregarClientes.BackColor = System.Drawing.Color.White;
            this.grpAgregarClientes.Controls.Add(this.txtCorreo);
            this.grpAgregarClientes.Controls.Add(this.txtCliente);
            this.grpAgregarClientes.Controls.Add(this.lblCorreo);
            this.grpAgregarClientes.Controls.Add(this.lblCliente);
            this.grpAgregarClientes.Controls.Add(this.lblTelefono);
            this.grpAgregarClientes.Controls.Add(this.lblDireccion);
            this.grpAgregarClientes.Controls.Add(this.txtTelefono);
            this.grpAgregarClientes.Controls.Add(this.txtDireccion);
            this.grpAgregarClientes.Controls.Add(this.grpBotones);
            this.grpAgregarClientes.Controls.Add(this.txtAgregarCliente);
            this.grpAgregarClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpAgregarClientes.ForeColor = System.Drawing.Color.Black;
            this.grpAgregarClientes.Location = new System.Drawing.Point(2, 2);
            this.grpAgregarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarClientes.Name = "grpAgregarClientes";
            this.grpAgregarClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarClientes.Size = new System.Drawing.Size(569, 649);
            this.grpAgregarClientes.TabIndex = 19;
            this.grpAgregarClientes.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCorreo.Location = new System.Drawing.Point(180, 325);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 34);
            this.txtCorreo.TabIndex = 29;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCliente.Location = new System.Drawing.Point(180, 90);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(271, 34);
            this.txtCliente.TabIndex = 28;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cliente_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.White;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Orange;
            this.lblCorreo.Location = new System.Drawing.Point(34, 324);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(109, 41);
            this.lblCorreo.TabIndex = 27;
            this.lblCorreo.Text = "Correo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Orange;
            this.lblCliente.Location = new System.Drawing.Point(31, 90);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(110, 41);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.White;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Orange;
            this.lblTelefono.Location = new System.Drawing.Point(31, 168);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(132, 41);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Orange;
            this.lblDireccion.Location = new System.Drawing.Point(31, 245);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(142, 41);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(180, 168);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(271, 34);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(180, 246);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(271, 34);
            this.txtDireccion.TabIndex = 4;
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
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.BackgroundImage = global::WinAppSAP.Properties.Resources.disk;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(46, 114);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 59);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAgregarCliente
            // 
            this.txtAgregarCliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAgregarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.txtAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.txtAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgregarCliente.Name = "txtAgregarCliente";
            this.txtAgregarCliente.ReadOnly = true;
            this.txtAgregarCliente.Size = new System.Drawing.Size(569, 44);
            this.txtAgregarCliente.TabIndex = 2;
            this.txtAgregarCliente.Text = "AGREGAR CLIENTE";
            this.txtAgregarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpClientes
            // 
            this.grpClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpClientes.Controls.Add(this.txtClientes);
            this.grpClientes.Controls.Add(this.dgvClientes);
            this.grpClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpClientes.Location = new System.Drawing.Point(570, 2);
            this.grpClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClientes.Size = new System.Drawing.Size(631, 649);
            this.grpClientes.TabIndex = 20;
            this.grpClientes.TabStop = false;
            // 
            // txtClientes
            // 
            this.txtClientes.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientes.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtClientes.ForeColor = System.Drawing.Color.White;
            this.txtClientes.Location = new System.Drawing.Point(0, 0);
            this.txtClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.ReadOnly = true;
            this.txtClientes.Size = new System.Drawing.Size(631, 44);
            this.txtClientes.TabIndex = 21;
            this.txtClientes.Text = "CLIENTES";
            this.txtClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 48);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 29;
            this.dgvClientes.Size = new System.Drawing.Size(614, 592);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseClick);
            this.dgvClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseDoubleClick);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.grpAgregarClientes);
            this.Controls.Add(this.grpClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(309, 9);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmClientes";
            this.grpAgregarClientes.ResumeLayout(false);
            this.grpAgregarClientes.PerformLayout();
            this.grpBotones.ResumeLayout(false);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAgregarCliente;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ToolTip tipSalir;
        private System.Windows.Forms.ToolTip tipAgregar;
        private System.Windows.Forms.ToolTip tipGuardar;
        private System.Windows.Forms.ToolTip tipLimpiar;
        private System.Windows.Forms.ToolTip tipBuscar;
        private System.Windows.Forms.ToolTip tipEliminar;
    }
}