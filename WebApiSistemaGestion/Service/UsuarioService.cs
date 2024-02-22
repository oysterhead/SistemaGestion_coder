using Microsoft.EntityFrameworkCore;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Models;

namespace WebApiSistemaGestion.Service
{
    public static class UsuarioService
    {
        /*
         Usuario Services será la capa que se encargará de gestionar el ABM correspondiente del usuario.

        TODO -> Refactorizar las partes de try catch ya que siempre hago lo mismo, solo cambia la acción sobre la base
        Se podría hacer un context.+"accion"
         */

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

        public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            using(CoderContext context = new CoderContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();

                return usuarios;
            }
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
