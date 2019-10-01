using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListaCarros
    {
        public void ListarMarcas()
        {
            var listaMarcas = new List<string>();
            listaMarcas.Add("Renault");
            listaMarcas.Add("Fiat");
            listaMarcas.Add("Citroen");
            listaMarcas.Add("Ferrari");
            listaMarcas.Add("BMW");
            listaMarcas.ForEach(i => Console.WriteLine(i));
        }
    }
}
