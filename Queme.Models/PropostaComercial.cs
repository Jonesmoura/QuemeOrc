using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class PropostaComercial
    {
        public Cliente Cliente { get; set; }
        public DateTime DataDeGeracao { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public string observacao { get; set; }
        public Dictionary<string,decimal> SubTotalDisciplina { get; set; } = new Dictionary<string,decimal>();
        public Dictionary<string, string> ObservacoesDisciplina { get; set; } = new Dictionary<string, string>();
        public List<CondicaoDePagamento> CondicaoDePagamentos { get; set; } = new List<CondicaoDePagamento>();

    }
}
