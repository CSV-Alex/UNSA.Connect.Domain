using UNSA.Connect.ModuloGrupos.Modelos;

namespace UNSA.Connect.Repositorios
{
    public interface IGrupoRepositorio
    {
        void Add(Grupo group);
        Grupo GetById(int id);
    }
}
