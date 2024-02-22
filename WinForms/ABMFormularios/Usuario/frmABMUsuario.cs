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
    public partial class frmABMUsuario : Form
    {
        public frmABMUsuario()
        {
            InitializeComponent();
        }

        private void ActualizarDgv(object objeto)
        {
            this.dgvDatos.DataSource = null;
            this.dgvDatos.DataSource = objeto;
        }

        public void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
            this.Show();
        }

        public void btnModificarUsuario_Click(Object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarioMod frmUsuarioMod = new frmUsuarioMod();
            frmUsuarioMod.ShowDialog();
            this.Show();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();
            this.ActualizarDgv(usuarios);

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string id = txtBuscarUsuario.Text;
            if (id != "")
            {
                int Id = Convert.ToInt32(id);
                Usuario usuarioBuscado = UsuarioService.ObtenerUsuarioPorId(Id);
                List<Usuario> lista = new List<Usuario>() { usuarioBuscado };
                this.ActualizarDgv(lista);
            }
            else
            {
                MessageBox.Show("Debe ingresar un ID");
            }

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string id = txtEliminarUsuario.Text;
            if (id != "")
            {
                int Id = Convert.ToInt32(id);
                string resultado = UsuarioService.EliminarUsuario(Id);
                if(resultado != null)
                {
                    MessageBox.Show($"El usuario con ID {Id} fue eliminado");
                }

                List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();
                this.ActualizarDgv(usuarios);

            }
            else
            {
                MessageBox.Show("Debe ingresar un ID");
            }

        }
    }
}
