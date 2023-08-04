using EscolaID.Data;
using EscolaID.Models;
using EscolaID.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace EscolaID.Repositorios
{
    public class EscolaRepositorio : IEscolaRepositorio
    {
        private readonly EscolaIdDBContex _dbContext;
        public EscolaRepositorio(EscolaIdDBContex escolaIdDBContex)
        {
            _dbContext = escolaIdDBContex;
        }
        public async Task<EscolaModel> Buscar(int id)
        {
            return await _dbContext.Escolas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<EscolaModel>> BuscarTodasEscolas()
        {
            return await _dbContext.Escolas.ToListAsync();
        }

        public async Task<EscolaModel> Adicionar(EscolaModel escola)
        {
            await _dbContext.Escolas.AddAsync(escola);
            await _dbContext.SaveChangesAsync();

            return escola;
        }

        public async Task<EscolaModel> Atualizar(EscolaModel escola, int id)
        {
            EscolaModel findEscola = await Buscar(id);
            if(findEscola == null)
            {
                throw new Exception("Não foi encontrado esse usuário");
            }

            findEscola.Nome = escola.Nome;
            findEscola.Endereco = escola.Endereco;
            findEscola.Contato = escola.Contato;

            _dbContext.Escolas.Update(findEscola);
            await _dbContext.SaveChangesAsync();
            return findEscola;

        }

        public async Task<bool> Deletar(int id)
        {
            EscolaModel findEscola = await Buscar(id);

            if (findEscola == null)
            {
                throw new Exception("Não foi encontrado esse usuário");
            }
            _dbContext.Escolas.Remove(findEscola);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
