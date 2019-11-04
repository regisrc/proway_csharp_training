using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace imobiliariaWebApi.Models
{
    public class Imovel : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int IdProprietario { get; set; } = 0;
    }
}