using ControleDeProdutosAula.Data;
using ControleDeProdutosAula.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeProdutosAula.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public async Task<ClienteModel> Adicionar(ClienteModel cliente)
        {
            await _bancoContext.Cliente.AddAsync(cliente);
            await _bancoContext.SaveChangesAsync();

            return await Task.FromResult(cliente);
        }

        public async Task<List<ClienteModel>> BuscarTodos()
        {
            return await _bancoContext.Cliente.ToListAsync();
        }
    }
}