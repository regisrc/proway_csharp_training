using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCoreCrudImoveis.Model;

namespace WebApiCoreCrudImoveis.Models
{
    public class WebApiCoreCrudImoveisContext : DbContext
    {
        public WebApiCoreCrudImoveisContext (DbContextOptions<WebApiCoreCrudImoveisContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiCoreCrudImoveis.Model.Imovel> Imovel { get; set; }

        public DbSet<WebApiCoreCrudImoveis.Model.Proprietario> Proprietario { get; set; }

        public DbSet<WebApiCoreCrudImoveis.Model.Usuario> Usuario { get; set; }
    }
}
