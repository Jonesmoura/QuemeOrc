using Queme.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class PropostaComercial
    {
        public DateTime DataDeGeracao { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public string observacao { get; set; }
        public Dictionary<string,decimal> SubTotalDisciplina { get; set; } = new Dictionary<string,decimal>(); //criar método de calculo
        public Dictionary<string, string> ObservacoesDisciplina { get; set; } = new Dictionary<string, string>();
        public List<CondicaoDePagamento> CondicaoDePagamentos { get; set; } = new List<CondicaoDePagamento>();
        public decimal ValorTotal { get; set; }
        public ReadOrcamentoDto orcamento { get; set; }

    }
}
