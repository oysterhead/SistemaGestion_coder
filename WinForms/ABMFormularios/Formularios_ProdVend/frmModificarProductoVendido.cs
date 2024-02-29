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
            if (!string.IsNullOrEmpty(id) )
            {
                int Id = Convert.ToInt32(id);
                ProductoVendido productoAMostrar = ProductoVendidoService.BuscarProductoVendidoPorId(Id);   
            }
            else { MessageBox.Show("Ingresar un ID válido."); }

        }
    }
}
