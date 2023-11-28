
namespace WinAppSAP
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pboxFondo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pboxUsuario = new System.Windows.Forms.PictureBox();
            this.pboxPass = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pboxFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxFondo
            // 
            this.pboxFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pboxFondo.Location = new System.Drawing.Point(390, 146);
            this.pboxFondo.Name = "pboxFondo";
            this.pboxFondo.Size = new System.Drawing.Size(504, 473);
            this.pboxFondo.TabIndex = 0;
            this.pboxFondo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(509, 294);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(288, 39);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(509, 387);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(288, 39);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // pboxUsuario
            // 
            this.pboxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pboxUsuario.BackgroundImage = global::WinAppSAP.Properties.Resources.PngItem_2560255;
            this.pboxUsuario.Location = new System.Drawing.Point(464, 294);
            this.pboxUsuario.Name = "pboxUsuario";
            this.pboxUsuario.Size = new System.Drawing.Size(39, 39);
            this.pboxUsuario.TabIndex = 3;
            this.pboxUsuario.TabStop = false;
            // 
            // pboxPass
            // 
            this.pboxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pboxPass.Image = global::WinAppSAP.Properties.Resources.Sin_título1;
            this.pboxPass.Location = new System.Drawing.Point(464, 387);
            this.pboxPass.Name = "pboxPass";
            this.pboxPass.Size = new System.Drawing.Size(39, 39);
            this.pboxPass.TabIndex = 4;
            this.pboxPass.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Gray;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(464, 495);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(148, 66);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Ingresar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(649, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 66);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pboxFoto
            // 
            this.pboxFoto.BackColor = System.Drawing.Color.Transparent;
            this.pboxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pboxFoto.Image")));
            this.pboxFoto.Location = new System.Drawing.Point(553, 47);
            this.pboxFoto.Name = "pboxFoto";
            this.pboxFoto.Size = new System.Drawing.Size(200, 200);
            this.pboxFoto.TabIndex = 7;
            this.pboxFoto.TabStop = false;
            this.pboxFoto.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinAppSAP.Properties.Resources.wallpapertip_1280x720_hd_wallpapers_898559;
            this.ClientSize = new System.Drawing.Size(1280, 697);
            this.Controls.Add(this.pboxFoto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pboxPass);
            this.Controls.Add(this.pboxUsuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pboxFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Secion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFondo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pboxUsuario;
        private System.Windows.Forms.PictureBox pboxPass;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pboxFoto;
    }
}

