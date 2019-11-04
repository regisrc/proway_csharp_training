using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace imobiliariaWebApi.Models
{
    public class Proprietario : UserControls
    {
        [Key]
        public int Id { get; set; }
        [CustomValidator("Nome")]
        public string Nome { get; set; }
        [CustomValidator("DataNascimento")]
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }

    }
}