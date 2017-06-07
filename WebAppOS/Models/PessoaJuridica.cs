using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}