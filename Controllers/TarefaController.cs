using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Tarefas()
        {
            return View();
        }
    }
}
