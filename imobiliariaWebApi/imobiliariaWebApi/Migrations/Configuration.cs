namespace imobiliariaWebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<imobiliariaWebApi.Models.ImobiliariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(imobiliariaWebApi.Models.ImobiliariaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Proprietarios.AddOrUpdate(i => i.Nome, new Models.Proprietario()
            {
                Nome = "Filipe Eduardo Regis",
                Email = "filipe.regis@hbsis.com.br",
                DataNascimento = new DateTime(2000, 05, 10)
            });

            context.SaveChanges();

            context.Imoveis.AddOrUpdate(i => i.Bairro, new Models.Imovel()
            {
                Bairro = "Ponta Aguda",
                Cep = "89050-130",
                Complemento = "Shell",
                IdProprietario = 1,
                Logradouro = "Rua mexico",
                Municipio = "Blumenau",
                Numero = "507"               
            });

            context.SaveChanges();
        }
    }
}
