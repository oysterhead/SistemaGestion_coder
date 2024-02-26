namespace WinForms.ABMFormularios.Venta_Producto
{
    partial class frmABMVenta
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
            txtEliminarVenta = new TextBox();
            txtBuscarVenta = new TextBox();
            btnEliminarVenta = new Button();
            btnBuscarVenta = new Button();
            btnModificarVenta = new Button();
            btnListarVentas = new Button();
            btnNuevaVenta = new Button();
            dgvDatosVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosVenta).BeginInit();
            SuspendLayout();
            // 
            // txtEliminarVenta
            // 
            txtEliminarVenta.Location = new Point(665, 62);
            txtEliminarVenta.Name = "txtEliminarVenta";
            txtEliminarVenta.Size = new Size(97, 23);
            txtEliminarVenta.TabIndex = 15;
            // 
            // txtBuscarVenta
            // 
            txtBuscarVenta.Location = new Point(363, 62);
            txtBuscarVenta.Name = "txtBuscarVenta";
            txtBuscarVenta.Size = new Size(97, 23);
            txtBuscarVenta.TabIndex = 14;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(665, 12);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(97, 44);
            btnEliminarVenta.TabIndex = 13;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Location = new Point(363, 12);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(97, 44);
            btnBuscarVenta.TabIndex = 12;
            btnBuscarVenta.Text = "Buscar Venta";
            btnBuscarVenta.UseVisualStyleBackColor = true;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(247, 12);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(97, 44);
            btnModificarVenta.TabIndex = 11;
            btnModificarVenta.Text = "Modificar Venta";
            btnModificarVenta.UseVisualStyleBackColor = true;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnListarVentas
            // 
            btnListarVentas.Location = new Point(130, 12);
            btnListarVentas.Name = "btnListarVentas";
            btnListarVentas.Size = new Size(97, 44);
            btnListarVentas.TabIndex = 10;
            btnListarVentas.Text = "Listar Ventas";
            btnListarVentas.UseVisualStyleBackColor = true;
            btnListarVentas.Click += btnListarVentas_Click;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(12, 12);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(97, 44);
            btnNuevaVenta.TabIndex = 9;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.UseVisualStyleBackColor = true;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // dgvDatosVenta
            // 
            dgvDatosVenta.AllowUserToAddRows = false;
            dgvDatosVenta.AllowUserToDeleteRows = false;
            dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosVenta.Location = new Point(12, 104);
            dgvDatosVenta.Name = "dgvDatosVenta";
            dgvDatosVenta.ReadOnly = true;
            dgvDatosVenta.RowTemplate.Height = 25;
            dgvDatosVenta.Size = new Size(776, 334);
            dgvDatosVenta.TabIndex = 8;
            // 
            // frmABMVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEliminarVenta);
            Controls.Add(txtBuscarVenta);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnBuscarVenta);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnListarVentas);
            Controls.Add(btnNuevaVenta);
            Controls.Add(dgvDatosVenta);
            Name = "frmABMVenta";
            Text = "ABM Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvDatosVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEliminarVenta;
        private TextBox txtBuscarVenta;
        private Button btnEliminarVenta;
        private Button btnBuscarVenta;
        private Button btnModificarVenta;
        private Button btnListarVentas;
        private Button btnNuevaVenta;
        private DataGridView dgvDatosVenta;
    }
}