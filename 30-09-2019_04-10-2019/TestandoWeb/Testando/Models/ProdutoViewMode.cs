using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testando.Models
{
    public class ProdutoViewMode
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double QtdEstoque { get; set; }
        public bool Ativo { get; set; }

    }
}
