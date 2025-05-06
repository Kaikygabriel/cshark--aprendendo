using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  AgendamentoConsultas.Entity.DominioExceptions
;

namespace AgendamentoConsultas.Entity
{
    internal class Agenda
    {
        public Agenda() { }
        public Agenda(DateTime data, Medico doutor)
        {
            if (data < DateTime.Now)
            {
                throw new DominioException("Data marcada ja passou");
            }
            Data = data;
            Doutor = doutor;
        }
        public DateTime Data { get; set; }
        public Medico Doutor { get; set; }
        
    }
}
