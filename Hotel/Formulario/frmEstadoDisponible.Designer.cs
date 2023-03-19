namespace Hotel.Formulario
{
    partial class frmEstadoDisponible
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
            this.dtgHabitacionesDisponibles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHabitacionesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitaciones disponibles ";
            // 
            // dtgHabitacionesDisponibles
            // 
            this.dtgHabitacionesDisponibles.AllowUserToAddRows = false;
            this.dtgHabitacionesDisponibles.AllowUserToDeleteRows = false;
            this.dtgHabitacionesDisponibles.AllowUserToOrderColumns = true;
            this.dtgHabitacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHabitacionesDisponibles.Location = new System.Drawing.Point(101, 131);
            this.dtgHabitacionesDisponibles.Name = "dtgHabitacionesDisponibles";
            this.dtgHabitacionesDisponibles.ReadOnly = true;
            this.dtgHabitacionesDisponibles.Size = new System.Drawing.Size(745, 537);
            this.dtgHabitacionesDisponibles.TabIndex = 1;
            // 
            // frmEstadoDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 738);
            this.Controls.Add(this.dtgHabitacionesDisponibles);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadoDisponible";
            this.Text = "frmEstadiDisponible";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHabitacionesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHabitacionesDisponibles;
    }
}