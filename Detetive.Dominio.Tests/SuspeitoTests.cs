using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Detetive.Dominio.Entidades;

namespace Detetive.Dominio.Tests
{
    [TestClass]
    public class SuspeitoTests
    {
        private string Descricao { get; set; }

        public SuspeitoTests()
        {
            Descricao = "nenhum";
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Suspeito_Nova_Suspeito_Id_Zerado()
        {
            var Suspeito = new Suspeito(0);
        }

        [TestMethod]
        public void Suspeito_Nova_Suspeito_Valida()
        {
            var Suspeito = new Suspeito(1);
            Assert.IsTrue(Suspeito != null, "Suspeito existe");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Suspeito_Nova_Suspeito_Invalida()
        {
            var Suspeito = new Suspeito(100);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Suspeito_Nova_Descricao_Nula()
        {
            new Suspeito(1, null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Suspeito_Nova_Descricao_Vazia()
        {
            new Suspeito(1, "");
        }


        [TestMethod]
        public void Suspeito_Nova_Descricao_Atribuido()
        {
            var Suspeito = new Suspeito(1, Descricao);
            Assert.AreEqual(Descricao, Suspeito.Descricao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Suspeito_Nova_Descricao_Maximo_Permitido_Invalido()
        {
            new Suspeito(1, "shjkshdfkjshdkfhsdkjfhskdjfhsjkdfhksjhfksjdhfsjkdhfskjdhfskjdfhsdkjfhskldfjsdklfjskldjfklsdjfklsdjfklsdjfsdfkljglksjgklfdg");
        }

        [TestMethod]
        public void Suspeito_Nova_Descricao_Maximo_Permitido_Valido()
        {
            var Suspeito = new Suspeito(1, "23456789101112131415161718192021222324252627282930");
            Assert.IsTrue(Suspeito.Descricao.Length <= Suspeito.DescricaoMaximoPermitido);
        }
    }
}
