namespace Hotel.Formulario
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnCrud = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblAdministrador);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.pnlCliente);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.pnlAdmin);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 795);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Location = new System.Drawing.Point(38, 733);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(0, 25);
            this.lblAdministrador.TabIndex = 8;
            this.lblAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(41, 668);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 33);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnReserva);
            this.pnlCliente.Controls.Add(this.btnCrud);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(0, 381);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(200, 81);
            this.pnlCliente.TabIndex = 5;
            // 
            // btnReserva
            // 
            this.btnReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.Location = new System.Drawing.Point(0, 36);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(200, 33);
            this.btnReserva.TabIndex = 1;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnCrud
            // 
            this.btnCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrud.Location = new System.Drawing.Point(0, 0);
            this.btnCrud.Name = "btnCrud";
            this.btnCrud.Size = new System.Drawing.Size(200, 36);
            this.btnCrud.TabIndex = 0;
            this.btnCrud.Text = "Crud";
            this.btnCrud.UseVisualStyleBackColor = true;
            this.btnCrud.Click += new System.EventHandler(this.btnCrud_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(0, 333);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(200, 48);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnConsumo);
            this.pnlAdmin.Controls.Add(this.btnProducto);
            this.pnlAdmin.Controls.Add(this.button3);
            this.pnlAdmin.Controls.Add(this.button2);
            this.pnlAdmin.Controls.Add(this.button1);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 148);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(200, 185);
            this.pnlAdmin.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Estado disponibilidad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listado ocupación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear habitación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHabitacion);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(0, 100);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 48);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContenedor.Location = new System.Drawing.Point(231, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1131, 795);
            this.pnlContenedor.TabIndex = 1;
            // 
            // btnProducto
            // 
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Location = new System.Drawing.Point(0, 102);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(200, 35);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.Text = "Crear Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnConsumo
            // 
            this.btnConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.Location = new System.Drawing.Point(0, 137);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(200, 35);
            this.btnConsumo.TabIndex = 4;
            this.btnConsumo.Text = "Registrar consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 795);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnCrud;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Button btnProducto;
    }
}