using Detetive.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Detetive.Aplicacao
{ 
    public class IndexModel
    {
        public List<Arma> lstArmas { get; set; }
        public List<Local> lstLocais { get; set; }
        public List<Suspeito> lstSuspeitos { get; set; }
        public RespostaModel resposta { get; set; }
    }

    public class RespostaModel
    {
        public int IdArma { get; set; }
        public int IdLocal { get; set; }
        public int IdSuspeito { get; set; }
    }
}