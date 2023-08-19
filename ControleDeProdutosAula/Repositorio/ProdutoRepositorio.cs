using ControleDeProdutosAula.Data;
using ControleDeProdutosAula.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeProdutosAula.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public async Task<ProdutoModel> Adicionar(ProdutoModel produto)
        {
            await _bancoContext.Produto.AddAsync(produto);
            await _bancoContext.SaveChangesAsync();
            return produto;
        }

        public async Task<List<ProdutoModel>> BuscarTodos()
        {
            return await _bancoContext.Produto.ToListAsync();
        }
    }
}
