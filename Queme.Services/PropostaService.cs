using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine;
using RazorEngine.Templating;
using Queme.Models;
using System.Reflection.Metadata;
using Queme.Models.DTOs;


namespace Queme.Services
{
    public static class PropostaService
    {
        public static string GerarProposta(PropostaComercial propostaComercial)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            string path = Path.GetFullPath(Path.Combine("..", "..", "..", "Templates", "proposta.cshtml"));
            string cshtmlFile = LerArquivoCSHTML(path);
            string htmlContent = Engine.Razor.RunCompile(cshtmlFile, "templateKey", null, propostaComercial);

            return htmlContent;

        }

        public static string LerArquivoCSHTML(string caminho)
        {
            try
            {
                using (StreamReader reader = new StreamReader(caminho))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo {ex.Message}");
                return null;
            }
        }
    }
}
