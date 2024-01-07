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


    }
}
