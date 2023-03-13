namespace Hotel.Formulario
{
    partial class frmReserva
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
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPersonas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroHabitaciones = new System.Windows.Forms.TextBox();
            this.dtgDisponibilidad = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnNuevReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(63, 103);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(405, 31);
            this.dtpFechaIngreso.TabIndex = 0;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(508, 103);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(401, 31);
            this.dtpFechaSalida.TabIndex = 1;
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dtpFechaSalida_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de personas:";
           
            // 
            // txtNumeroPersonas
            // 
            this.txtNumeroPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPersonas.Location = new System.Drawing.Point(282, 195);
            this.txtNumeroPersonas.Name = "txtNumeroPersonas";
            this.txtNumeroPersonas.Size = new System.Drawing.Size(100, 31);
            this.txtNumeroPersonas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Habitaciones:";
            // 
            // txtNumeroHabitaciones
            // 
            this.txtNumeroHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHabitaciones.Location = new System.Drawing.Point(681, 198);
            this.txtNumeroHabitaciones.Name = "txtNumeroHabitaciones";
            this.txtNumeroHabitaciones.Size = new System.Drawing.Size(100, 31);
            this.txtNumeroHabitaciones.TabIndex = 5;
            this.txtNumeroHabitaciones.Leave += new System.EventHandler(this.txtNumeroHabitaciones_Leave);
            // 
            // dtgDisponibilidad
            // 
            this.dtgDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisponibilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dtgDisponibilidad.Location = new System.Drawing.Point(99, 316);
            this.dtgDisponibilidad.Name = "dtgDisponibilidad";
            this.dtgDisponibilidad.RowHeadersVisible = false;
            this.dtgDisponibilidad.Size = new System.Drawing.Size(784, 197);
            this.dtgDisponibilidad.TabIndex = 6;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(99, 565);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(137, 36);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnNuevReserva
            // 
            this.btnNuevReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevReserva.Location = new System.Drawing.Point(292, 566);
            this.btnNuevReserva.Name = "btnNuevReserva";
            this.btnNuevReserva.Size = new System.Drawing.Size(213, 35);
            this.btnNuevReserva.TabIndex = 8;
            this.btnNuevReserva.Text = "Nueva Reserva";
            this.btnNuevReserva.UseVisualStyleBackColor = true;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 672);
            this.Controls.Add(this.btnNuevReserva);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtgDisponibilidad);
            this.Controls.Add(this.txtNumeroHabitaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Name = "frmReserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroHabitaciones;
        private System.Windows.Forms.DataGridView dtgDisponibilidad;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnNuevReserva;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}