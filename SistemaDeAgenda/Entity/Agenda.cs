using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemaDeAgenda.Entity
{
    public sealed class Agenda
    {
        public Agenda() { }
        public List<Contato> Numeros { get; private set; } = new List<Contato>();
        //metodos para poder modificar a Lista/Matrix 
        
}
}