namespace WinForms.ABMFormularios
{
    partial class frmUsuarioMod
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
            txtMail = new TextBox();
            txtPassword = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnModificar = new Button();
            lblMail = new Label();
            lblPassword = new Label();
            lblNombreUsuario = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblId = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(228, 204);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(239, 23);
            txtMail.TabIndex = 24;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(228, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(239, 23);
            txtPassword.TabIndex = 23;
            //txtPassword.TextChanged += textBox;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(228, 140);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(239, 23);
            txtNombreUsuario.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(228, 109);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(239, 23);
            txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(228, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 23);
            txtNombre.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(514, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 38);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(629, 340);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 38);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(61, 204);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 17;
            lblMail.Text = "Mail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(61, 174);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(61, 143);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 15;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(61, 109);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(61, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(61, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(126, 15);
            lblId.TabIndex = 25;
            lblId.Text = "ID del usuario a buscar";
            // 
            // txtId
            // 
            txtId.Location = new Point(228, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 23);
            txtId.TabIndex = 26;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(392, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar...";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmUsuarioMod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtMail);
            Controls.Add(txtPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(lblMail);
            Controls.Add(lblPassword);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmUsuarioMod";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtPassword;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnModificar;
        private Label lblMail;
        private Label lblPassword;
        private Label lblNombreUsuario;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblId;
        private TextBox txtId;
        private Button btnBuscar;
    }
}