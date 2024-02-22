using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WinForms.ABMFormularios.Formularios_Producto
{
    public partial class frmModificarProducto : Form
    {
        private int IdProducto = 0;
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        public frmModificarProducto(Producto producto) : this()
        {
            this.txtDescripciones.Text = producto.Descripciones;
            this.txtCosto.Text = producto.Costo.ToString();
            this.txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            this.txtStock.Text = producto.Stock.ToString();
            this.txtIdUsuario.Text = producto.IdUsuario.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            if (!string.IsNullOrEmpty(id))
            {
                int Id = Convert.ToInt32(id);
                this.IdProducto = Id;

            }
            else { MessageBox.Show("Debe ingresar un ID para buscar"); }

            Producto productoBuscado = ProductoService.BuscarProductoPorId(IdProducto);
            if (productoBuscado is not null)
            {
                txtDescripciones.Text = productoBuscado.Descripciones;
                txtCosto.Text = productoBuscado.Costo.ToString();
                txtPrecioVenta.Text = productoBuscado.PrecioVenta.ToString();
                txtStock.Text = productoBuscado.Stock.ToString();
                txtIdUsuario.Text = productoBuscado.IdUsuario.ToString();
            }
            else
            {
                MessageBox.Show($"Producto con ID nro {IdProducto} no encontrado");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                Descripciones = txtDescripciones.Text,
                Costo = Convert.ToDecimal(txtCosto.Text),
                PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                IdUsuario = Convert.ToInt32(txtIdUsuario)
            };

            bool resultado = ProductoService.ModificarProductoPorId(producto, IdProducto);
            if (resultado)
            {
                MessageBox.Show($"El producto con ID nro {IdProducto} se modificó con éxito");
            }
            else { MessageBox.Show("No se pudo modificar el producto deseado"); }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin guardar cambios");
            this.Close();
        }
    }
}
