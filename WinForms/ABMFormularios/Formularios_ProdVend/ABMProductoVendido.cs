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
using WinForms.ABMFormularios.Venta_Producto;

namespace WinForms.ABMFormularios.Formularios_ProdVend
{
    public partial class ABMProductoVendido : Form
    {
        public ABMProductoVendido()
        {
            InitializeComponent();
        }

        public void ActualizarDGV(object objecto)
        {
            this.dgvDatosProductosVendidos.DataSource = null;
            this.dgvDatosProductosVendidos.DataSource = objecto;
        }

        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaProductoVendido frmAltaProductoVendido = new frmAltaProductoVendido();
            frmAltaProductoVendido.ShowDialog();
            this.Show();
        }

        private void btnListarProductosVendidos_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> productoVendidos = ProductoVendidoService.ListarProductosVendidos();
            this.ActualizarDGV(productoVendidos);

        }

        private void btnModificarProductoVendido_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarProductoVendido frmModificarProductoVendido = new frmModificarProductoVendido();
            frmModificarProductoVendido.ShowDialog();
            this.Show();
        }
    }
}
