using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
        public string Tel { get; set; }
        public string razaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }

    }
}
