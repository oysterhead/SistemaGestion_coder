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

namespace WinForms.ABMFormularios.Formularios_Producto
{
    public partial class frmNuevoProducto : Form
    {
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        public Producto NuevoProducto { get; private set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                Descripciones = this.txtDescripciones.Text,
                Costo = Convert.ToDecimal(this.txtCosto.Text),
                PrecioVenta = Convert.ToDecimal(this.txtPrecioVenta.Text),
                Stock = Convert.ToInt32(this.txtStock.Text),
                IdUsuario = Convert.ToInt32(this.txtIdUsuario.Text),
            };

            this.NuevoProducto = producto;
            if (NuevoProducto != null)
            {
                bool respuesta = ProductoService.NuevoProducto(NuevoProducto);
                if (respuesta)
                {
                    MessageBox.Show("Producto agregado con éxito");
                    this.Close();
                }
                else { MessageBox.Show("No se pudo agregar el nuevo producto"); }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin guardar cambios...");
            this.Close();
        }
    }
}
