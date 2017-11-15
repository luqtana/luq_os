using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppOS.Models
{
    public class Chamado
    {
        public int ChamadoId { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string NumeroChamado { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime DataHoraAbertura { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime? DataHoraConclusao { get; set; }
        [Display(Name = "Descrição do Chamado")]
        public string Observacao { get; set; }
        [Required(ErrorMessage = "Técnico é obrigatório")]
        [Display(Name = "Técnico")]
        public int TecnicoId { get; set; }
        public virtual Tecnico Tecnico{ get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Responsável")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string JustificativaCancelamento { get; set; }
        public virtual ICollection<HistoricoChamado> HistoricosChamados { get; set; }
        




    }
}