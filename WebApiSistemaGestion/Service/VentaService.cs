using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public class VentaService
    {
        private CoderContext context;

        public VentaService(CoderContext context)
        {
            this.context = context;
        }

        public bool NuevaVenta(VentaDTO ventaDTO)
        {
            Venta nuevaVenta = VentaMapper.MapearAVenta(ventaDTO);
            try
            {
                context.Add(nuevaVenta);
                context.SaveChanges();
            }
            catch (Exception ex) { return false; }

            return true;
        }

        public static List<Venta> ListarTodasLasVentas()
        {
            using(CoderContext context = new CoderContext())
            {
                List<Venta> todasLasVentas = context.Venta.ToList();
                return todasLasVentas;
            }
        }

        public Venta ObtenerVentaPorId (int Id)
        {
            Venta ventaBuscada = context.Venta.Where(v  => v.Id == Id).FirstOrDefault();
            return ventaBuscada;

        }

        public static bool ModificarVentaPorId(Venta venta, int Id)
        {

            using(CoderContext context = new CoderContext())
            {
                Venta ventaAModificar = context.Venta.Where(p => p.Id == Id).FirstOrDefault();
                if (ventaAModificar is not null)
                {
                    context.Update(ventaAModificar);
                    context.SaveChanges();
                    return true;
                }

                else
                {
                    return false;
                }
            }

        }

        public static bool EliminarVentaPorId(int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                Venta ventaAEliminar = context.Venta.Where(v => v.Id == Id).FirstOrDefault();
                if (ventaAEliminar is not null)
                {
                    context.Remove(ventaAEliminar);
                    context.SaveChanges();
                    return true;
                }

                else { return false; }
            }
        }

        public List<Venta> ObtenerVentasDelUsuario(int IdUsuario)
        {
            List<Venta> ventasBuscadas = context.Venta.Where(v => v.IdUsuario == IdUsuario).ToList();
            return ventasBuscadas;
        }
    }
}
