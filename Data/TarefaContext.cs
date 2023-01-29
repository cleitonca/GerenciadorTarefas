using GerenciadorTarefas.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) { }

        public DbSet<TarefaModel> Tarefas { get; set; }

    }
}
