
namespace WinAppSAP
{
    partial class frmProductos
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
            this.grpAgregarProducto = new System.Windows.Forms.GroupBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAgregarProduct = new System.Windows.Forms.TextBox();
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tipBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.tipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tipSalir = new System.Windows.Forms.ToolTip(this.components);
            this.grpAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgregarProducto
            // 
            this.grpAgregarProducto.BackColor = System.Drawing.Color.White;
            this.grpAgregarProducto.Controls.Add(this.txtProductos);
            this.grpAgregarProducto.Controls.Add(this.lblProducto);
            this.grpAgregarProducto.Controls.Add(this.dgvProductos);
            this.grpAgregarProducto.Controls.Add(this.lblPrecio);
            this.grpAgregarProducto.Controls.Add(this.txtProducto);
            this.grpAgregarProducto.Controls.Add(this.txtPrecio);
            this.grpAgregarProducto.Controls.Add(this.grpBotones);
            this.grpAgregarProducto.Controls.Add(this.txtAgregarProduct);
            this.grpAgregarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.grpAgregarProducto.Location = new System.Drawing.Point(1, 2);
            this.grpAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarProducto.Name = "grpAgregarProducto";
            this.grpAgregarProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAgregarProducto.Size = new System.Drawing.Size(1201, 649);
            this.grpAgregarProducto.TabIndex = 16;
            this.grpAgregarProducto.TabStop = false;
            // 
            // txtProductos
            // 
            this.txtProductos.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductos.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtProductos.ForeColor = System.Drawing.Color.White;
            this.txtProductos.Location = new System.Drawing.Point(0, 251);
            this.txtProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.ReadOnly = true;
            this.txtProductos.Size = new System.Drawing.Size(1203, 44);
            this.txtProductos.TabIndex = 17;
            this.txtProductos.Text = "PRODUCTOS";
            this.txtProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 299);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.Size = new System.Drawing.Size(1189, 341);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductos_MouseClick);
            this.dgvProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductos_MouseDoubleClick);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Orange;
            this.lblPrecio.Location = new System.Drawing.Point(32, 163);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 41);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProducto.Location = new System.Drawing.Point(178, 72);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(425, 34);
            this.txtProducto.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(178, 160);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(425, 34);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
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
            // txtAgregarProduct
            // 
            this.txtAgregarProduct.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAgregarProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgregarProduct.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtAgregarProduct.ForeColor = System.Drawing.Color.White;
            this.txtAgregarProduct.Location = new System.Drawing.Point(0, 0);
            this.txtAgregarProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgregarProduct.Name = "txtAgregarProduct";
            this.txtAgregarProduct.ReadOnly = true;
            this.txtAgregarProduct.Size = new System.Drawing.Size(1203, 44);
            this.txtAgregarProduct.TabIndex = 2;
            this.txtAgregarProduct.Text = "AGREGAR PRODUCTO";
            this.txtAgregarProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.grpAgregarProducto);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(309, 9);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.grpAgregarProducto.ResumeLayout(false);
            this.grpAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAgregarProduct;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.ToolTip tipAgregar;
        private System.Windows.Forms.ToolTip tipGuardar;
        private System.Windows.Forms.ToolTip tipLimpiar;
        private System.Windows.Forms.ToolTip tipBuscar;
        private System.Windows.Forms.ToolTip tipEliminar;
        private System.Windows.Forms.ToolTip tipSalir;
    }
}