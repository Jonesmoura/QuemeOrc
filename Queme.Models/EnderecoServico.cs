using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
     public class EnderecoServico
    {
        public int IdOrcamento { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
