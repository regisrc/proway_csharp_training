using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class EntityContextDB : DbContext
    {
        public DbSet<Bicicletas> listaDeBicicletas { get; set; }
    }
}
