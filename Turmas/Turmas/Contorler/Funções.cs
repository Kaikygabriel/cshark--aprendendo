using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turmas.Entidade;

namespace Turmas.Contorler
{
    internal class Funções
    {
        static Turma turma = new Turma();
        public static void Adicionar()
        {
            turma.AdicionarAluno();
        }   
        public static void Listar()
        {
            turma.ListarAluno();
        }

    }
}
