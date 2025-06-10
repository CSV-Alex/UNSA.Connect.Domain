using System;

namespace UNSA.Connect.EventosDominio
{
    public class ComentarioAgregadoEvent
    {
        public int CommentId { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
