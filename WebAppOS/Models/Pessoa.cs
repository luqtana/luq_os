using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Site { get; set; }
        public virtual ICollection<Chamado> Chamados { get; set; }

    }
}