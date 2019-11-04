using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BancoDeDadosInnerJoinWebApi.Models;

namespace BancoDeDadosInnerJoinWebApi.Controllers
{
    public class VendasController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Vendas
        public IQueryable<Vendas> GetVendas()
        {
            return db.Vendas;
        }

        // GET: api/Vendas/5
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult GetVendas(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return NotFound();
            }

            return Ok(vendas);
        }

        [HttpGet]
        [Route("Api/Vendas/QueryAno")]
        public object CustomVendasOnCarros()
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Vendas/QueryAno/{ano}")]
        public object CustomVendasOnCarros(int ano)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  where ano == ven.DatInc.Year
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Vendas/QueryAno/{usuario}/{ano}")]
        public object CustomVendasOnCarros(int ano,int usuario)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  where ano == ven.DatInc.Year
                                  && usuario == ven.UsuInc 
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year,
                                      Usuario = usu.Usuario
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Carroes/MaisVendas/{marca}/{ano}")]
        public object CustomMaisVendas(string marca, int ano)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();
            var listaDeMarcas = db.Marcas.ToList();


            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  join mar in listaDeMarcas
                                  on car.Marca equals mar.Id
                                  where marca == mar.Nome
                                  orderby ven.Valor descending
                                  where ano == ven.DatInc.Year

                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year,
                                      Marca = mar.Nome,
                                      Valor = ven.Valor

                                  };
            return conteudoRetorno;
        }

        // PUT: api/Vendas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVendas(int id, Vendas vendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendas.Id)
            {
                return BadRequest();
            }

            db.Entry(vendas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Vendas
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult PostVendas(Vendas vendas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vendas.Add(vendas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vendas.Id }, vendas);
        }

        // DELETE: api/Vendas/5
        [ResponseType(typeof(Vendas))]
        public IHttpActionResult DeleteVendas(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return NotFound();
            }

            db.Vendas.Remove(vendas);
            db.SaveChanges();

            return Ok(vendas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendasExists(int id)
        {
            return db.Vendas.Count(e => e.Id == id) > 0;
        }
    }
}