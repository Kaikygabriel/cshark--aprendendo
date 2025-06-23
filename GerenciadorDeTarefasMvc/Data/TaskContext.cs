using GerenciadorDeTarefasMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasMvc.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> option) : base(option)
        { }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
