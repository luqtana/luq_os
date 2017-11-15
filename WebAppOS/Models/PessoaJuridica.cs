using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class PessoaJuridica : Pessoa
    {
        [Required(ErrorMessage = "CNPJ é obrigatório")]
        public string CNPJ { get; set; }
    }
}