using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class ValidacaoDeDados
    {
        public static bool validacaoInputQuery(string input)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+$");

            return regex.IsMatch(input);
        }
    }
}
