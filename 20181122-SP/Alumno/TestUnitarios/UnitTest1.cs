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
        //[ExpectedException(typeof(PatenteInvalidaException))]
        public void ValidarPatente()
        {
           // Patente p = new Patente("JMI890", Patente.Tipo.Mercosur);
            string auxPatente = "jmi890";
            Patente p= auxPatente.ValidarPatente();
            Assert.AreEqual(auxPatente,p.CodigoPatente);
        }
    }
}
