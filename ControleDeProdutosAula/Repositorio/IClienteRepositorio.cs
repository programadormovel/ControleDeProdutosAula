using ControleDeProdutosAula.Models;

namespace ControleDeProdutosAula.Repositorio
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> BuscarTodos();
        Task<ClienteModel> Adicionar(ClienteModel cliente);
    }
}
