using EscolaID.Models;

namespace EscolaID.Repositorios.Interface
{
    public interface IEscolaRepositorio
    {
        Task<List<EscolaModel>> BuscarTodasEscolas();
        Task<EscolaModel> Buscar(int id);
        Task<EscolaModel> Adicionar(EscolaModel escola);
        Task<EscolaModel> Atualizar(EscolaModel usuario, int id);
        Task<bool> Deletar(int id);
    }
}
