using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Mapper
{
    public static class ProductoMapper
    {
        public static Producto MapearAProducto(ProductoDTO productoDTO)
        {
            Producto producto = new Producto();
            producto.Id = productoDTO.Id;
            producto.Descripciones = productoDTO.Descripciones;
            producto.Costo = productoDTO.Costo;
            producto.PrecioVenta = productoDTO.PrecioVenta;
            producto.Stock = productoDTO.Stock;
            producto.IdUsuario = productoDTO.IdUsuario;

            return producto;
        }

        public static ProductoDTO MapearADTO(Producto producto)
        {
            ProductoDTO productoDTO = new ProductoDTO();
            productoDTO.Id = producto.Id;
            productoDTO.Descripciones = producto.Descripciones;
            productoDTO.Costo = producto.Costo;
            productoDTO.PrecioVenta = producto.PrecioVenta;
            productoDTO.Stock = producto.Stock;
            productoDTO.IdUsuario = producto.IdUsuario;

            return productoDTO;
        }
    }
}
