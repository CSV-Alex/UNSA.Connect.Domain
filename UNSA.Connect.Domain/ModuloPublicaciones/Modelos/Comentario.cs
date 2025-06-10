using System;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.ModuloPublicaciones.Modelos
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Usuario Author { get; set; }
        public Publicacion Post { get; set; }

        public Comentario()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
