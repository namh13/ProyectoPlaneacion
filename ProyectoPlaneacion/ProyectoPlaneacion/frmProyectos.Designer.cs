namespace ProyectoPlaneacion
{
    partial class frmProyectos
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
            this.button1 = new System.Windows.Forms.Button();
            this.n_idproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_idarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_area_afectada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProyectos
            // 
            this.dataGridProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_idproyecto,
            this.s_denominacion,
            this.n_idarea,
            this.s_area_afectada,
            this.s_descripcion,
            this.n_duracion});
            this.dataGridProyectos.Location = new System.Drawing.Point(12, 38);
            this.dataGridProyectos.Name = "dataGridProyectos";
            this.dataGridProyectos.Size = new System.Drawing.Size(848, 273);
            this.dataGridProyectos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // n_idproyecto
            // 
            this.n_idproyecto.DataPropertyName = "id_Proyecto";
            this.n_idproyecto.HeaderText = "IdProyecto";
            this.n_idproyecto.Name = "n_idproyecto";
            this.n_idproyecto.Visible = false;
            // 
            // s_denominacion
            // 
            this.s_denominacion.DataPropertyName = "denominacion";
            this.s_denominacion.HeaderText = "Denominacion";
            this.s_denominacion.Name = "s_denominacion";
            this.s_denominacion.Width = 250;
            // 
            // n_idarea
            // 
            this.n_idarea.DataPropertyName = "descripcionA";
            this.n_idarea.HeaderText = "Area";
            this.n_idarea.Name = "n_idarea";
            // 
            // s_area_afectada
            // 
            this.s_area_afectada.DataPropertyName = "area_afectada";
            this.s_area_afectada.HeaderText = "Areas Afectadas";
            this.s_area_afectada.Name = "s_area_afectada";
            // 
            // s_descripcion
            // 
            this.s_descripcion.DataPropertyName = "descripcion";
            this.s_descripcion.HeaderText = "Descripcion";
            this.s_descripcion.Name = "s_descripcion";
            this.s_descripcion.Width = 250;
            // 
            // n_duracion
            // 
            this.n_duracion.DataPropertyName = "duracion";
            this.n_duracion.HeaderText = "Duracion";
            this.n_duracion.Name = "n_duracion";
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridProyectos);
            this.Name = "frmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.frmProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProyectos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_idproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_idarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_area_afectada;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_duracion;
    }
}