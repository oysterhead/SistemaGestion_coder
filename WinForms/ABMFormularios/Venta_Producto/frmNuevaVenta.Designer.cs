namespace WinForms.ABMFormularios.Venta_Producto
{
    partial class frmNuevaVenta
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
            txtDescripcionVenta = new TextBox();
            lblIdUsuario = new Label();
            lblDescripcionVenta = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(138, 84);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(239, 23);
            txtIdUsuario.TabIndex = 13;
            // 
            // txtDescripcionVenta
            // 
            txtDescripcionVenta.Location = new Point(138, 43);
            txtDescripcionVenta.Name = "txtDescripcionVenta";
            txtDescripcionVenta.Size = new Size(239, 23);
            txtDescripcionVenta.TabIndex = 12;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(31, 87);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(61, 15);
            lblIdUsuario.TabIndex = 11;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // lblDescripcionVenta
            // 
            lblDescripcionVenta.AutoSize = true;
            lblDescripcionVenta.Location = new Point(31, 46);
            lblDescripcionVenta.Name = "lblDescripcionVenta";
            lblDescripcionVenta.Size = new Size(101, 15);
            lblDescripcionVenta.TabIndex = 10;
            lblDescripcionVenta.Text = "Descripcion Venta";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(228, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 38);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(390, 140);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 38);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 205);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtDescripcionVenta);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblDescripcionVenta);
            Name = "frmNuevaVenta";
            Text = "frmNuevaVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtDescripcionVenta;
        private Label lblIdUsuario;
        private Label lblDescripcionVenta;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}