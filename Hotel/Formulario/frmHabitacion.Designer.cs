namespace Hotel.Formulario
{
    partial class frmHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabitacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumHabitacion = new System.Windows.Forms.TextBox();
            this.txtTamanoHabitacion = new System.Windows.Forms.TextBox();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.rdbServicioAlCuartoSi = new System.Windows.Forms.RadioButton();
            this.rdbMiniBarSi = new System.Windows.Forms.RadioButton();
            this.rdbAireAcondicionadoSi = new System.Windows.Forms.RadioButton();
            this.rdbMiniBarNo = new System.Windows.Forms.RadioButton();
            this.rdbAireAcondicionadoNo = new System.Windows.Forms.RadioButton();
            this.rdbServicioAlCuartoNo = new System.Windows.Forms.RadioButton();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFondo = new System.Windows.Forms.Button();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.tblTipoHabitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTipoHabitacionTableAdapter = new Hotel.HotelDataSetTableAdapters.tblTipoHabitacionTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoHabitacionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de habitación:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de habitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de habitación:";
            // 
            // txtNumHabitacion
            // 
            this.txtNumHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumHabitacion.Location = new System.Drawing.Point(361, 68);
            this.txtNumHabitacion.Name = "txtNumHabitacion";
            this.txtNumHabitacion.Size = new System.Drawing.Size(229, 31);
            this.txtNumHabitacion.TabIndex = 3;
            // 
            // txtTamanoHabitacion
            // 
            this.txtTamanoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanoHabitacion.Location = new System.Drawing.Point(361, 165);
            this.txtTamanoHabitacion.Name = "txtTamanoHabitacion";
            this.txtTamanoHabitacion.Size = new System.Drawing.Size(229, 31);
            this.txtTamanoHabitacion.TabIndex = 4;
            this.txtTamanoHabitacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DataSource = this.tblTipoHabitacionBindingSource;
            this.cmbTipoHabitacion.DisplayMember = "descripcion";
            this.cmbTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(361, 117);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(229, 33);
            this.cmbTipoHabitacion.TabIndex = 5;
            this.cmbTipoHabitacion.ValueMember = "IdTipo";
            // 
            // rdbServicioAlCuartoSi
            // 
            this.rdbServicioAlCuartoSi.AutoSize = true;
            this.rdbServicioAlCuartoSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbServicioAlCuartoSi.Location = new System.Drawing.Point(20, 34);
            this.rdbServicioAlCuartoSi.Name = "rdbServicioAlCuartoSi";
            this.rdbServicioAlCuartoSi.Size = new System.Drawing.Size(46, 29);
            this.rdbServicioAlCuartoSi.TabIndex = 9;
            this.rdbServicioAlCuartoSi.TabStop = true;
            this.rdbServicioAlCuartoSi.Text = "si";
            this.rdbServicioAlCuartoSi.UseVisualStyleBackColor = true;
            // 
            // rdbMiniBarSi
            // 
            this.rdbMiniBarSi.AutoSize = true;
            this.rdbMiniBarSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMiniBarSi.Location = new System.Drawing.Point(18, 38);
            this.rdbMiniBarSi.Name = "rdbMiniBarSi";
            this.rdbMiniBarSi.Size = new System.Drawing.Size(46, 29);
            this.rdbMiniBarSi.TabIndex = 10;
            this.rdbMiniBarSi.TabStop = true;
            this.rdbMiniBarSi.Text = "si";
            this.rdbMiniBarSi.UseVisualStyleBackColor = true;
            // 
            // rdbAireAcondicionadoSi
            // 
            this.rdbAireAcondicionadoSi.AutoSize = true;
            this.rdbAireAcondicionadoSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAireAcondicionadoSi.Location = new System.Drawing.Point(13, 30);
            this.rdbAireAcondicionadoSi.Name = "rdbAireAcondicionadoSi";
            this.rdbAireAcondicionadoSi.Size = new System.Drawing.Size(46, 29);
            this.rdbAireAcondicionadoSi.TabIndex = 11;
            this.rdbAireAcondicionadoSi.TabStop = true;
            this.rdbAireAcondicionadoSi.Text = "si";
            this.rdbAireAcondicionadoSi.UseVisualStyleBackColor = true;
            // 
            // rdbMiniBarNo
            // 
            this.rdbMiniBarNo.AutoSize = true;
            this.rdbMiniBarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMiniBarNo.Location = new System.Drawing.Point(138, 38);
            this.rdbMiniBarNo.Name = "rdbMiniBarNo";
            this.rdbMiniBarNo.Size = new System.Drawing.Size(57, 29);
            this.rdbMiniBarNo.TabIndex = 12;
            this.rdbMiniBarNo.TabStop = true;
            this.rdbMiniBarNo.Text = "No";
            this.rdbMiniBarNo.UseVisualStyleBackColor = true;
            // 
            // rdbAireAcondicionadoNo
            // 
            this.rdbAireAcondicionadoNo.AutoSize = true;
            this.rdbAireAcondicionadoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAireAcondicionadoNo.Location = new System.Drawing.Point(142, 30);
            this.rdbAireAcondicionadoNo.Name = "rdbAireAcondicionadoNo";
            this.rdbAireAcondicionadoNo.Size = new System.Drawing.Size(57, 29);
            this.rdbAireAcondicionadoNo.TabIndex = 13;
            this.rdbAireAcondicionadoNo.TabStop = true;
            this.rdbAireAcondicionadoNo.Text = "No";
            this.rdbAireAcondicionadoNo.UseVisualStyleBackColor = true;
            // 
            // rdbServicioAlCuartoNo
            // 
            this.rdbServicioAlCuartoNo.AutoSize = true;
            this.rdbServicioAlCuartoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbServicioAlCuartoNo.Location = new System.Drawing.Point(171, 30);
            this.rdbServicioAlCuartoNo.Name = "rdbServicioAlCuartoNo";
            this.rdbServicioAlCuartoNo.Size = new System.Drawing.Size(57, 29);
            this.rdbServicioAlCuartoNo.TabIndex = 14;
            this.rdbServicioAlCuartoNo.TabStop = true;
            this.rdbServicioAlCuartoNo.Text = "No";
            this.rdbServicioAlCuartoNo.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(148, 414);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(80, 34);
            this.btnPrimero.TabIndex = 15;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(247, 414);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(80, 34);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(344, 414);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(80, 34);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(441, 414);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(80, 34);
            this.btnUltimo.TabIndex = 18;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(49, 472);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 34);
            this.btnConsulta.TabIndex = 19;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(180, 472);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(121, 34);
            this.btnIngreso.TabIndex = 20;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            // 
            // btnModificacion
            // 
            this.btnModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacion.Location = new System.Drawing.Point(322, 472);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(151, 34);
            this.btnModificacion.TabIndex = 21;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            // 
            // btnRetiro
            // 
            this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.Location = new System.Drawing.Point(489, 472);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(121, 34);
            this.btnRetiro.TabIndex = 22;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(1006, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(12, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 62);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnFondo
            // 
            this.btnFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFondo.BackgroundImage")));
            this.btnFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFondo.Location = new System.Drawing.Point(709, 148);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(357, 358);
            this.btnFondo.TabIndex = 25;
            this.btnFondo.UseVisualStyleBackColor = true;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTipoHabitacionBindingSource
            // 
            this.tblTipoHabitacionBindingSource.DataMember = "tblTipoHabitacion";
            this.tblTipoHabitacionBindingSource.DataSource = this.hotelDataSet;
            // 
            // tblTipoHabitacionTableAdapter
            // 
            this.tblTipoHabitacionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbServicioAlCuartoSi);
            this.groupBox1.Controls.Add(this.rdbServicioAlCuartoNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 69);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio al cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAireAcondicionadoSi);
            this.groupBox2.Controls.Add(this.rdbAireAcondicionadoNo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(361, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 69);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aire acondicionado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbMiniBarSi);
            this.groupBox3.Controls.Add(this.rdbMiniBarNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(229, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 73);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MiniBar";
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFondo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.txtTamanoHabitacion);
            this.Controls.Add(this.txtNumHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmHabitacion";
            this.Text = "frmHabitacion";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoHabitacionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumHabitacion;
        private System.Windows.Forms.TextBox txtTamanoHabitacion;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.RadioButton rdbServicioAlCuartoSi;
        private System.Windows.Forms.RadioButton rdbMiniBarSi;
        private System.Windows.Forms.RadioButton rdbAireAcondicionadoSi;
        private System.Windows.Forms.RadioButton rdbMiniBarNo;
        private System.Windows.Forms.RadioButton rdbAireAcondicionadoNo;
        private System.Windows.Forms.RadioButton rdbServicioAlCuartoNo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnFondo;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tblTipoHabitacionBindingSource;
        private HotelDataSetTableAdapters.tblTipoHabitacionTableAdapter tblTipoHabitacionTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}