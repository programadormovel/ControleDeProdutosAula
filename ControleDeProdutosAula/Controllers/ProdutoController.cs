using ControleDeProdutosAula.Models;
using ControleDeProdutosAula.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeProdutosAula.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }   

        public async Task<IActionResult> Index() {
            List<ProdutoModel> produtos = await _produtoRepositorio.BuscarTodos();
            return await Task.FromResult(View(produtos)); 
        } 

        public async Task<IActionResult> Criar() { 
            return await Task.FromResult(View());
        }

        public async Task<IActionResult> Editar(long id) {

            ProdutoModel produto = await _produtoRepositorio.ListarPorId(id);

            return await Task.FromResult(View(produto));
        }

        public async Task<IActionResult> ApagarConfirmacao(long id) {
            ProdutoModel produto = await _produtoRepositorio.ListarPorId(id);

            return await Task.FromResult(View(produto)); 
        }

        public async Task<IActionResult> Apagar(long id)
        {
            await _produtoRepositorio.Apagar(id);
            return await Task.FromResult(RedirectToAction("Index"));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(ProdutoModel produto)
        {
            ProdutoModel model = produto;
            model.DataDeRegistro = DateTime.Now;
            await _produtoRepositorio.Adicionar(model);
            return await Task.FromResult(RedirectToAction("Index"));
        }

		[HttpPost]
		public async Task<IActionResult> Alterar(ProdutoModel produto)
		{
			await _produtoRepositorio.Atualizar(produto);
			return await Task.FromResult(RedirectToAction("Index"));
		}


	}
}
