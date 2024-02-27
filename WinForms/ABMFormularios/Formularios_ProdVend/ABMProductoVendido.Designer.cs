namespace WinForms.ABMFormularios.Formularios_ProdVend
{
    partial class ABMProductoVendido
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
            txtEliminarUsuario = new TextBox();
            txtBuscarUsuario = new TextBox();
            btnEliminarProductoVendido = new Button();
            btnBuscarUnProductoVendido = new Button();
            btnModificarProductoVendido = new Button();
            btnListarProductosVendidos = new Button();
            btnProductoVendido = new Button();
            dgvDatosProductosVendidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // txtEliminarUsuario
            // 
            txtEliminarUsuario.Location = new Point(644, 62);
            txtEliminarUsuario.Name = "txtEliminarUsuario";
            txtEliminarUsuario.PlaceholderText = "Id Producto Vendido A Eliminar";
            txtEliminarUsuario.Size = new Size(118, 23);
            txtEliminarUsuario.TabIndex = 15;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(444, 62);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Producto Vendido a Buscar";
            txtBuscarUsuario.Size = new Size(124, 23);
            txtBuscarUsuario.TabIndex = 14;
            // 
            // btnEliminarProductoVendido
            // 
            btnEliminarProductoVendido.Location = new Point(644, 12);
            btnEliminarProductoVendido.Name = "btnEliminarProductoVendido";
            btnEliminarProductoVendido.Size = new Size(118, 44);
            btnEliminarProductoVendido.TabIndex = 13;
            btnEliminarProductoVendido.Text = "Eliminar Producto Vendido";
            btnEliminarProductoVendido.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUnProductoVendido
            // 
            btnBuscarUnProductoVendido.Location = new Point(444, 12);
            btnBuscarUnProductoVendido.Name = "btnBuscarUnProductoVendido";
            btnBuscarUnProductoVendido.Size = new Size(124, 44);
            btnBuscarUnProductoVendido.TabIndex = 12;
            btnBuscarUnProductoVendido.Text = "Buscar Producto Vendido";
            btnBuscarUnProductoVendido.UseVisualStyleBackColor = true;
            // 
            // btnModificarProductoVendido
            // 
            btnModificarProductoVendido.Location = new Point(312, 12);
            btnModificarProductoVendido.Name = "btnModificarProductoVendido";
            btnModificarProductoVendido.Size = new Size(118, 44);
            btnModificarProductoVendido.TabIndex = 11;
            btnModificarProductoVendido.Text = "Modificar Producto Vendido";
            btnModificarProductoVendido.UseVisualStyleBackColor = true;
            btnModificarProductoVendido.Click += btnModificarProductoVendido_Click;
            // 
            // btnListarProductosVendidos
            // 
            btnListarProductosVendidos.Location = new Point(159, 12);
            btnListarProductosVendidos.Name = "btnListarProductosVendidos";
            btnListarProductosVendidos.Size = new Size(134, 44);
            btnListarProductosVendidos.TabIndex = 10;
            btnListarProductosVendidos.Text = "Listar Productos Vendidos";
            btnListarProductosVendidos.UseVisualStyleBackColor = true;
            btnListarProductosVendidos.Click += btnListarProductosVendidos_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.Location = new Point(12, 12);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(132, 44);
            btnProductoVendido.TabIndex = 9;
            btnProductoVendido.Text = "Nuevo Producto Vendido";
            btnProductoVendido.UseVisualStyleBackColor = true;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // dgvDatosProductosVendidos
            // 
            dgvDatosProductosVendidos.AllowUserToAddRows = false;
            dgvDatosProductosVendidos.AllowUserToDeleteRows = false;
            dgvDatosProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosProductosVendidos.Location = new Point(12, 104);
            dgvDatosProductosVendidos.Name = "dgvDatosProductosVendidos";
            dgvDatosProductosVendidos.ReadOnly = true;
            dgvDatosProductosVendidos.RowTemplate.Height = 25;
            dgvDatosProductosVendidos.Size = new Size(776, 334);
            dgvDatosProductosVendidos.TabIndex = 8;
            // 
            // ABMProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEliminarUsuario);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(btnEliminarProductoVendido);
            Controls.Add(btnBuscarUnProductoVendido);
            Controls.Add(btnModificarProductoVendido);
            Controls.Add(btnListarProductosVendidos);
            Controls.Add(btnProductoVendido);
            Controls.Add(dgvDatosProductosVendidos);
            Name = "ABMProductoVendido";
            Text = "ABMProductoVendido";
            ((System.ComponentModel.ISupportInitialize)dgvDatosProductosVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEliminarUsuario;
        private TextBox txtBuscarUsuario;
        private Button btnEliminarProductoVendido;
        private Button btnBuscarUnProductoVendido;
        private Button btnModificarProductoVendido;
        private Button btnListarProductosVendidos;
        private Button btnProductoVendido;
        private DataGridView dgvDatosProductosVendidos;
    }
}