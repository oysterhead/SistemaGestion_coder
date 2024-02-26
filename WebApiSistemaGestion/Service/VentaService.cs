using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public class VentaService
    {
        public static bool NuevaVenta(Venta venta)
        {
            using(CoderContext context = new CoderContext())
            {
                context.Add(venta);
                context.SaveChanges();
                return true;
            }
        }

        public static List<Venta> ListarTodasLasVentas()
        {
            using(CoderContext context = new CoderContext())
            {
                List<Venta> todasLasVentas = context.Venta.ToList();
                return todasLasVentas;
            }
        }

        public static Venta ObtenerVentaPorId (int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                Venta ventaBuscada = context.Venta.Where(v  => v.Id == Id).FirstOrDefault();
                return ventaBuscada;

            }
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
    }
}
