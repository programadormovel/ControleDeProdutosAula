using ControleDeProdutosAula.Models;

namespace ControleDeProdutosAula.Repositorio
{
    public interface IProdutoRepositorio
    {
        Task<List<ProdutoModel>> BuscarTodos();
        Task<ProdutoModel> Adicionar(ProdutoModel produto);

    }
}
