using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Mapper
{
    public static class ProductoVendidoMapper
    {
        public static ProductoVendido MapearAProductoVendido(ProductoVendidoDTO productoVendidoDTO)
        {
            ProductoVendido productoVendido = new ProductoVendido();
            productoVendido.Id = productoVendidoDTO.Id;
            productoVendido.Stock = productoVendidoDTO.Stock;
            productoVendido.IdProducto = productoVendidoDTO.IdProducto;
            productoVendido.IdVenta = productoVendidoDTO.IdVenta;

            return productoVendido;
        }

        public static ProductoVendidoDTO MapearADTO(ProductoVendido productoVendido)
        {
            ProductoVendidoDTO productoVendidoDTO = new ProductoVendidoDTO();
            productoVendidoDTO.Id = productoVendido.Id;
            productoVendidoDTO.Stock = productoVendido.Stock;
            productoVendidoDTO.IdProducto = productoVendido.IdProducto;
            productoVendidoDTO.IdVenta = productoVendido.IdVenta;

            return productoVendidoDTO;
        }
    }
}
