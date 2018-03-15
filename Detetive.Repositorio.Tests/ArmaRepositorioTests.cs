using Detetive.Dominio.Entidades;
using Detetive.Dominio.IRepositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Repositorio.Tests
{
    [TestClass]
    public class ArmaRepositorioTests
    {
        private readonly IArmaRepositorio _armaRepositorio;
        private readonly ListaRepositorio<Arma> _repositorio;

        public ArmaRepositorioTests()
        {
            _repositorio = new ListaRepositorio<Arma>(ArmaRepositorioTestsDados.Adquirir());
            _armaRepositorio = new ArmaRepositorio(_repositorio);
        }

        [TestMethod]
        public void ArmaRepositorio_Arma_Existe()
        {
            var arma = _repositorio.Adquirir(1);
            Assert.AreEqual(arma, _armaRepositorio.Adquirir(arma.Id));
        }

        [TestMethod]
        public void ArmaRepositorio_Arma_Nao_Existe()
        {
            var existe = _armaRepositorio.Adquirir(0);
            Assert.IsNull(existe);
        }
    }
}
