using BibioteclaOOP.Service;

namespace BibioteclaOOP.Entity
{
    public sealed class Usuario
    {
        public Usuario(){}
        public Usuario(string nome)
        {
            Nome = nome;
        }

        public string Id { get; private set; } = Guid.NewGuid().ToString()[..8].ToUpper();
        public string Nome { get; private set; } = string.Empty;
        public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
        public override string ToString()
        {
            return $"{Nome} -- {Id}";
        }
    }
}