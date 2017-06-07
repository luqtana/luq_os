using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class HistoricoChamado
    {
        public int HistoricoChamadoId { get; set; }
        public DateTime DataRegistro { get; set; }
        public Status Status { get; set; }
        public int ChamadoId { get; set; }
        public virtual Chamado Chamado { get; set; }

    }
}