using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsAppTesteAPINetCoreTreinamento
{
    public class Ceps
    {
        public int Id { get; set; }
        
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }

}
