using UNSA.Connect.ModuloPublicaciones.Modelos;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.Fabricas
{
    public static class PublicacionFactory
    {
        public static Publicacion Create(TipoPublicacion type, string title, string content, Usuario author)
            => new Publicacion
            {
                Type   = type,
                Title  = title,
                Content= content,
                Author = author
            };
    }
}
