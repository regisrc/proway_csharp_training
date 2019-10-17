using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();

        public IQueryable<Flores> GetFlores() => contextDB.ListaDeFlores;

        public void AddFlores(Flores flor)
        {
            contextDB.ListaDeFlores.Add(flor);

            contextDB.SaveChanges();
        }
    }
}
