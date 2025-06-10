using UNSA.Connect.ModuloPublicaciones.Modelos;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.Fabricas
{
    public static class ComentarioFactory
    {
        public static Comentario Create(string content, Usuario author, Publicacion post)
            => new Comentario
            {
                Content= content,
                Author = author,
                Post   = post
            };
    }
}
