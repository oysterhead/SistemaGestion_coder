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
    public partial class frmABMVenta : Form
    {
        public frmABMVenta()
        {
            InitializeComponent();
        }


        private void ActualizarDgv(object objeto)
        {
            this.dgvDatosVenta.DataSource = null;
            this.dgvDatosVenta.DataSource = objeto;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNuevaVenta frmNuevaVenta = new frmNuevaVenta();
            frmNuevaVenta.ShowDialog();
            this.Show();
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            List<Venta> listarVentas = VentaService.ListarTodasLasVentas();
            this.ActualizarDgv(listarVentas);

        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarVenta frmModificar = new frmModificarVenta();
            frmModificar.ShowDialog();
            this.Show();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            string id = txtBuscarVenta.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                int Id = Convert.ToInt32(id);
                Venta ventaBuscada = VentaService.ObtenerVentaPorId(Id);
                this.ActualizarDgv(ventaBuscada);
            }

            else { MessageBox.Show("Debe ingresar un Id de venta a buscar"); }

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            string id = txtBuscarVenta.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                int Id = Convert.ToInt32(id);
                bool resultado = VentaService.EliminarVentaPorId(Id);
                if (resultado)
                {
                    MessageBox.Show($"Venta con ID {Id} eliminado.");
                }
                else { MessageBox.Show("Producto NO ELIMINADO."); }
            }
            else { MessageBox.Show($"El Id ingresado {id} no existe"); }

            
        }
    }
}
