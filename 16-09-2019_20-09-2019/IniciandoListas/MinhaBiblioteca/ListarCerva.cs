using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListarCerva
    {
        public void ListarCerveja()
        {
            var listaCerveja = new List<string>();
            listaCerveja.Add("Original");
            listaCerveja.Add("Skol");
            listaCerveja.Add("Budweiser");
            listaCerveja.Add("Brahma");
            listaCerveja.ForEach(i => Console.WriteLine(i));
        }
    }
}
