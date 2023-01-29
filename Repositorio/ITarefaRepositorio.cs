using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Repositorio
{
    public interface ITarefaRepositorio
    {
        Task<IEnumerable<TarefaModel>> ObterTodasTarefas();

        Task<TarefaModel> ObterTarefaPorId(int id);

        Task<bool> AdicionarTarefa(TarefaModel tarefa);

        Task<bool> AtualizarTarefa(TarefaModel tarefa);

        Task<bool> RemoverTarefa(int id);

       
    }
}
