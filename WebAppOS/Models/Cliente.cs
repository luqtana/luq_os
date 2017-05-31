using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public virtual ICollection<Chamado> Chamados { get; set; }


    }
}