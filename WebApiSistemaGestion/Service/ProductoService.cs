using Microsoft.EntityFrameworkCore;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public static class ProductoService
    {
        public static bool EliminarProducto(int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto productoAEliminar = context.Productos.Include(p => p.ProductoVendidos).Where(p => p.Id == Id).FirstOrDefault();

                if (productoAEliminar is not null)
                {
                    context.Productos.Remove(productoAEliminar);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static List<Producto> ListarProductos()
        {
            using(CoderContext context = new CoderContext())
            {
                List<Producto> listaDeProductos = new List<Producto>();
                listaDeProductos = context.Productos.ToList();

                return listaDeProductos;
            }
        }

        public static bool NuevoProducto(Producto producto)
        {
            using(CoderContext context = new CoderContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
                return true;
            }
        }

        public static Producto BuscarProductoPorId(int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                Producto producto = context.Productos.Where(p => p.Id == Id).FirstOrDefault();

                return producto;

            }
        }

        public static bool ModificarProductoPorId(Producto producto, int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto productoAModificar = context.Productos.Where(p => p.Id == Id).FirstOrDefault();
                if (productoAModificar is not null)
                {
                    context.Update(productoAModificar);
                    context.SaveChanges();
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }
    }
}
