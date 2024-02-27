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

namespace WinForms.ABMFormularios.Venta_Producto
{
    public partial class frmAltaProductoVendido : Form
    {
        public frmAltaProductoVendido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin registar producto vendido...");
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoVendido productoVendido = new ProductoVendido()
            {
                Stock = Convert.ToInt32(txtStock.Text),
                IdProducto = Convert.ToInt32(txtIdProducto.Text),
                IdVenta = Convert.ToInt32(txtIdVenta.Text),
            };

            bool resultado = ProductoVendidoService.NuevoProductoVendido(productoVendido);
            if (resultado)
            {
                MessageBox.Show("Producto vendido registrado con éxito");
            }
            else { MessageBox.Show("Ha ocurrido un problema. Producto Vendido no registrado"); }
            
            this.Close();
        }
    }
}
