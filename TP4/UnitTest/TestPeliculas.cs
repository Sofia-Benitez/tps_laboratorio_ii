using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class TestPeliculas
    {

        [TestMethod]
        public void OperadorIgualIgual_DebeRetornarTrueSiDosPeliculasSonIguales()
        {
            // arrange
            Equipo equipoTedLasso = new Equipo(0, "Declan Lowney", "Brendan Hunt", new List<string> { "Brendan Hunt", "Jason Sudeikis", "Brett Goldstein" });

            Pelicula pelicula1 = new Pelicula(0, "prueba", 2020, 0, "prueba", equipoTedLasso, 0);
            Pelicula pelicula2 = new Pelicula(0, "prueba", 2020, 0, "prueba", equipoTedLasso, 0);

            //act
            bool retorno = pelicula1 == pelicula2;

            //assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void OperadorIgualIgual_DebeRetornarFalseSiDosPeliculasNoSonIguales()
        {
            // arrange
            Equipo equipoTedLasso = new Equipo(0, "Declan Lowney", "Brendan Hunt", new List<string> { "Brendan Hunt", "Jason Sudeikis", "Brett Goldstein" });

            Pelicula pelicula1 = new Pelicula(0, "prueba", 2020, 0, "prueba", equipoTedLasso, 0);
            Pelicula pelicula2 = new Pelicula(0, "prueba", 1992, 0, "prueba", equipoTedLasso, 0);

            //act
            bool retorno = pelicula1 == pelicula2;

            //assert
            Assert.IsFalse(retorno);
        }
    }
}
