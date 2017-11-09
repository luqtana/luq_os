using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Tecnico
    {
        public int TecnicoId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public virtual ICollection<Chamado> Chamados { get; set; }
    }
}