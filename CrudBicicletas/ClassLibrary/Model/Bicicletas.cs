using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Bicicletas
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Modelo { get; set; }
        [MaxLength(50)]
        [Required]
        public string Marca { get; set; }
        [Required]
        public double Valor { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
