using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.Controller
{
    public class NomesController
    {
        NomesContextDB contextDB = new NomesContextDB();

        public IQueryable<Nomes> getNomes()
        {
            return contextDB.listaDeNomes;
        }

        public void AddNome(Nomes nome)
        {
            contextDB.listaDeNomes.Add(nome);
            contextDB.SaveChanges();
        }
    }
}
