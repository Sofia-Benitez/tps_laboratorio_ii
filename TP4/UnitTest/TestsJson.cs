using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestsJson
    {
        [TestMethod]
        public void ValidarExtension_DeberiaRetornarTrueSiElArchivoEsJson()
        {
            //arrange
            string ruta = "archivo.json";
            ArchivoJson<List<Pelicula>> archivoJson = new ArchivoJson<List<Pelicula>>();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_DeberiaLanzarArchivoInocrrectoExeptioneSiElArchivoNoEsJSON()
        {
            //arrange
            string ruta = "archivo.bin";
            ArchivoJson<List<Pelicula>> archivoJson = new ArchivoJson<List<Pelicula>>();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsFalse(retorno);
        }
    }
}
