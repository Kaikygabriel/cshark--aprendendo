using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefaPOO.Entity;
using GerenciadorTarefaPOO.Entity.EnumPasta;

namespace GerenciadorTarefaPOO.Controler
{
    internal class Function
    {
        static Usuario usuario = new Usuario();
        public static void AdicionarUsuario()
        {
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            usuario = new Usuario(nome);

        }        
        public static void AdicionarTarefa()
        {
            usuario.AdicionarTarefa();
        }
        public static void ListarTarefa()
        {
            usuario.ListarTarefa();
        }
    }
}
