namespace WinForms.ABMFormularios.Formularios_Producto
{
    partial class frmNuevoProducto
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
            txtIdUsuario = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCosto = new TextBox();
            txtDescripciones = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblIdUsuario = new Label();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblDescripciones = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(228, 204);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(239, 23);
            txtIdUsuario.TabIndex = 24;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(228, 171);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(239, 23);
            txtStock.TabIndex = 23;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(228, 140);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(239, 23);
            txtPrecioVenta.TabIndex = 22;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(228, 109);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(239, 23);
            txtCosto.TabIndex = 21;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(228, 72);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(239, 23);
            txtDescripciones.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(377, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 38);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(531, 257);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 38);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(61, 204);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(61, 15);
            lblIdUsuario.TabIndex = 17;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(61, 174);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(61, 143);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(88, 15);
            lblPrecioVenta.TabIndex = 15;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(61, 109);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(38, 15);
            lblCosto.TabIndex = 14;
            lblCosto.Text = "Costo";
            // 
            // lblDescripciones
            // 
            lblDescripciones.AutoSize = true;
            lblDescripciones.Location = new Point(61, 80);
            lblDescripciones.Name = "lblDescripciones";
            lblDescripciones.Size = new Size(80, 15);
            lblDescripciones.TabIndex = 13;
            lblDescripciones.Text = "Descripciones";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(179, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 25);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "ALTA DE PRODUCTO NUEVO";
            // 
            // frmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 321);
            Controls.Add(lblTitulo);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripciones);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblCosto);
            Controls.Add(lblDescripciones);
            Name = "frmNuevoProducto";
            Text = "frmNuevoProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtCosto;
        private TextBox txtDescripciones;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblIdUsuario;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblDescripciones;
        private Label lblTitulo;
    }
}