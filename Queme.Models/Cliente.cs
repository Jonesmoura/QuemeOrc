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
        public string Email { get; set; }
        public string Tel { get; set; }
        public string razaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }

        // teste endereço

        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

    }
}
