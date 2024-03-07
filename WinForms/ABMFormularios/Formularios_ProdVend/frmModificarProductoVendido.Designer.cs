namespace WinForms.ABMFormularios.Formularios_ProdVend
{
    partial class frmModificarProductoVendido
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
            txtIdProductoVendido = new TextBox();
            lblId = new Label();
            lblStock = new Label();
            lblIdProducto = new Label();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtIdVenta = new TextBox();
            lblIdVenta = new Label();
            btnBuscar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtIdProductoVendido
            // 
            txtIdProductoVendido.Location = new Point(180, 97);
            txtIdProductoVendido.Name = "txtIdProductoVendido";
            txtIdProductoVendido.PlaceholderText = "Id Producto Vendido";
            txtIdProductoVendido.Size = new Size(146, 23);
            txtIdProductoVendido.TabIndex = 17;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(91, 105);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 18;
            lblId.Text = "ID";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(91, 152);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 19;
            lblStock.Text = "Stock";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(91, 208);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(70, 15);
            lblIdProducto.TabIndex = 20;
            lblIdProducto.Text = "ID Producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(180, 144);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(146, 23);
            txtStock.TabIndex = 21;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(180, 200);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(146, 23);
            txtIdProducto.TabIndex = 22;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(180, 262);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(146, 23);
            txtIdVenta.TabIndex = 24;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(91, 270);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(50, 15);
            lblIdVenta.TabIndex = 23;
            lblIdVenta.Text = "ID Venta";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(358, 97);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar ID";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(335, 313);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(442, 313);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmModificarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 358);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdVenta);
            Controls.Add(lblIdVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(lblIdProducto);
            Controls.Add(lblStock);
            Controls.Add(lblId);
            Controls.Add(txtIdProductoVendido);
            Name = "frmModificarProductoVendido";
            Text = "frmModificarProductoVendido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProductoVendido;
        private Label lblId;
        private Label lblStock;
        private Label lblIdProducto;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtIdVenta;
        private Label lblIdVenta;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}