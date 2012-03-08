using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PFC;

namespace Tests
{
    using NUnit.Framework;
    [TestFixture]
    public class ListaDeReproduccionTest
    {

        [Test]
        public void listaVacia()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            Assert.That(listaDeReproduccion.estaVacia(), Is.True);
        }

        [Test]
        public void ListaVaciaNoTieneActual()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            Assert.That(listaDeReproduccion.cancionActual, Is.Null);
        
        }

        [Test]
        public void laListaTieneAlgunaCancionActual()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            var biblioteca = crearBibliotecaConAlgo();
            listaDeReproduccion.Biblioteca = biblioteca;

            Assert.That(listaDeReproduccion.cancionActual, Is.Not.Null);

        }

        [Test]
        public void laBibliotecaHaPasadoCancionesALaLista()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            var biblioteca = crearBibliotecaConAlgo();
            listaDeReproduccion.Biblioteca = biblioteca;

            Assert.That(listaDeReproduccion.estaVacia(), Is.False);

        }

        [Test]
        public void inicializarListaConBibliotecaVaciaDevuelveCancionActualVacia()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            var biblioteca = new PFC.Biblioteca();
            listaDeReproduccion.Biblioteca = biblioteca;
            Assert.That(listaDeReproduccion.cancionActual, Is.Null);
        }
        [Test]
        public void comprobarQueLaBibliotecaAnyadeUnaCancion()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            var biblioteca = crearBibliotecaConAlgo();
            var cancion = BibliotecaTest.construirCancionDeTest();
            listaDeReproduccion.Biblioteca = biblioteca;
            if (listaDeReproduccion.canciones.Count > 0)
            {
                listaDeReproduccion.AnyadeUnaCancionDeLaBibliotecaALaLista(cancion);
            }
            Assert.That(listaDeReproduccion.canciones[0], Is.EqualTo(cancion));
        }

        [Test]
        public void comprobarQueLaBibliotecaRecibeUnaCancionDeLaLista()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            var biblioteca = crearBibliotecaConAlgo();
            var cancion = BibliotecaTest.construirCancionDeTest();
            listaDeReproduccion.Biblioteca = biblioteca;
            if (listaDeReproduccion.canciones.Count <= 0)
            {
                Assert.Inconclusive("no hay elementos en la lista");
            }
            listaDeReproduccion.EliminaUnaCancionDeLaLista(cancion);
            
            Assert.That(biblioteca.canciones[0], Is.EqualTo(cancion));
        }

        public Biblioteca crearBibliotecaConAlgo()
        {

            var biblioteca = new PFC.Biblioteca();
            biblioteca.AnyadirCancion(BibliotecaTest.construirCancionDeTest());
            return biblioteca;
        }
    }

   
}
