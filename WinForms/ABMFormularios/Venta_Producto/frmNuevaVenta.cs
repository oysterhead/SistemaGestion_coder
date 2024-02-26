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
    public partial class frmNuevaVenta : Form
    {
        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Venta nuevaVenta = new Venta();
            nuevaVenta.Comentarios = this.txtDescripcionVenta.Text;
            nuevaVenta.IdUsuario = Convert.ToInt32(this.txtIdUsuario.Text);

            bool resultado = VentaService.NuevaVenta(nuevaVenta);
            if (resultado)
            {
                MessageBox.Show("Nueva venta registrada");
            }
            else { MessageBox.Show("No fue posible agregar una nueva venta. Verifique que el IdUsuario exista"); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin registrar venta nueva");
            this.Close();
        }
    }
}
