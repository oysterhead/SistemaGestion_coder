using WinForms.ABMFormularios;
using WinForms.ABMFormularios.Formularios_Producto;
using WinForms.ABMFormularios.Formularios_ProdVend;
using WinForms.ABMFormularios.Venta_Producto;

namespace WinForms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMUsuario frmABMUsuario = new frmABMUsuario();
            frmABMUsuario.ShowDialog();
            this.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMProducto frmABMProducto = new frmABMProducto();
            frmABMProducto.ShowDialog();
            this.Show();

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMVenta frmABMVenta = new frmABMVenta();
            frmABMVenta.ShowDialog();
            this.Show();
        }

        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMProductoVendido frmABMProductoVendido = new ABMProductoVendido();
            frmABMProductoVendido.ShowDialog();
            this.Show();
        }
    }
}
