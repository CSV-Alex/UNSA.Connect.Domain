using System;

namespace UNSA.Connect.EventosDominio
{
    public class NotificacionEnviadaEvent
    {
        public int NotificationId { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
