namespace GerenciadorDeTarefasMvc.Models
{
    public class TaskItem
    {
        public TaskItem() { }

        public TaskItem(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public int Id { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }
    }
}
