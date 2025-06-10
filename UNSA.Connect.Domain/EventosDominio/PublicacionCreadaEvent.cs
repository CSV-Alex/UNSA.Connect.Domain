using System;

namespace UNSA.Connect.EventosDominio
{
    public class PublicacionCreadaEvent
    {
        public int PostId { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
