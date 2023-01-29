using GerenciadorTarefas.Data;
using GerenciadorTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly TarefaContext _tarefaContext;

        public TarefaRepositorio(TarefaContext tarefaContext)
        {
            _tarefaContext = tarefaContext;
            
        }

        public async Task<bool> AdicionarTarefa(TarefaModel tarefa)
        {
            try
            {
                // Adicionar a tarefa ao contexto do banco de dados
                _tarefaContext.Tarefas.Add(tarefa);

                // Salvar as alterações no banco de dados
                await _tarefaContext.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao adicionar a tarefa: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> AtualizarTarefa(TarefaModel tarefa)
        {
            try
            {
                // Recupera a tarefa a ser atualizada
                var tarefaExistente = await _tarefaContext.Tarefas.FindAsync(tarefa.Id);

                // Atualiza as informações da tarefa
                tarefaExistente.Titulo = tarefa.Titulo;
                tarefaExistente.Descricao = tarefa.Descricao;
                tarefaExistente.DataInicio = tarefa.DataInicio;
                tarefaExistente.DataFim = tarefa.DataFim;
                tarefaExistente.TarefaCompleta = tarefa.TarefaCompleta;

                // Salva as alterações no banco de dados
                await _tarefaContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Registra o erro ocorrido
                // Retorna false para indicar que a atualização não foi realizada com sucesso
                Console.WriteLine("Ocorreu um erro ao atualizar a tarefa: " + ex.Message);
                return false;
            }
        }

        public async Task<TarefaModel> ObterTarefaPorId(int id)
        {
            // Buscar a tarefa correspondente ao id fornecido na base de dados
            TarefaModel tarefa = await _tarefaContext.Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            // Retornar a tarefa encontrada ou null, caso não tenha sido encontrada
            return tarefa;
        }

        public async Task<IEnumerable<TarefaModel>> ObterTodasTarefas()
        {
            return await _tarefaContext.Tarefas.ToListAsync();
        }


        public async Task<bool> RemoverTarefa(int id)
        {
            var tarefa = await _tarefaContext.Tarefas.FindAsync(id);

                if (tarefa == null)
                    return false;

                _tarefaContext.Tarefas.Remove(tarefa);
                var resultado = await _tarefaContext.SaveChangesAsync();

                return resultado > 0;
        }
        

    }
}
