using System.Collections.Generic;
using UNSA.Connect.ModuloNotificaciones.Modelos;
using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.Repositorios
{
    public interface INotificacionRepositorio
    {
        void Add(Notificacion notification);
        IEnumerable<Notificacion> GetByUser(Usuario user);
    }
}
