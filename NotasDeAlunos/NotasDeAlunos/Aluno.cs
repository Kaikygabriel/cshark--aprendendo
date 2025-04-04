using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasDeAlunos
{
    [System.Serializable]
    internal class Aluno
    {
        public string nome;
        public int nota;
        public int nota2;   
        public int nota3;
        public bool aprovado;
        public Aluno(string nome, int nota, int nota2, int nota3)
        {
            if(Testar(nota,nota2,nota3))
            this.nome = nome;
            this.nota = nota;
            this.nota2 = nota2;
            this.nota3 = nota3;
            Aprovado();
        }
        public void Aprovado()
        {
            int NotaFinal = 3/(nota + nota2 + nota3);
            if(NotaFinal >= 5)
            {
                aprovado = true;
            }
            else
            {
                aprovado = false;
            }
        }
        public bool Testar(int n,int n2 ,int n3)
        {
            try
            {
                if (n <= 10 && n >= 0 && n2 <= 10 && n2 >= 0 && n3 <= 10 && n3 >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void exibir()
        {
            if(aprovado)
            {
                Console.WriteLine($"O Aluno {nome}, esta Aprovado !");
            }
            else
            {
                Console.WriteLine($"O Aluno {nome}, esta Reprovado !");

            }
        }
    }
}

