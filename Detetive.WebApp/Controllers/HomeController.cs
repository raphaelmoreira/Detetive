using Detetive.Aplicacao;
using Detetive.Repositorio;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Detetive.WebApp.Controllers
{
    public class HomeController : Controller
    {
        EFContexto Contexto = new EFContexto();
        public ActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.resposta = new RespostaModel();
            model.lstArmas = Contexto.Armas.ToList();
            model.lstLocais = Contexto.Locais.ToList();
            model.lstSuspeitos = Contexto.Suspeitos.ToList();

            Random rdSorteio = new Random();
            System.Web.HttpContext.Current.Session["resultado"] = new Jogo().GerarCaso();

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}