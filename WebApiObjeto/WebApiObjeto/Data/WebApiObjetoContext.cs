using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiObjeto.Model;

namespace WebApiObjeto.Models
{
    public class WebApiObjetoContext : DbContext
    {
        public WebApiObjetoContext (DbContextOptions<WebApiObjetoContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiObjeto.Model.Objeto> Objeto { get; set; }
    }
}
