using System;
using System.Collections.Generic;

namespace UNSA.Connect.ModuloUsuarios.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Rol Affiliation { get; set; }
        public Perfil Profile { get; set; }

        public virtual ICollection<UNSA.Connect.ModuloGrupos.Modelos.Grupo> Groups { get; set; }
        public virtual ICollection<UNSA.Connect.ModuloNotificaciones.Modelos.Notificacion> Notifications { get; set; }

        public Usuario()
        {
            Profile       = new Perfil();
            Groups        = new List<UNSA.Connect.ModuloGrupos.Modelos.Grupo>();
            Notifications = new List<UNSA.Connect.ModuloNotificaciones.Modelos.Notificacion>();
        }
    }
}
