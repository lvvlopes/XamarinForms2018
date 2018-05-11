using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            var novoEnderecoURL = string.Format(EnderecoURL, cep);

            var webClient = new WebClient();
            var conteudo = webClient.DownloadString(novoEnderecoURL);

            var endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return endereco;
        }
   
    }
}
