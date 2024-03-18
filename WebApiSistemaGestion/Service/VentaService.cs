using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public class VentaService
    {
        private CoderContext context;
        readonly ProductoVendidoService productoVendidoService;
        readonly ProductoService productoService;

        public VentaService(CoderContext context, ProductoVendidoService productoVendidoService)
        {
            this.context = context;
            this.productoVendidoService = productoVendidoService;
            this.productoService = productoService;
        }

        public bool NuevaVenta(int IdUsuario, List<ProductoDTO> productoDTO)
        {
            Venta nuevaVenta = new Venta();
            List<string> nombreDeProductos = productoDTO.Select(p => p.Descripciones).ToList();
            string comentarios = string.Join(", ", nombreDeProductos);
            nuevaVenta.Comentarios = comentarios;
            nuevaVenta.IdUsuario = IdUsuario;

            try
            {
                context.Add(nuevaVenta);
                context.SaveChanges();
            }
            catch (Exception ex) { return false; }
            this.MarcarComoProductosVendidos(productoDTO, nuevaVenta.Id);
            this.ActualizarStockDeLosProductosVendidos(productoDTO);

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

        private void MarcarComoProductosVendidos(List<ProductoDTO> productoDTO, int IdVenta)
        {
            productoDTO.ForEach(p =>
            {
                ProductoVendidoDTO productoVendidoDTO = new ProductoVendidoDTO();
                productoVendidoDTO.IdProducto = p.Id;
                productoVendidoDTO.IdVenta = IdVenta;
                productoVendidoDTO.Stock = p.Stock;

                this.productoVendidoService.NuevoProductoVendido(productoVendidoDTO);
            });
        }
        private void ActualizarStockDeLosProductosVendidos (List<ProductoDTO> productoDTO)
        {
            List<Producto> productos = new List<Producto>();

            productoDTO.ForEach(p => 
            {
                Producto productoActual = ProductoMapper.MapearAProducto(p);
                productoActual = this.productoService.BuscarProductoPorId(p.Id);
                productoActual.Stock -= p.Stock;
                ProductoDTO nuevoProductoDTOMenosStock = ProductoMapper.MapearADTO(productoActual);
                this.productoService.ModificarProductoPorId(nuevoProductoDTOMenosStock, productoActual.Id);

            });
        }
    }
}
