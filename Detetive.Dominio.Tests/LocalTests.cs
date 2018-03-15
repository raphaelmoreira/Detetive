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
    public class LocalTests
    {
        private string Descricao { get; set; }

        public LocalTests()
        {
            Descricao = "nenhum";
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Local_Nova_Local_Id_Zerado()
        {
            var Local = new Local(0);
        }

        [TestMethod]
        public void Local_Nova_Local_Valida()
        {
            var Local = new Local(1);
            Assert.IsTrue(Local != null, "Local existe");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Local_Nova_Local_Invalida()
        {
            var Local = new Local(100);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Local_Nova_Descricao_Nula()
        {
            new Local(1, null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Local_Nova_Descricao_Vazia()
        {
            new Local(1, "");
        }


        [TestMethod]
        public void Local_Nova_Descricao_Atribuido()
        {
            var Local = new Local(1, Descricao);
            Assert.AreEqual(Descricao, Local.Descricao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Local_Nova_Descricao_Maximo_Permitido_Invalido()
        {
            new Local(1, "shjkshdfkjshdkfhsdkjfhskdjfhsjkdfhksjhfksjdhfsjkdhfskjdhfskjdfhsdkjfhskldfjsdklfjskldjfklsdjfklsdjfklsdjfsdfkljglksjgklfdg");
        }

        [TestMethod]
        public void Local_Nova_Descricao_Maximo_Permitido_Valido()
        {
            var Local = new Local(1, "23456789101112131415161718192021222324252627282930");
            Assert.IsTrue(Local.Descricao.Length <= Local.DescricaoMaximoPermitido);
        }
    }
}
