namespace Hotel.Formulario
{
    partial class frmEstadoOcupado
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
            this.dtgHabitacionesOcupadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHabitacionesOcupadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitaciones ocupadas";
            // 
            // dtgHabitacionesOcupadas
            // 
            this.dtgHabitacionesOcupadas.AllowUserToAddRows = false;
            this.dtgHabitacionesOcupadas.AllowUserToDeleteRows = false;
            this.dtgHabitacionesOcupadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHabitacionesOcupadas.Location = new System.Drawing.Point(101, 131);
            this.dtgHabitacionesOcupadas.Name = "dtgHabitacionesOcupadas";
            this.dtgHabitacionesOcupadas.ReadOnly = true;
            this.dtgHabitacionesOcupadas.Size = new System.Drawing.Size(745, 537);
            this.dtgHabitacionesOcupadas.TabIndex = 1;
            // 
            // frmEstadoOcupado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 738);
            this.Controls.Add(this.dtgHabitacionesOcupadas);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadoOcupado";
            this.Text = "frmEstadoOcupado";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHabitacionesOcupadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHabitacionesOcupadas;
    }
}