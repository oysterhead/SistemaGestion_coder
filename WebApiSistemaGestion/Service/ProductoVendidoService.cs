using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public class ProductoVendidoService
    {

        private CoderContext context;

        public ProductoVendidoService(CoderContext context)
        {
            this.context = context;
        }
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            using(CoderContext context = new CoderContext())
            {
                List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
                productosVendidos = context.ProductoVendidos.ToList();
                
                return productosVendidos;

            }
        }

        public static bool NuevoProductoVendido (ProductoVendido vendido)
        {
            using(CoderContext context = new CoderContext())
            {
                context.ProductoVendidos.Add(vendido);
                context.SaveChanges();

                return true;
            }
        }

        public static bool EliminarProductoVendidoPorId (int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                ProductoVendido productoVendidoAEliminar = context.ProductoVendidos.Where(pv => pv.Id == Id).FirstOrDefault();
                if (productoVendidoAEliminar is not null)
                {
                    context.ProductoVendidos.Remove(productoVendidoAEliminar);
                    context.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        public static ProductoVendido BuscarProductoVendidoPorId(int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                ProductoVendido productoEncontrado = context.ProductoVendidos.Where(pv => pv.Id == Id).FirstOrDefault();

                return productoEncontrado;
            }
        }

        public static bool ModificarProductoVendidoPorId(ProductoVendido productoVendido)
        {
            using(CoderContext context = new CoderContext())
            {
                context.Update(productoVendido);
                context.SaveChanges();

                return true;
            }
        }

        public List<ProductoVendido> BuscarProductosDelUsuario(Usuario usuario)
        {
            return this.context.Venta
                .Where(v => v.IdUsuario == usuario.Id)
                .SelectMany(v => v.ProductoVendidos)
                .ToList();
        }
    }
}
