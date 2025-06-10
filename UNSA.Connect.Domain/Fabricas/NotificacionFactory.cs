using UNSA.Connect.ModuloNotificaciones.Modelos;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.Fabricas
{
    public static class NotificacionFactory
    {
        public static Notificacion Create(Usuario recipient, string message)
            => new Notificacion
            {
                Recipient = recipient,
                Message   = message
            };
    }
}
