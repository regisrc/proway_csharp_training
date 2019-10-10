using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class NomesContextDB : DbContext
    {
        public DbSet<Nomes> listaDeNomes { get; set; }  
    }
}
