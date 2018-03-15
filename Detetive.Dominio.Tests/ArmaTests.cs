using Detetive.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Dominio.Tests
{
    [TestClass]
    public class ArmaTests
    {
        private string Descricao { get; set; }

        public ArmaTests()
        {
            Descricao = "nenhum";
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Arma_Nova_Arma_Id_Zerado()
        {
            var arma = new Arma(0);
        }

        [TestMethod]
        public void Arma_Nova_Arma_Valida()
        {
            var arma = new Arma(1);
            Assert.IsTrue(arma != null, "Arma existe");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Arma_Nova_Arma_Invalida()
        {
            var arma = new Arma(100);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Arma_Nova_Descricao_Nula()
        {
            new Arma(1, null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Arma_Nova_Descricao_Vazia()
        {
            new Arma(1, "");
        }


        [TestMethod]
        public void Arma_Nova_Descricao_Atribuido()
        {
            var arma = new Arma(1, Descricao);
            Assert.AreEqual(Descricao, arma.Descricao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Arma_Nova_Descricao_Maximo_Permitido_Invalido()
        {
            new Arma(1, "shjkshdfkjshdkfhsdkjfhskdjfhsjkdfhksjhfksjdhfsjkdhfskjdhfskjdfhsdkjfhskldfjsdklfjskldjfklsdjfklsdjfklsdjfsdfkljglksjgklfdg");
        }

        [TestMethod]
        public void Arma_Nova_Descricao_Maximo_Permitido_Valido()
        {
            var arma = new Arma(1, "23456789101112131415161718192021222324252627282930");
            Assert.IsTrue(arma.Descricao.Length <= Arma.DescricaoMaximoPermitido);
        }
    }
}
