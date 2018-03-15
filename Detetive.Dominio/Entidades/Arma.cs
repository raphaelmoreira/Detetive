using Detetive.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Dominio.Entidades
{
    public class Arma : EntidadeBase
    {
        public const int DescricaoMaximoPermitido = 50;
        public string Descricao { get; private set; }
        protected Arma()
        {

        }

        public Arma(int id)
        {
            if (id == 0)
                throw new Exception("código não pode ser zero");
            else if(id >= 100)
                throw new Exception("código não existe");
        }

        public Arma(int id, string descricao)
        {
            if (id == 0)
                throw new Exception("código não pode ser zero");
            else if (id >= 100)
                throw new Exception("código não existe");

            SetDescricao(descricao);
        }

        public void SetDescricao(string descricao)
        {
            Guard.ParaNuloOuVazio(descricao, "descrição não pode ser vazia");
            Guard.MaximoPermitido(descricao, DescricaoMaximoPermitido, $"máximo de: {DescricaoMaximoPermitido}");
            Descricao = descricao;
        }
    }
}
