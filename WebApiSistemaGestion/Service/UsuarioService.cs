using Microsoft.EntityFrameworkCore;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
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

        public bool AgregarUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = UsuarioMapper.MapearAUsuario(usuarioDTO);
            try
            {
                context.Add(usuario);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool ModificarUsuario(int Id, UsuarioDTO usuarioDTO)
        {
            Usuario usuarioAModificar = context.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
            if (usuarioAModificar is not null)
            {
                usuarioAModificar = UsuarioMapper.MapearAUsuario(usuarioDTO);
                context.Usuarios.Update(usuarioAModificar);
                context.SaveChanges();
                return true;
            }

            else { return false; }
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

        public Usuario ObtenerUsuarioPorId(int Id)
        {
            Usuario usuarioBuscado = context.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
            if(usuarioBuscado is not null)
            {
                return usuarioBuscado;
            }
            else { return null; }            
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            Usuario usuarioBuscado = context.Usuarios.Where(u => u.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuarioBuscado is not null)
            {
                return usuarioBuscado;
            }
            else { return null; }
        }

        public Usuario ObtenerUsuarioPorUsuarioYPassword(string usuario, string password)
        {
            Usuario usuario1= context.Usuarios.Where(u => u.NombreUsuario == usuario).FirstOrDefault();
            usuario1 = context.Usuarios.Where(u => u.Contraseña == password).FirstOrDefault();
            if (usuario1 is not null)
            {
                return usuario1;
            }
            else { return null; }
        }
    }
}
