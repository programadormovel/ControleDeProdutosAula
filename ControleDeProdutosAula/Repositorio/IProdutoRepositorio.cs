using ControleDeProdutosAula.Models;

namespace ControleDeProdutosAula.Repositorio
{
    public interface IProdutoRepositorio
    {
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel produto);

    }
}
