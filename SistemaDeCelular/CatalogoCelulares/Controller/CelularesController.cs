using CatalogoCelulares.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Controller
{
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();

        public IQueryable<Celular> GetCelulares() => contextDB.Celulares.Where(x => x.Ativo == true);

        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id);
            if (celular == null)
                return false;
            else
                celular = item;

            contextDB.SaveChanges();

            return true;
        }

        public bool DeletarCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id);
            if (celular == null)
                return false;

            celular.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }

        public bool InsertCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Preco <= 0)
                return false;
            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            return true;
        }
    }
}
