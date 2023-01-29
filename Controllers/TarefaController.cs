using GerenciadorTarefas.Models;
using GerenciadorTarefas.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Controllers
{
    public class TarefaController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        public async Task<IActionResult> Tarefas()
        {
            IEnumerable<TarefaModel> tarefas = await _tarefaRepositorio.ObterTodasTarefas();

            return View(tarefas);
        }


    }
}
