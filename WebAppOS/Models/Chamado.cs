using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOS.Models
{
    public class Chamado
    {
        public int ChamadoId { get; set; }
        public DateTime DataHoraAbertura { get; set; }
        public DateTime? HoraHoraAtendimento { get; set; }
        public DateTime? DataHoraConclusao { get; set; }
        public DateTime DataHoraPrevisaoDeConclusao { get; set; }
        public int TecnicoId { get; set; }
        public virtual Tecnico Tecnico{ get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public string JustificativaCancelamento { get; set; }
        public virtual ICollection<HistoricoChamado> HistoricosChamados { get; set; }
        




    }
}