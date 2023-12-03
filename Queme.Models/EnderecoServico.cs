using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
     public class EnderecoServico
    {
        public int Id { get; set; }
        public int IdOrcamento { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }

        public EnderecoServico(int idOrcamento, string cep, int numero, string complemento)
        {
            IdOrcamento = idOrcamento;
            CEP = cep;
            Numero = numero;
            Complemento = complemento;
        }

        public EnderecoServico(int idOrcamento, string cep, int numero)
        {
            IdOrcamento = idOrcamento;
            CEP = cep;
            Numero = numero;
        }




    }
}
