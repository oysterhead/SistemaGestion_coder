using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WinForms.ABMFormularios
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        public Usuario CrearUsuario {  get; private set; }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Nombre = this.textBox1.Text,
                Apellido = this.textBox2.Text,
                NombreUsuario = this.textBox3.Text,
                Contraseña = this.textBox4.Text,
                Mail = this.textBox5.Text,
            };

            this.CrearUsuario = usuario;
            string resultado = UsuarioService.AgregarUsuario(usuario);

            if (resultado == "true")
            {
                MessageBox.Show("Usuario dado de alta");
            }
            else { MessageBox.Show(resultado); }

            this.Close();
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin guardar datos...");
            this.Close();
        }

    }
}
