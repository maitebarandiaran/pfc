using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PFC;

namespace Tests
{
    using NUnit.Framework;
    [TestFixture]

    public class ReproductorTest
    {
        [Test]
        public void cuandoLaListaEstaVaciaElReproductorEstaVacio()
        {
            var listaDeReproduccion = new ListaDeReproduccion();
            var reproductor = new Reproductor();
            var biblioteca = new PFC.Biblioteca();
            listaDeReproduccion.Biblioteca = biblioteca;
            Assert.That(reproductor.estaVacia(), Is.True);
         }

        [Test]
        public void laListaPasaCancionesAlReproductor()
        {
            var listaDeReproduccion = crearListaConAlgo();
            var reproductor = new PFC.Reproductor();
            reproductor.listaDeReproduccion = listaDeReproduccion;
            reproductor.play();
            Assert.That(reproductor.cancionActual, Is.Not.Null);
        }

        [Test]
        public void laListaPasaCancionSiguienteAlReproductor()
        {
            var listaDeReproduccion = crearListaConAlgo();
            var reproductor = new Reproductor();
            if (listaDeReproduccion.canciones.Count > 1)
            {
                listaDeReproduccion.cancionActual = listaDeReproduccion.canciones[0];

                Assert.That(reproductor.cancionSiguiente, Is.EqualTo(listaDeReproduccion.canciones[1]));
            }

            //  reproductor.cancionSiguiente = listaDeReproduccion.canciones[i+1];
        }

        [Test]
        public void laListaPasaCancionAnteriorAlReproductor()
        {
            var listaDeReproduccion = crearListaConAlgo();
            var reproductor = new Reproductor();
            if (listaDeReproduccion.canciones.Count > 1)
            {
                listaDeReproduccion.cancionActual = listaDeReproduccion.canciones[0];

                Assert.That(reproductor.cancionSiguiente, Is.EqualTo(listaDeReproduccion.canciones[0]));
            }
        }
        [Test]
        public void laCancionSePara()
        {
            var reproductor = new Reproductor();
            Assert.That(reproductor.cancionActual, Is.Null);
        }

        public ListaDeReproduccion crearListaConAlgo()
        {
            var biblioteca = new PFC.Biblioteca();
            var listaDeReproduccion = new PFC.ListaDeReproduccion();
            biblioteca = biblioteca.crearBibliotecaConAlgo();
            listaDeReproduccion.Biblioteca = biblioteca;
            return listaDeReproduccion;
        }
        
    }

 
}
