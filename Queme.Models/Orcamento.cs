﻿using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class Orcamento
    {
        public StatusOrcamento Status { get; set; }
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public DateTime Data { get; set; }
        public double TaxaImposto { get; set; }
        public List<Servico> Servicos = new List<Servico>();
        public EnderecoServico Endereco { get; set; }
        public int IdTabelaDeCustos { get; set; }
        public string? ObsOrcamento { get; set; }

        public Orcamento()
        {
            Data = DateTime.Now;
            Status = StatusOrcamento.Pendente;
        }
        public Orcamento(int id_cliente, int idTabelaDeCustos)
        {
            Data = DateTime.Now;
            Status = StatusOrcamento.Pendente;
            Id_cliente = id_cliente;
            IdTabelaDeCustos = idTabelaDeCustos;
        }
        

        //To-do: Métodos da classe, valorTotal(), 

    }
}
