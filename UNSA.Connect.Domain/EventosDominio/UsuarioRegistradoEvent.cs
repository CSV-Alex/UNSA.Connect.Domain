using System;

namespace UNSA.Connect.EventosDominio
{
    public class UsuarioRegistradoEvent
    {
        public int UserId { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
