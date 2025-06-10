using UNSA.Connect.ModuloUsuarios.Modelos;
using UNSA.Connect.ModuloPublicaciones.Modelos;
using UNSA.Connect.ModuloGrupos.Modelos;
using UNSA.Connect.ModuloNotificaciones.Modelos;

namespace UNSA.Connect.ModuloInteraccion.Servicios
{
    public class InteraccionServicioDominio : IInteraccionServicioDominio
    {
        public void Vista() { }
        public void Registrarse(Usuario usuario) { }
        public void PersonalizarPerfil(Usuario usuario, Perfil configuracion) { }
        public void NotificarNoticias(Usuario usuario) { }
        public void ModificarDatos(Usuario usuario, Perfil datos) { }
        public void CrearGrupo(Grupo grupo) { }
        public void CrearPublicacion(Publicacion publicacion) { }
        public void UnirseAGrupo(Usuario usuario, Grupo grupo) { }
        public void VisualizarTrabajos(Usuario usuario) { }
        public void ComentarEvento(Usuario usuario, Comentario comentario) { }
        public void CompartirEvento(Publicacion publicacion) { }
        public void NotificarPost(Usuario usuario, Notificacion notificacion) { }
        public void SolicitarIdeas(Usuario usuario) { }
    }
}
