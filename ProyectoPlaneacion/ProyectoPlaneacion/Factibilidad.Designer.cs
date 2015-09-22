namespace ProyectoPlaneacion
{
    partial class Factibilidad
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
            this.dataGridProyectos = new System.Windows.Forms.DataGridView();
            this.n_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProyectos
            // 
            this.dataGridProyectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridProyectos.Location = new System.Drawing.Point(12, 29);
            this.dataGridProyectos.Name = "dataGridProyectos";
            this.dataGridProyectos.Size = new System.Drawing.Size(846, 299);
            this.dataGridProyectos.TabIndex = 0;
            this.dataGridProyectos.DoubleClick += new System.EventHandler(this.dataGridProyectos_DoubleClick);
            // 
            // n_id
            // 
            this.n_id.DataPropertyName = "idProyecto";
            this.n_id.HeaderText = "IdProyecto";
            this.n_id.Name = "n_id";
            this.n_id.ReadOnly = true;
            this.n_id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "denominacion";
            this.Column2.HeaderText = "Denominacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descripcionA";
            this.Column3.HeaderText = "Area";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "area_afectada";
            this.Column4.HeaderText = "Areas Afectadas";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "descripcion";
            this.Column5.HeaderText = "Descripcion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "duracion";
            this.Column6.HeaderText = "Duracion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Factibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 353);
            this.Controls.Add(this.dataGridProyectos);
            this.Name = "Factibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos Factibles";
            this.Load += new System.EventHandler(this.Factibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}