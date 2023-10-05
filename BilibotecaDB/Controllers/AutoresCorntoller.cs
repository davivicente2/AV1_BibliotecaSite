using BibliotecaDB.model.Models;
using BibliotecaDB.model.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BibliotecaDB.View.Controllers
{
    public class AutoresController : Controller
    {
        private readonly RepositoryAutores _repositoryAutores;

        public AutoresController(RepositoryAutores repositoryAutores)
        {
            _repositoryAutores = repositoryAutores;
        }

        public async Task<IActionResult> Index()
        {
            var listaAutores = await _repositoryAutores.SelecionarTodosAsync();
            return View(listaAutores);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Autores autor)
        {
            if (ModelState.IsValid)
            {
                await _repositoryAutores.IncluirAsync(autor);
                // Adicione o código abaixo para redirecionar para a ação Index do controlador Autores
                return RedirectToAction("Index", "Autores", new RepositoryAutores());
            }
            // Se o modelo não for válido, volte para a view de criação com os erros de validação
            return View(autor);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var autor = await _repositoryAutores.SelecionarPkAsync(id);
            if (autor == null)
            {
                return NotFound(); // Autor não encontrado
            }
            return View(autor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Autores autor)
        {
            if (ModelState.IsValid)
            {
                var resultado = await _repositoryAutores.AlterarAsync(autor);
                if (resultado == null)
                {
                    return NotFound(); // Autor não encontrado
                }
                // Adicione o código abaixo para redirecionar para a ação Index do controlador Autores
                return RedirectToAction("Index", "Autores", new RepositoryAutores());
            }
            // Se o modelo não for válido, volte para a view de edição com os erros de validação
            return View(autor);
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var detalhes = await _repositoryAutores.SelecionarPkAsync(id);
            if (detalhes == null)
            {
                return NotFound(); // Autor não encontrado
            }
            return View(detalhes);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var detalhes = await _repositoryAutores.SelecionarPkAsync(id);

            return View(detalhes);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Autores autores)
        {
            var oAutor = await _repositoryAutores.SelecionarPkAsync(autores.AutorId);
            await _repositoryAutores.ExcluirAsync(oAutor);
            return RedirectToAction("Index");
        }
    }
}
