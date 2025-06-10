using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.Repositorios
{
    public interface IUsuarioRepositorio
    {
        void Add(Usuario user);
        void Update(Usuario user);
        Usuario GetById(int id);
    }
}
