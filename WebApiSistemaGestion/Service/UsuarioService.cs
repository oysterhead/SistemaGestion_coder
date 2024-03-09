using Microsoft.EntityFrameworkCore;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public class UsuarioService
    {
        private CoderContext context;
        public UsuarioService(CoderContext context)
        {
            this.context = context;
        }

        public static string AgregarUsuario(Usuario usuario)
        {
            using(CoderContext context = new CoderContext())
            {
                try
                {
                    context.Add(usuario);
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }

                return "true";
            }
        }

        public static string ModificarUsuario(Usuario usuario)
        {
            using (CoderContext context = new CoderContext())
            {
                try
                {
                    context.Update(usuario);
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }

                return "true";

            }
        }

        public static string EliminarUsuario(int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                Usuario usuarioAEliminar = context.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
                if (usuarioAEliminar is not null)
                {
                    try
                    {
                        context.Usuarios.Remove(usuarioAEliminar);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return ex.ToString() ;
                    }
                }
                return "true";
            }
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> todosLosUsuarios = context.Usuarios.ToList();
            return todosLosUsuarios;
        }

        public static Usuario ObtenerUsuarioPorId(int Id)
        {
            using(CoderContext context = new CoderContext())
            {
                Usuario usuarioBuscado = context.Usuarios.Where(u =>u.Id == Id).FirstOrDefault();

                return usuarioBuscado;
            }
        }
    }
}
