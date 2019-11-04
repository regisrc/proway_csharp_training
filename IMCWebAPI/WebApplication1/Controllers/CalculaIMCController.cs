using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculaIMCController : ApiController
    {
        public string Get(double peso, double altura, string nome)=> $"Olá {nome} seu imc é {peso / (altura * altura)} e ele foi calculado de acordo com sua Altura:{altura} e Peso:{peso}";
    }
}
