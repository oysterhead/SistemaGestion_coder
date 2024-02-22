namespace WinForms.ABMFormularios.Formularios_Producto
{
    partial class frmModificarProducto
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
            btnBuscar = new Button();
            txtId = new TextBox();
            lblId = new Label();
            txtIdUsuario = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCosto = new TextBox();
            txtDescripciones = new TextBox();
            btnCancelar = new Button();
            btnModificar = new Button();
            lblIdUsuario = new Label();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblDescripciones = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(392, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar...";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(228, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 23);
            txtId.TabIndex = 41;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(61, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(118, 15);
            lblId.TabIndex = 40;
            lblId.Text = "ID producto buscado";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(228, 225);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(239, 23);
            txtIdUsuario.TabIndex = 39;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(228, 192);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(239, 23);
            txtStock.TabIndex = 38;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(228, 161);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(239, 23);
            txtPrecioVenta.TabIndex = 37;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(228, 130);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(239, 23);
            txtCosto.TabIndex = 36;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(228, 93);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(239, 23);
            txtDescripciones.TabIndex = 35;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(425, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 38);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(540, 293);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 38);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(61, 225);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(61, 15);
            lblIdUsuario.TabIndex = 32;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(61, 195);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 31;
            lblStock.Text = "Stock";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(61, 164);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(72, 15);
            lblPrecioVenta.TabIndex = 30;
            lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(61, 130);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(38, 15);
            lblCosto.TabIndex = 29;
            lblCosto.Text = "Costo";
            // 
            // lblDescripciones
            // 
            lblDescripciones.AutoSize = true;
            lblDescripciones.Location = new Point(61, 101);
            lblDescripciones.Name = "lblDescripciones";
            lblDescripciones.Size = new Size(80, 15);
            lblDescripciones.TabIndex = 28;
            lblDescripciones.Text = "Descripciones";
            // 
            // frmModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 351);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripciones);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblCosto);
            Controls.Add(lblDescripciones);
            Name = "frmModificarProducto";
            Text = "Modificar Producto Por ID";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtIdUsuario;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtCosto;
        private TextBox txtDescripciones;
        private Button btnCancelar;
        private Button btnModificar;
        private Label lblIdUsuario;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblDescripciones;
    }
}