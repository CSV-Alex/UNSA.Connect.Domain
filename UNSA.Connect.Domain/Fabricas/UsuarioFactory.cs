using UNSA.Connect.ModuloUsuarios.Modelos;

namespace UNSA.Connect.Fabricas
{
    public static class UsuarioFactory
    {
        public static Usuario Create(string name, string email, Rol affiliation)
            => new Usuario
            {
                Name        = name,
                Email       = email,
                Affiliation = affiliation
            };
    }
}
