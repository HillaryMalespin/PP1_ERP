using PP2_ERP.Modelos;

namespace PP2_ERP.Repositorio.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        ICollection<Usuario> GetUsuarios();
        Usuario GetUsuario(int CedulaId);
        bool ExisteUsuario(int Cedula);
        bool ExisteUsuario(String Nombre);
        bool CrearUsuario(Usuario usuario);
        bool ActualizarUsuario(Usuario usuario);
        bool BorrarUsuario(Usuario usuario);
    }
}
