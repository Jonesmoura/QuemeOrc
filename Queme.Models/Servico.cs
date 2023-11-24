using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class Servico
    {
        public int Id_orcamento { get; set; }
        public TipoServico TipoServico { get; set; }
        public EtapasServico Etapa { get; set; }
        public int Qtd_horas { get; set; }
        public double ValorHora { get; set; }
        public double TotalServico { get; set; }

        public Servico()
        {
        }

        public Servico(int id_orcamento, int qtd_horas, TipoServico tipoServico, EtapasServico etapa, double valorHora, double totalServico)
        {
            Id_orcamento = id_orcamento;
            Qtd_horas = qtd_horas;
            TipoServico = tipoServico;
            Etapa = etapa;
            ValorHora = valorHora;
            TotalServico = totalServico;
        }
    }
}
