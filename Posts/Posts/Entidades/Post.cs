using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Entidades
{
    internal class Post
    {
        public Post(DateTime moment, string titulo, string texto, int likes)
        {
            Moment = moment;
            Titulo = titulo;
            Texto = texto;
            Likes = likes;
        }
        public DateTime Moment { get; set; }
        public string Titulo { get; set; }
        public string Texto {  get; set; }
        public int Likes { get; set; }
        List<Comentario> comentarios { get; set; } = new List<Comentario>();
        public void AddComentario()
        {
            Console.WriteLine("Escreva o comentario ");
            string texto = Console.ReadLine().Trim();
            comentarios.Add(new Comentario(texto));
        }
        public override string ToString()
        {
            //StringBuilder serve para quando precisamos concatenar muitas coisas, ou ler um laço de repetição junto com o texto
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Texto);
            sb.AppendLine("Comentarios");
            foreach(Comentario c in comentarios)
            {
                sb.AppendLine(c.Nome);
            }
            return sb.ToString();
        }
    }
}
