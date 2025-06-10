using System;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.ModuloNotificaciones.Modelos
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
        public Usuario Recipient { get; set; }

        public Notificacion()
        {
            CreatedAt = DateTime.UtcNow;
            IsRead    = false;
        }
    }
}
