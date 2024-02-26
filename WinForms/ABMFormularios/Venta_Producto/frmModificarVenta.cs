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
    public partial class frmModificarVenta : Form
    {
        public frmModificarVenta()
        {
            InitializeComponent();
        }

        public frmModificarVenta(Venta venta): this()
        {
            this.txtDescripciones.Text = venta.Comentarios;
            this.txtIdUsuario.Text = venta.IdUsuario.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo sin modificar venta...");
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            int Id = Convert.ToInt32(id);

            Venta ventaBuscada = VentaService.ObtenerVentaPorId(Id);
            if (ventaBuscada is not null)
            {
                this.txtId.Text = ventaBuscada.Id.ToString();
                this.txtDescripciones.Text = ventaBuscada.Comentarios;
                this.txtIdUsuario.Text = ventaBuscada.IdUsuario.ToString();
            }

            else { MessageBox.Show($"Id {Id} no encontrado..."); }

            Venta ventaAModificar = new Venta()
            {
                Id = Convert.ToInt32(txtId.Text),
                Comentarios = txtDescripciones.Text,
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text)

            };

            bool resultado = VentaService.ModificarVentaPorId(ventaAModificar, Id);
            if (resultado)
            {
                MessageBox.Show($"Venta ID {Id} modificada con éxito");

            }
            else { MessageBox.Show("Venta no modificada."); }
        }   
    }
}
