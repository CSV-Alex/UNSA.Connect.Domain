using System.Collections.Generic;
using UNSA.Connect.ModuloPublicaciones.Modelos;

namespace UNSA.Connect.Repositorios
{
    public interface IComentarioRepositorio
    {
        void Add(Comentario comment);
        IEnumerable<Comentario> GetByPost(Publicacion post);
    }
}
