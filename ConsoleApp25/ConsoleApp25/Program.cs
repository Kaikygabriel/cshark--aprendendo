using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {   
        enum alunoOp {add = 1,ver,remove}
        enum op {aluno = 1,prof}
        static void Main()
        {
            Console.WriteLine("LOGIN \n 1-aluno \n 2-professor");
            op sele = (op)int.Parse(Console.ReadLine());

            switch (sele) 
            {
                case op.aluno:
                    Console.Clear();
                    Console.WriteLine("1 - adicionar aluno \n 2 -ver alunos \n 3- remover");
                    alunoOp seleAluno = (alunoOp)int.Parse(Console.ReadLine());
                    switch (seleAluno)
                    {
                        case alunoOp.ver:
                            Aluno.verAluno();
                            break;
                        case alunoOp.add:
                            Aluno.adicinar();
                            break;
                        case alunoOp.remove:
                            Aluno.remove();
                            break;
                    }
                    break;
            }
        }
    }
}
