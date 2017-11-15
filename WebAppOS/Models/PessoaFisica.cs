using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class PessoaFisica : Pessoa
    {
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }
    }
}