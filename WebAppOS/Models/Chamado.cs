using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Chamado
    {
        public int ChamadoId { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime HoraAbertura { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime HoraAtendimento { get; set; }
        public DateTime DataConclusao { get; set; }
        public DateTime HoraConclusao { get; set; }
        public virtual Tecnico Tecnico{ get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empresa Empresa { get; set; }




    }
}