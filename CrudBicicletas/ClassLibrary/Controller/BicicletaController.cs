using ClassLibrary.Model;
using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controller
{
    public class BicicletaController
    {
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable<Bicicletas> GetBicicletas() => contextDB.listaDeBicicletas;

        public void ListBicicleta()
        {
            string stringBuild = "ID: {0,-3} Marca: {1,-20} Modelo: {2,-20} Valor: {3,-6}";
            contextDB.listaDeBicicletas
                .Where(i => i.Ativo == true)
                .OrderByDescending(a => a.Valor)
                .ToList<Bicicletas>()
                .ForEach(x => Console.WriteLine
                (string.Format
                (stringBuild,
                x.Id,
                x.Marca,
                x.Modelo,
                x.Valor.ToString("C3"))
                ));
            Console.WriteLine($"Valor total de todas as bikes: R${contextDB.listaDeBicicletas.Where(x => x.Ativo).Sum(i => (i.Valor)).ToString("C3")}");
        }

        public void AddBicicleta(Bicicletas bicicleta)
        {
            contextDB.listaDeBicicletas.Add(bicicleta);
            contextDB.SaveChanges();
        }

        public void GerarJSON()
        {

            string json = JsonConvert.SerializeObject(GetBicicletas().ToArray());
            json = $"{json}\nSoma total de todos os ativos: {GetBicicletas().Where(i => i.Ativo).Sum(a => a.Valor)}";
            System.IO.File.WriteAllText("C:\\Users\\hbsis\\Desktop\\arquivo.json", json);
        }

        public bool UpdateBicicleta(Bicicletas bicicleta)
        {
            var bike = contextDB.listaDeBicicletas.Find(bicicleta.Id);
            if (bike == null || bike.Ativo == false)
                return false;
            bike = bicicleta;
            contextDB.SaveChanges();
            return true;
        }

        public bool DeleteBicicleta(int id)
        {
            var bike = contextDB.listaDeBicicletas.Find(id);
            if (bike == null || bike.Ativo == false)
                return false;
            else
                bike.Ativo = false;
            contextDB.SaveChanges();
            return true;
        }
    }
}
