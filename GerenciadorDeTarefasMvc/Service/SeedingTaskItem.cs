using GerenciadorDeTarefasMvc.Data;
using GerenciadorDeTarefasMvc.Models;

namespace GerenciadorDeTarefasMvc.Service
{
    public class SeedingTaskItem
    {
        private readonly TaskContext _context;
        public SeedingTaskItem(TaskContext context)
        {
            _context = context;
        }
        public  void Seed()
        {
            if (_context.Tasks.Any())
                return;
            var t1 = new TaskItem(1, "Fazer arquivos", "Terminar de fazer arquivos csv");
            var t2 = new TaskItem(2, "Fazer Exercicios", "Parar de ser vagabundo e fazer algo");

            _context.AddRange(t1, t2);
            _context.SaveChanges();
        }
    }
}
