using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public enum Status
    {
        [Display(Name = "Aberto")]
        Aberto = 1,
        [Display(Name = "Em atendimento")]
        EmAtendimento = 2,
        [Display(Name = "Finalizado")]
        Finalizado = 3,
        [Display(Name = "Cancelado")]
        Cancelado = 4
    }
}