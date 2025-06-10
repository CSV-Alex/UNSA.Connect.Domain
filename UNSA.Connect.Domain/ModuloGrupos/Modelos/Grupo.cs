using System;
using System.Collections.Generic;
using UNSA.Connect.ModuloUsuarios.Modelos;
using UNSA.Connect.ModuloPublicaciones.Modelos;

namespace UNSA.Connect.ModuloGrupos.Modelos
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Usuario> Members { get; set; }
        public virtual ICollection<Publicacion> Posts { get; set; }

        public Grupo()
        {
            Members = new List<Usuario>();
            Posts   = new List<Publicacion>();
        }
    }
}
