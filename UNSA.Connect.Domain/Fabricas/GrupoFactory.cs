using UNSA.Connect.ModuloGrupos.Modelos;

namespace UNSA.Connect.Fabricas
{
    public static class GrupoFactory
    {
        public static Grupo Create(string name, string description)
            => new Grupo
            {
                Name        = name,
                Description = description
            };
    }
}
