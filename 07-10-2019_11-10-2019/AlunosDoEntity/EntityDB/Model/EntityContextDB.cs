using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDB.Model
{
    public class EntityContextDB : DbContext
    {
        public DbSet<Aluno> listaDeAlunos { get; set; }
    }
}
