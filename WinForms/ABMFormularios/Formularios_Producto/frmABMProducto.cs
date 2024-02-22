using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiSistemaGestion.Service;
using WebApiSistemaGestion.Models;

namespace WinForms.ABMFormularios.Formularios_Producto
{
    public partial class frmABMProducto : Form
    {
        public frmABMProducto()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNuevoProducto frmNuevoProducto = new frmNuevoProducto();
            frmNuevoProducto.ShowDialog();
            this.Show();
        }

        private void ActualizarDgv(object objeto)
        {
            this.dgvDatosProducto.DataSource = null;
            this.dgvDatosProducto.DataSource = objeto;
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoService.ListarProductos();
            this.ActualizarDgv(productos);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarProducto frmModificarProducto = new frmModificarProducto();
            frmModificarProducto.ShowDialog();
            this.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string id = txtBuscarProducto.Text;
            if (!string.IsNullOrEmpty(id))
            {
                int Id = Convert.ToInt32(id);
                Producto productoBuscado = ProductoService.BuscarProductoPorId(Id);
                List<Producto> productos = new List<Producto> { productoBuscado };
                this.ActualizarDgv(productos);
            }
            else { MessageBox.Show("Debe ingresar un ID valido"); }

        }

        private void txtEliminarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoService.ListarProductos();
            this.ActualizarDgv(productos);
            string id = txtEliminarProducto.Text;
            if (!string.IsNullOrEmpty(id))
            {
                int Id = Convert.ToInt32(id);
                bool resultado = ProductoService.EliminarProducto(Id);
                if(resultado)
                {
                    MessageBox.Show($"Producto con ID Nro {Id} eliminado con éxito.");
                }
                else { MessageBox.Show($"No se pudo eliminar el producto con ID nro {Id}"); }

                List<Producto> todosLosProductos = ProductoService.ListarProductos();
                this.ActualizarDgv(todosLosProductos);
            }
            else { MessageBox.Show("Debe ingresar un ID valido"); }
        }
    }
}
