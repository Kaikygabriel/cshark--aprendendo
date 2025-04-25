
using SistemaEscolar.Entitis;

namespace SistemaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario Aluno = new Aluno(1,"Kaiky",17);
            Usuario Professor = new Professor("2020.4040","Gabriel",45);

            Aluno.Apresentar();
            Professor.Apresentar();
        }
    }
}
