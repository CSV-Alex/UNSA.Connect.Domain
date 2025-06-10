using System.Collections.Generic;
using UNSA.Connect.ModuloPublicaciones.Modelos;

namespace UNSA.Connect.Repositorios
{
    public interface IPublicacionRepositorio
    {
        void Add(Publicacion post);
        Publicacion GetById(int id);
        IEnumerable<Publicacion> GetByType(TipoPublicacion type);
    }
}
