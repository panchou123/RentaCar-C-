
namespace WinAppSAP
{
    partial class frmVentas
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
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpBotones2 = new System.Windows.Forms.GroupBox();
            this.grpVentas = new System.Windows.Forms.GroupBox();
            this.tipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tipVenta = new System.Windows.Forms.ToolTip(this.components);
            this.tipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.tipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tipSalir = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.grpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.grpBotones2.SuspendLayout();
            this.grpVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVentas
            // 
            this.txtVentas.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVentas.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.txtVentas.ForeColor = System.Drawing.Color.White;
            this.txtVentas.Location = new System.Drawing.Point(0, 0);
            this.txtVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.ReadOnly = true;
            this.txtVentas.Size = new System.Drawing.Size(1205, 44);
            this.txtVentas.TabIndex = 3;
            this.txtVentas.Text = "VENTAS";
            this.txtVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(154, 78);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(538, 36);
            this.cmbCliente.TabIndex = 27;
            this.cmbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCliente_KeyPress);
            this.cmbCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCliente_MouseClick);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(776, 150);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(245, 36);
            this.cmbProducto.TabIndex = 28;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProducto_KeyPress);
            this.cmbProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbProducto_MouseClick);
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numCantidad.Location = new System.Drawing.Point(776, 232);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(245, 34);
            this.numCantidad.TabIndex = 29;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // grpBotones
            // 
            this.grpBotones.BackColor = System.Drawing.Color.White;
            this.grpBotones.Controls.Add(this.btnLimpiar);
            this.grpBotones.Controls.Add(this.btnEliminar);
            this.grpBotones.Controls.Add(this.btnAgregar);
            this.grpBotones.Controls.Add(this.btnGuardar);
            this.grpBotones.Location = new System.Drawing.Point(1075, 153);
            this.grpBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBotones.Size = new System.Drawing.Size(97, 342);
            this.grpBotones.TabIndex = 30;
            this.grpBotones.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::WinAppSAP.Properties.Resources.limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(20, 186);
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
            this.btnEliminar.Location = new System.Drawing.Point(20, 267);
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
            this.btnAgregar.Location = new System.Drawing.Point(20, 24);
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
            this.btnGuardar.Location = new System.Drawing.Point(20, 106);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 59);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackgroundImage = global::WinAppSAP.Properties.Resources.pngwing_com;
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVenta.Location = new System.Drawing.Point(21, 26);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(59, 58);
            this.btnVenta.TabIndex = 22;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::WinAppSAP.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(113, 26);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 58);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Orange;
            this.lblCliente.Location = new System.Drawing.Point(12, 78);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(110, 41);
            this.lblCliente.TabIndex = 31;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Orange;
            this.lblProducto.Location = new System.Drawing.Point(663, 150);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(107, 31);
            this.lblProducto.TabIndex = 32;
            this.lblProducto.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(663, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cantidad";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 150);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.RowTemplate.Height = 24;
            this.dgvFactura.Size = new System.Drawing.Size(637, 491);
            this.dgvFactura.TabIndex = 34;
            this.dgvFactura.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFactura_CellMouseClick);
            this.dgvFactura.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFactura_CellMouseDoubleClick);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSubtotal.Location = new System.Drawing.Point(776, 307);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(245, 34);
            this.txtSubtotal.TabIndex = 35;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.Color.White;
            this.txtIVA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIVA.Location = new System.Drawing.Point(776, 386);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(245, 34);
            this.txtIVA.TabIndex = 36;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTotal.Location = new System.Drawing.Point(776, 467);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(245, 34);
            this.txtTotal.TabIndex = 37;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Orange;
            this.lblSubtotal.Location = new System.Drawing.Point(670, 310);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 31);
            this.lblSubtotal.TabIndex = 38;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.White;
            this.lblIVA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.Orange;
            this.lblIVA.Location = new System.Drawing.Point(725, 389);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(48, 31);
            this.lblIVA.TabIndex = 39;
            this.lblIVA.Text = "IVA";
            this.lblIVA.Click += new System.EventHandler(this.lblIVA_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Orange;
            this.lblTotal.Location = new System.Drawing.Point(712, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 31);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Total";
            // 
            // grpBotones2
            // 
            this.grpBotones2.BackColor = System.Drawing.Color.White;
            this.grpBotones2.Controls.Add(this.btnVenta);
            this.grpBotones2.Controls.Add(this.btnSalir);
            this.grpBotones2.Location = new System.Drawing.Point(794, 524);
            this.grpBotones2.Name = "grpBotones2";
            this.grpBotones2.Size = new System.Drawing.Size(194, 106);
            this.grpBotones2.TabIndex = 41;
            this.grpBotones2.TabStop = false;
            // 
            // grpVentas
            // 
            this.grpVentas.BackColor = System.Drawing.Color.White;
            this.grpVentas.Controls.Add(this.cmbCliente);
            this.grpVentas.Controls.Add(this.lblProducto);
            this.grpVentas.Controls.Add(this.lblSubtotal);
            this.grpVentas.Controls.Add(this.label1);
            this.grpVentas.ForeColor = System.Drawing.Color.Black;
            this.grpVentas.Location = new System.Drawing.Point(0, 0);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(1201, 654);
            this.grpVentas.TabIndex = 42;
            this.grpVentas.TabStop = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.grpBotones2);
            this.Controls.Add(this.grpVentas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(309, 9);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.grpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.grpBotones2.ResumeLayout(false);
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpBotones2;
        private System.Windows.Forms.GroupBox grpVentas;
        private System.Windows.Forms.ToolTip tipEliminar;
        private System.Windows.Forms.ToolTip tipVenta;
        private System.Windows.Forms.ToolTip tipLimpiar;
        private System.Windows.Forms.ToolTip tipGuardar;
        private System.Windows.Forms.ToolTip tipAgregar;
        private System.Windows.Forms.ToolTip tipSalir;
    }
}