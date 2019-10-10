using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class FloresContextDB : DbContext
    {
        public DbSet<Flores> ListaDeFlores { get; set; }
    }
}
