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
            List<Producto> listaDeProductos = new List<Producto>();
            listaDeProductos = context.Productos.ToList();

            return listaDeProductos;
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
            Producto producto = context.Productos.Where(p => p.Id == Id).FirstOrDefault();
            if(producto is not null)
            {
                return producto;
            }
            else { return null; }
        }

        public bool ModificarProductoPorId(ProductoDTO productoDTO, int Id)
        {
            Producto productoAModificar = context.Productos.Where(p => p.Id == Id).FirstOrDefault();
            if (productoAModificar is not null)
            {
                productoAModificar = ProductoMapper.MapearAProducto(productoDTO);
                context.Productos.Update(productoAModificar);
                context.SaveChanges();
                return true;
            }

            else { return false; }
        }
    }
}
