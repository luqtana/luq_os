using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Tecnico
    {
        public int TecnicoId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }
        public virtual ICollection<Chamado> Chamados { get; set; }
    }
}