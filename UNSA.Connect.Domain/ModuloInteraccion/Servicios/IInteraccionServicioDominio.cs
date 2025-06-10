using UNSA.Connect.ModuloUsuarios.Modelos;
using UNSA.Connect.ModuloPublicaciones.Modelos;
using UNSA.Connect.ModuloGrupos.Modelos;
using UNSA.Connect.ModuloNotificaciones.Modelos;

namespace UNSA.Connect.ModuloInteraccion.Servicios
{
    public interface IInteraccionServicioDominio
    {
        void Vista();
        void Registrarse(Usuario usuario);
        void PersonalizarPerfil(Usuario usuario, Perfil configuracion);
        void NotificarNoticias(Usuario usuario);
        void ModificarDatos(Usuario usuario, Perfil datos);
        void CrearGrupo(Grupo grupo);
        void CrearPublicacion(Publicacion publicacion);
        void UnirseAGrupo(Usuario usuario, Grupo grupo);
        void VisualizarTrabajos(Usuario usuario);
        void ComentarEvento(Usuario usuario, Comentario comentario);
        void CompartirEvento(Publicacion publicacion);
        void NotificarPost(Usuario usuario, Notificacion notificacion);
        void SolicitarIdeas(Usuario usuario);
    }
}
