namespace ProyectoPlaneacion
{
    partial class frmLogin
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.LblServidor = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.LblPuerto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(250, 169);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 38);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(167, 169);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(77, 38);
            this.BtnConectar.TabIndex = 4;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtServidor.Location = new System.Drawing.Point(127, 107);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(200, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // LblServidor
            // 
            this.LblServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblServidor.AutoSize = true;
            this.LblServidor.Location = new System.Drawing.Point(76, 109);
            this.LblServidor.Name = "LblServidor";
            this.LblServidor.Size = new System.Drawing.Size(46, 13);
            this.LblServidor.TabIndex = 25;
            this.LblServidor.Text = "Servidor";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtContrasena.Location = new System.Drawing.Point(127, 81);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(200, 20);
            this.txtContrasena.TabIndex = 1;
            // 
            // LblPass
            // 
            this.LblPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(61, 84);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(61, 13);
            this.LblPass.TabIndex = 21;
            this.LblPass.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUsuario.Location = new System.Drawing.Point(127, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(80, 56);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 19;
            this.LblUsuario.Text = "Usuario";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPuerto.Location = new System.Drawing.Point(127, 133);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(200, 20);
            this.txtPuerto.TabIndex = 3;
            // 
            // LblPuerto
            // 
            this.LblPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPuerto.AutoSize = true;
            this.LblPuerto.Location = new System.Drawing.Point(76, 136);
            this.LblPuerto.Name = "LblPuerto";
            this.LblPuerto.Size = new System.Drawing.Size(38, 13);
            this.LblPuerto.TabIndex = 27;
            this.LblPuerto.Text = "Puerto";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 224);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.LblPuerto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.LblServidor);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnConectar;
        internal System.Windows.Forms.TextBox txtServidor;
        internal System.Windows.Forms.Label LblServidor;
        internal System.Windows.Forms.TextBox txtContrasena;
        internal System.Windows.Forms.Label LblPass;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label LblUsuario;
        internal System.Windows.Forms.TextBox txtPuerto;
        internal System.Windows.Forms.Label LblPuerto;
    }
}