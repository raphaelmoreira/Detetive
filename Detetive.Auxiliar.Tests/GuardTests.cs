using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Detetive.Auxiliar.Tests
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ParaNuloOuVazio_Erro_Quando_Branco_Ou_Vazio()
        {
            Guard.ParaNuloOuVazio("", "valor não pode ser vazio");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ParaNuloOuVazio_Erro_Quando_Nulo()
        {
            Guard.ParaNuloOuVazio(null, "valor não pode ser nulo");
        }
    }
}
