using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Mapper
{
    public static class VentaMapper
    {
        public static Venta MapearAVenta(VentaDTO ventaDTO)
        {
            Venta venta = new Venta();
            venta.Id = ventaDTO.Id;
            venta.Comentarios = ventaDTO.Comentarios;
            venta.IdUsuario = ventaDTO.IdUsuario;

            return venta;
        }

        public static VentaDTO MapearADTO(Venta venta)
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaDTO.Id = venta.Id;
            ventaDTO.Comentarios = venta.Comentarios;
            ventaDTO.IdUsuario = venta.IdUsuario;

            return ventaDTO;
        }
    }
}
