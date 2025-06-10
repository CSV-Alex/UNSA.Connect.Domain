using System;
using System.Collections.Generic;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.ModuloPublicaciones.Modelos
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public TipoPublicacion Type { get; set; }
        public Usuario Author { get; set; }

        public virtual ICollection<Comentario> Comments { get; set; }

        public Publicacion()
        {
            Comments  = new List<Comentario>();
            CreatedAt = DateTime.UtcNow;
        }
    }
}
