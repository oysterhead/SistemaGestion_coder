using Microsoft.EntityFrameworkCore;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public class ProductoService
    {
        private CoderContext context;

        public ProductoService(CoderContext context)
        {
            this.context = context;
        }

        public bool EliminarProducto(int Id)
        {
            Producto productoAEliminar = context.Productos.Include(p => p.ProductoVendidos).Where(p => p.Id == Id).FirstOrDefault();

            if (productoAEliminar is not null)
            {
                context.Productos.Remove(productoAEliminar);
                context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public List<Producto> ListarProductos()
        {
            using(CoderContext context = new CoderContext())
            {
                List<Producto> listaDeProductos = new List<Producto>();
                listaDeProductos = context.Productos.ToList();

                return listaDeProductos;
            }
        }

        public bool NuevoProducto(ProductoDTO productoDTO)
        {
            Producto producto = ProductoMapper.MapearAProducto(productoDTO);
            context.Productos.Add(producto);
            context.SaveChanges();
            return true;
            
        }

        public Producto BuscarProductoPorId(int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                Producto producto = context.Productos.Where(p => p.Id == Id).FirstOrDefault();

                return producto;

            }
        }

        public bool ModificarProductoPorId(Producto producto, int Id)
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
