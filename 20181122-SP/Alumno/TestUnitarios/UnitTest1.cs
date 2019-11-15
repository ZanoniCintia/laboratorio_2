using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void ValidarPatente()
        {
           
            string auxPatente = "JMI890";
            Patente p= auxPatente.ValidarPatente();
            Assert.AreEqual(auxPatente,p.CodigoPatente);
        }

        [TestMethod]
        [ExpectedException(typeof(PatenteInvalidaException))]
        public void ValidarEXcepcion()
        {
            string auxP = "JJ4584";
            Patente p = auxP.ValidarPatente();
            Assert.AreEqual(auxP, p.CodigoPatente);
        }
    }
}
