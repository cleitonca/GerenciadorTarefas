using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        public Task<bool> AdicionarTarefa(TarefaModel tarefa)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarTarefa(TarefaModel tarefa)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> ObterTarefaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TarefaModel>> ObterTodasTarefas()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverTarefa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
