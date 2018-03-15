using Detetive.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Detetive.Aplicacao
{
    public class Jogo
    {
        EFContexto Contexto = new EFContexto();
        public RespostaModel GerarCaso()
        {
            Random rdSorteio = new Random();
            return new RespostaModel()
            {
                IdArma = Contexto.Armas.ToList().ElementAt(rdSorteio.Next(0, Contexto.Armas.Count())).Id,
                IdLocal = Contexto.Locais.ToList().ElementAt(rdSorteio.Next(0, Contexto.Locais.Count())).Id,
                IdSuspeito = Contexto.Suspeitos.ToList().ElementAt(rdSorteio.Next(0, Contexto.Suspeitos.Count())).Id
            };
        }

        public KeyValuePair<bool, string> ValidarCaso(RespostaModel resposta, RespostaModel resultado)
        {
            bool acertou = false;
            string mensagem = string.Empty;

            if (resposta.IdArma == resultado.IdArma && resposta.IdSuspeito == resultado.IdSuspeito && resposta.IdLocal == resultado.IdLocal)
            {
                acertou = true;
                mensagem = $"Parabéns! O assassino(a) foi {Contexto.Suspeitos.FirstOrDefault(f => f.Id == resposta.IdSuspeito).Descricao }, em {Contexto.Locais.FirstOrDefault(f => f.Id == resposta.IdLocal).Descricao }, com um(a) {Contexto.Armas.FirstOrDefault(f => f.Id == resposta.IdArma).Descricao }!";
            }
            else
            {
                acertou = false;
                mensagem = "Oh não!";

                List<string> lstErros = new List<string>();

                if (resposta.IdArma != resultado.IdArma)
                    lstErros.Add($"A arma {Contexto.Armas.FirstOrDefault(f => f.Id == resposta.IdArma).Descricao } está errada");

                if (resposta.IdLocal != resultado.IdLocal)
                    lstErros.Add($"O local {Contexto.Locais.FirstOrDefault(f => f.Id == resposta.IdLocal).Descricao } está errado");

                if (resposta.IdSuspeito != resultado.IdSuspeito)
                    lstErros.Add($"O assassino(a) {Contexto.Suspeitos.FirstOrDefault(f => f.Id == resposta.IdSuspeito).Descricao } está errado");

                Random rdSorteio = new Random();
                int valorSorteio = rdSorteio.Next(0, lstErros.Count());
                valorSorteio = valorSorteio <= 0 ? 0 : valorSorteio - 1;
                mensagem = lstErros.ElementAt(valorSorteio);
            }

            return new KeyValuePair<bool, string>(acertou, mensagem);
        }
    }
}
