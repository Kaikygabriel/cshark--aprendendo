using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filme.Entidade.Enum;

namespace Filme.Entidade
{
    internal class Filme
    {
        public Filme(string titulo, TimeSpan duracao, Categoria categoriaFilme)
        {
            Titulo = titulo;
            Duracao = duracao;
            CategoriaFilme = categoriaFilme;
        }

        public string Titulo { get;private set; }
        public TimeSpan Duracao { get;private set; }
        public Categoria CategoriaFilme { get;private set; }

        public override string ToString()
        {
            return $"O filme {Titulo} tem a categoria {CategoriaFilme} ea duração de {Duracao.Minutes}Min";
        }
    }
}
