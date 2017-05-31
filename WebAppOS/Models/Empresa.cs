using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string Endereço { get; set; }
        public virtual ICollection<Chamado> Chamados { get; set; }


    }
}