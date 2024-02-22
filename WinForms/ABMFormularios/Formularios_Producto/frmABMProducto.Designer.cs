namespace WinForms.ABMFormularios.Formularios_Producto
{
    partial class frmABMProducto
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
            txtEliminarProducto = new TextBox();
            txtBuscarProducto = new TextBox();
            btnEliminarProducto = new Button();
            btnBuscarProducto = new Button();
            btnModificarProducto = new Button();
            btnListarProductos = new Button();
            btnNuevoProducto = new Button();
            dgvDatosProducto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosProducto).BeginInit();
            SuspendLayout();
            // 
            // txtEliminarProducto
            // 
            txtEliminarProducto.Location = new Point(665, 62);
            txtEliminarProducto.Name = "txtEliminarProducto";
            txtEliminarProducto.Size = new Size(97, 23);
            txtEliminarProducto.TabIndex = 15;
            txtEliminarProducto.TextChanged += txtEliminarProducto_TextChanged;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(363, 62);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(97, 23);
            txtBuscarProducto.TabIndex = 14;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(665, 12);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(97, 44);
            btnEliminarProducto.TabIndex = 13;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(363, 12);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(97, 44);
            btnBuscarProducto.TabIndex = 12;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(247, 12);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(97, 44);
            btnModificarProducto.TabIndex = 11;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnListarProductos
            // 
            btnListarProductos.Location = new Point(130, 12);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new Size(97, 44);
            btnListarProductos.TabIndex = 10;
            btnListarProductos.Text = "Listar Productos";
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(12, 12);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(97, 44);
            btnNuevoProducto.TabIndex = 9;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // dgvDatosProducto
            // 
            dgvDatosProducto.AllowUserToAddRows = false;
            dgvDatosProducto.AllowUserToDeleteRows = false;
            dgvDatosProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosProducto.Location = new Point(12, 104);
            dgvDatosProducto.Name = "dgvDatosProducto";
            dgvDatosProducto.ReadOnly = true;
            dgvDatosProducto.RowTemplate.Height = 25;
            dgvDatosProducto.Size = new Size(776, 334);
            dgvDatosProducto.TabIndex = 8;
            // 
            // frmABMProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEliminarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnListarProductos);
            Controls.Add(btnNuevoProducto);
            Controls.Add(dgvDatosProducto);
            Name = "frmABMProducto";
            Text = "ABM Productos";
            ((System.ComponentModel.ISupportInitialize)dgvDatosProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEliminarProducto;
        private TextBox txtBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnBuscarProducto;
        private Button btnModificarProducto;
        private Button btnListarProductos;
        private Button btnNuevoProducto;
        private DataGridView dgvDatosProducto;
    }
}