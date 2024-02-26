namespace WinForms.ABMFormularios.Venta_Producto
{
    partial class frmModificarVenta
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
            lblTitulo = new Label();
            lblId = new Label();
            lblDescripciones = new Label();
            lblIdUsuario = new Label();
            txtId = new TextBox();
            txtIdUsuario = new TextBox();
            txtDescripciones = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(85, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(508, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MODIFICAR UNA VENTA REALIZADA";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(85, 74);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblDescripciones
            // 
            lblDescripciones.AutoSize = true;
            lblDescripciones.Location = new Point(85, 105);
            lblDescripciones.Name = "lblDescripciones";
            lblDescripciones.Size = new Size(80, 15);
            lblDescripciones.TabIndex = 2;
            lblDescripciones.Text = "Descripciones";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(85, 137);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(57, 15);
            lblIdUsuario.TabIndex = 3;
            lblIdUsuario.Text = "IdUsuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(192, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(192, 129);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 5;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(192, 97);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(332, 23);
            txtDescripciones.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(380, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(518, 165);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmModificarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 200);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripciones);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtId);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblDescripciones);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            Name = "frmModificarVenta";
            Text = "frmModificarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblId;
        private Label lblDescripciones;
        private Label lblIdUsuario;
        private TextBox txtId;
        private TextBox txtIdUsuario;
        private TextBox txtDescripciones;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}