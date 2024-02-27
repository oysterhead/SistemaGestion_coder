namespace WinForms.ABMFormularios.Venta_Producto
{
    partial class frmAltaProductoVendido
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblStock = new Label();
            lblIdProducto = new Label();
            lblIdVenta = new Label();
            lblTitulo = new Label();
            txtStock = new TextBox();
            txtIdVenta = new TextBox();
            txtIdProducto = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(317, 186);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(443, 186);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 66);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(12, 98);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(70, 15);
            lblIdProducto.TabIndex = 3;
            lblIdProducto.Text = "ID Producto";
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(12, 129);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(50, 15);
            lblIdVenta.TabIndex = 4;
            lblIdVenta.Text = "ID Venta";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(32, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 29);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "REGISTRAR UN PRODUCTO VENDIDO";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(107, 63);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(210, 23);
            txtStock.TabIndex = 6;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(107, 126);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(210, 23);
            txtIdVenta.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(107, 95);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(210, 23);
            txtIdProducto.TabIndex = 8;
            // 
            // frmAltaProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 221);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdVenta);
            Controls.Add(txtStock);
            Controls.Add(lblTitulo);
            Controls.Add(lblIdVenta);
            Controls.Add(lblIdProducto);
            Controls.Add(lblStock);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "frmAltaProductoVendido";
            Text = "frmAltaProductoVendido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblStock;
        private Label lblIdProducto;
        private Label lblIdVenta;
        private Label lblTitulo;
        private TextBox txtStock;
        private TextBox txtIdVenta;
        private TextBox txtIdProducto;
    }
}