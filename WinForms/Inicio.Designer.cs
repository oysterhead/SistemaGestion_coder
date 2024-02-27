namespace WinForms
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnVenta = new Button();
            btnProducto = new Button();
            btnProductoVendido = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(231, 111);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(158, 96);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(433, 111);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(158, 96);
            btnVenta.TabIndex = 1;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(433, 243);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(158, 96);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.Location = new Point(231, 243);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(158, 96);
            btnProductoVendido.TabIndex = 3;
            btnProductoVendido.Text = "Producto Vendido";
            btnProductoVendido.UseVisualStyleBackColor = true;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProductoVendido);
            Controls.Add(btnProducto);
            Controls.Add(btnVenta);
            Controls.Add(btnUsuario);
            Name = "Inicio";
            Text = "Sistema de Gestion";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnVenta;
        private Button btnProducto;
        private Button btnProductoVendido;
    }
}
