namespace WinForms.ABMFormularios
{
    partial class frmABMUsuario
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
            dgvDatos = new DataGridView();
            btnNuevoUsuario = new Button();
            btnListarUsuarios = new Button();
            btnModificarUsuario = new Button();
            btnBuscarUsuario = new Button();
            btnEliminarUsuario = new Button();
            txtBuscarUsuario = new TextBox();
            txtEliminarUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 104);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(776, 334);
            dgvDatos.TabIndex = 0;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Location = new Point(12, 12);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(97, 44);
            btnNuevoUsuario.TabIndex = 1;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.Location = new Point(130, 12);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(97, 44);
            btnListarUsuarios.TabIndex = 2;
            btnListarUsuarios.Text = "Listar Usuarios";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            btnListarUsuarios.Click += btnListarUsuarios_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(247, 12);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(97, 44);
            btnModificarUsuario.TabIndex = 3;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(363, 12);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(97, 44);
            btnBuscarUsuario.TabIndex = 4;
            btnBuscarUsuario.Text = "Buscar Usuario";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(665, 12);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(97, 44);
            btnEliminarUsuario.TabIndex = 5;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(363, 62);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(97, 23);
            txtBuscarUsuario.TabIndex = 6;
            // 
            // txtEliminarUsuario
            // 
            txtEliminarUsuario.Location = new Point(665, 62);
            txtEliminarUsuario.Name = "txtEliminarUsuario";
            txtEliminarUsuario.Size = new Size(97, 23);
            txtEliminarUsuario.TabIndex = 7;
            // 
            // frmABMUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEliminarUsuario);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnListarUsuarios);
            Controls.Add(btnNuevoUsuario);
            Controls.Add(dgvDatos);
            Name = "frmABMUsuario";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnNuevoUsuario;
        private Button btnListarUsuarios;
        private Button btnModificarUsuario;
        private Button btnBuscarUsuario;
        private Button btnEliminarUsuario;
        private TextBox txtBuscarUsuario;
        private TextBox txtEliminarUsuario;
    }
}