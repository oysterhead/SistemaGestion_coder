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

namespace WinForms.ABMFormularios.Formularios_ProdVend
{
    public partial class frmModificarProductoVendido : Form
    {
        public frmModificarProductoVendido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin guardar cambios...");
            this.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtIdProductoVendido.Text;
            if (!string.IsNullOrEmpty(id))
            {
                int Id = Convert.ToInt32(id);
                ProductoVendido productoAMostrar = ProductoVendidoService.BuscarProductoVendidoPorId(Id);
                if (productoAMostrar != null)
                {
                    txtStock.Text = productoAMostrar.Stock.ToString();
                    txtIdProducto.Text = productoAMostrar.IdProducto.ToString();
                    txtIdVenta.Text = productoAMostrar.IdVenta.ToString();
                }
                else { MessageBox.Show($"Producto con Id nro {Id} no encontrado..."); }
            }
            else { MessageBox.Show("Ingresar un ID válido."); }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoVendido productoAModificar = new ProductoVendido()
            {
                Id = Convert.ToInt32(txtIdProductoVendido.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                IdProducto = Convert.ToInt32(txtIdProducto.Text),
                IdVenta = Convert.ToInt32(txtIdVenta.Text)
            };

            bool resultado = ProductoVendidoService.ModificarProductoVendidoPorId(productoAModificar);
            if (resultado)
            {
                MessageBox.Show("Se ha modificado el producto vendido");
            }
            else { MessageBox.Show("Ha ocurrido un error, no se pudo modificar el producto vendido"); }

            this.Close();
        }
    }
}
