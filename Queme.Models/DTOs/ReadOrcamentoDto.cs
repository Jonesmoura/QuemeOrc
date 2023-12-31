﻿using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models.DTOs
{
    public class ReadOrcamentoDto
    {
        public int Id { get; set; }
        public StatusOrcamento Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Nome { get; set; }
        public double TaxaImposto { get; set; }
        public string? ObsOrcamento { get; set; }

        public decimal ValorTotal { get; set; }

        public List<Servico> Servicos { get; set; } = new List<Servico>();
        public List<CustoAdicional> CustosAdicionais { get; set; } = new List<CustoAdicional>();
        public List<CondicaoDePagamento> CondicaoDePagamentos { get; set; } = new List<CondicaoDePagamento>();
        public Cliente? Cliente { get; set; }
        public int IdTabelaDeCustos { get; set; }
        public EnderecoServico? EnderecoObra { get; set; }

    }
}
