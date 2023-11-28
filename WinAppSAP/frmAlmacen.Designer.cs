
namespace WinAppSAP
{
    partial class frmAlmacen
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
            this.grpAgregarAlmacen = new System.Windows.Forms.GroupBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAgregarAlmacen = new System.Windows.Forms.TextBox();
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tipBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.tipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tipSalir = new System.Windows.Forms.ToolTip(this.components);
            this.grpAgregarAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.grpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgregarAlmacen
            // 
            this.grpAgregarAlmacen.BackColor = System.Drawing.Color.White;
            this.grpAgregarAlmacen.Controls.Add(this.cmbProducto);
            this.grpAgregarAlmacen.Controls.Add(this.txtAlmacen);
            this.grpAgregarAlmacen.Controls.Add(this.lblProducto);
            this.grpAgregarAlmacen.Controls.Add(this.dgvAlmacen);
            this.grpAgregarAlmacen.Controls.Add(this.lblCantidad);
            this.grpAgregarAlmacen.Controls.Add(this.txtCantidad);
            this.grpAgregarAlmacen.Controls.Add(this.grpBotones);
            this.grpAgregarAlmacen.Controls.Add(this.txtAgregarAlmacen);
            this.grpAgregarAlmacen.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpAgregarAlmacen.Location = new System.Drawing.Point(1, 2);
            this.grpAgregarAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarAlmacen.Name = "grpAgregarAlmacen";
            this.grpAgregarAlmacen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarAlmacen.Size = new System.Drawing.Size(1201, 649);
            this.grpAgregarAlmacen.TabIndex = 17;
            this.grpAgregarAlmacen.TabStop = false;
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(178, 72);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(425, 36);
            this.cmbProducto.TabIndex = 27;
            this.cmbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProducto_KeyPress);
            this.cmbProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbProducto_MouseClick);
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlmacen.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtAlmacen.ForeColor = System.Drawing.Color.White;
            this.txtAlmacen.Location = new System.Drawing.Point(-1, 251);
            this.txtAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.ReadOnly = true;
            this.txtAlmacen.Size = new System.Drawing.Size(1203, 44);
            this.txtAlmacen.TabIndex = 17;
            this.txtAlmacen.Text = "ALMACEN";
            this.txtAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Orange;
            this.lblProducto.Location = new System.Drawing.Point(32, 72);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(140, 41);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(6, 299);
            this.dgvAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.RowHeadersWidth = 51;
            this.dgvAlmacen.RowTemplate.Height = 29;
            this.dgvAlmacen.Size = new System.Drawing.Size(1189, 341);
            this.dgvAlmacen.TabIndex = 0;
            this.dgvAlmacen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlmacen_MouseClick);
            this.dgvAlmacen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlmacen_MouseDoubleClick);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Orange;
            this.lblCantidad.Location = new System.Drawing.Point(32, 163);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(137, 41);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(178, 160);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(425, 34);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnBuscar);
            this.grpBotones.Controls.Add(this.btnSalir);
            this.grpBotones.Controls.Add(this.btnLimpiar);
            this.grpBotones.Controls.Add(this.btnEliminar);
            this.grpBotones.Controls.Add(this.btnAgregar);
            this.grpBotones.Controls.Add(this.btnGuardar);
            this.grpBotones.Location = new System.Drawing.Point(731, 48);
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
            // txtAgregarAlmacen
            // 
            this.txtAgregarAlmacen.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAgregarAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarAlmacen.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtAgregarAlmacen.ForeColor = System.Drawing.Color.White;
            this.txtAgregarAlmacen.Location = new System.Drawing.Point(0, 0);
            this.txtAgregarAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgregarAlmacen.Name = "txtAgregarAlmacen";
            this.txtAgregarAlmacen.ReadOnly = true;
            this.txtAgregarAlmacen.Size = new System.Drawing.Size(1203, 44);
            this.txtAgregarAlmacen.TabIndex = 2;
            this.txtAgregarAlmacen.Text = "AGREGAR A ALMACEN";
            this.txtAgregarAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgregarAlmacen.TextChanged += new System.EventHandler(this.txtAgregarAlmacen_TextChanged);
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.grpAgregarAlmacen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(309, 9);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAlmacen";
            this.grpAgregarAlmacen.ResumeLayout(false);
            this.grpAgregarAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.grpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarAlmacen;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAgregarAlmacen;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ToolTip tipAgregar;
        private System.Windows.Forms.ToolTip tipGuardar;
        private System.Windows.Forms.ToolTip tipLimpiar;
        private System.Windows.Forms.ToolTip tipBuscar;
        private System.Windows.Forms.ToolTip tipEliminar;
        private System.Windows.Forms.ToolTip tipSalir;
    }
}