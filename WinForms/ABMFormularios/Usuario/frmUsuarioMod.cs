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
    public partial class frmUsuarioMod : Form
    {
        private int usuarioId = 0;
        public frmUsuarioMod()
        {
            InitializeComponent();
        }

        public frmUsuarioMod(Usuario usuario) : this()
        {
            this.txtNombre.Text = usuario.Nombre;
            this.txtApellido.Text = usuario.Apellido;
            this.txtNombreUsuario.Text = usuario.NombreUsuario;
            this.txtPassword.Text = usuario.Contraseña;
            this.txtMail.Text = usuario.Mail;
        }
        public Usuario usuarioCreado { get; private set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            int Id = Convert.ToInt32(id);
            Usuario usuarioBuscado = UsuarioService.ObtenerUsuarioPorId(Id);
            usuarioId = usuarioBuscado.Id;
            if (usuarioBuscado == null)
            {
                MessageBox.Show($"Usuario con ID {Id} no encontrado.");
            }
            else
            {
                txtNombre.Text = usuarioBuscado.Nombre;
                txtApellido.Text = usuarioBuscado.Apellido;
                txtNombreUsuario.Text = usuarioBuscado.NombreUsuario;
                txtPassword.Text = usuarioBuscado.Contraseña;
                txtMail.Text = usuarioBuscado.Mail;

            }
        }
        public void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Id = usuarioId,
                Nombre = this.txtNombre.Text,
                Apellido = this.txtApellido.Text,
                NombreUsuario = this.txtNombreUsuario.Text,
                Contraseña = this.txtPassword.Text,
                Mail = this.txtMail.Text,
            };

            string resultado = UsuarioService.ModificarUsuario(usuario);

            if (resultado == "true")
            {
                MessageBox.Show("Usuario modificado con éxito");
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
