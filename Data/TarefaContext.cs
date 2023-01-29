using GerenciadorTarefas.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data
{
    public class TarefaContext : DbContext
    {
        private string connectionString = "Server=tcp:<server>.database.windows.net,1433;Initial " +
            "Catalog=<database>;Persist Security Info=False;User ID=<username>;Password=<password>;" +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DbSet<TarefaModel> Tarefas { get; set; }

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
