using GerenciadorDeTarefasMvc.Data;
using GerenciadorDeTarefasMvc.Models;

namespace GerenciadorDeTarefasMvc.Service
{
    public class ServiceDataTask
    {
        private readonly TaskContext _taskContext;
        public ServiceDataTask(TaskContext taskContext)
        {
            _taskContext= taskContext;
        }
        public List<TaskItem> FindAll()
            => _taskContext.Tasks.ToList();
    }
}
