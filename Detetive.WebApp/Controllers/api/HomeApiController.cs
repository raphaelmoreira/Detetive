using Detetive.Aplicacao;
using Detetive.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Detetive.WebApp.Controllers.api
{
    public class HomeApiController : ApiController
    {
        EFContexto Contexto = new EFContexto();
        public bool Get(int? id)
        {
            System.Web.HttpContext.Current.Session["resultado"] = new Jogo().GerarCaso();
            return true;
        }

        public HttpResponseMessage Post([FromBody] RespostaModel resposta)
        {
            RespostaModel resultado = System.Web.HttpContext.Current.Session["resultado"] as RespostaModel;
            var Resultado = new Jogo().ValidarCaso(resposta, resultado);

            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                acertou = Resultado.Key,
                mensagem = Resultado.Value
            });
        }
    }
}
