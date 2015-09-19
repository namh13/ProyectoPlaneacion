namespace ProyectoPlaneacion
{
    partial class frmBeneficios
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVBeneficio = new System.Windows.Forms.DataGridView();
            this.btnMasB = new System.Windows.Forms.Button();
            this.btnMenosB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dGVFuente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBeneficio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(464, 386);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbProyecto
            // 
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.FormattingEnabled = true;
            this.cmbProyecto.Location = new System.Drawing.Point(83, 27);
            this.cmbProyecto.Name = "cmbProyecto";
            this.cmbProyecto.Size = new System.Drawing.Size(321, 21);
            this.cmbProyecto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beneficios";
            // 
            // dGVBeneficio
            // 
            this.dGVBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBeneficio.Location = new System.Drawing.Point(83, 67);
            this.dGVBeneficio.Name = "dGVBeneficio";
            this.dGVBeneficio.Size = new System.Drawing.Size(395, 150);
            this.dGVBeneficio.TabIndex = 10;
            // 
            // btnMasB
            // 
            this.btnMasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasB.Location = new System.Drawing.Point(484, 94);
            this.btnMasB.Name = "btnMasB";
            this.btnMasB.Size = new System.Drawing.Size(39, 31);
            this.btnMasB.TabIndex = 11;
            this.btnMasB.Text = "+";
            this.btnMasB.UseVisualStyleBackColor = true;
            // 
            // btnMenosB
            // 
            this.btnMenosB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosB.Location = new System.Drawing.Point(484, 131);
            this.btnMenosB.Name = "btnMenosB";
            this.btnMenosB.Size = new System.Drawing.Size(39, 31);
            this.btnMenosB.TabIndex = 12;
            this.btnMenosB.Text = "-";
            this.btnMenosB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(485, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(485, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dGVFuente
            // 
            this.dGVFuente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFuente.Location = new System.Drawing.Point(84, 225);
            this.dGVFuente.Name = "dGVFuente";
            this.dGVFuente.Size = new System.Drawing.Size(395, 150);
            this.dGVFuente.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Recurso";
            // 
            // frmBeneficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dGVFuente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenosB);
            this.Controls.Add(this.btnMasB);
            this.Controls.Add(this.dGVBeneficio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProyecto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficios Obtenidos";
            this.Load += new System.EventHandler(this.frmBeneficios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBeneficio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVBeneficio;
        private System.Windows.Forms.Button btnMasB;
        private System.Windows.Forms.Button btnMenosB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dGVFuente;
        private System.Windows.Forms.Label label3;
    }
}