using Microsoft.EntityFrameworkCore;

namespace DadosContato.Models
{
    public class TodosContatos : DbContext
    {
        public TodosContatos(DbContextOptions<TodosContatos> options)
            : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}