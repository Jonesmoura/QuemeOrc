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
        public DateTime Data { get; set; }
        public double TaxaImposto { get; set; }
        public List<Servico> Servicos = new List<Servico>();

        //To-do: Métodos da classe, valorTotal(), 

    }
}