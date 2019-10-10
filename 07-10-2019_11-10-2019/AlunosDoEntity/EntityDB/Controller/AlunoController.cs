using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDB.Model;

namespace EntityDB.Controller
{
    public class AlunoController
    {
        EntityContextDB contextDB = new EntityContextDB();
        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.listaDeAlunos;
        }

        public void AddAlunos(Aluno aluno)
        {
            contextDB.listaDeAlunos.Add(aluno);

            contextDB.SaveChanges();
        }
    }
}
