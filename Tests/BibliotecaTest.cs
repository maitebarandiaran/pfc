using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PFC;

namespace Tests
{
    using NUnit.Framework;
    [TestFixture]
    //indica clase test
    public class BibliotecaTest
    {
        [Test]
        public void crearBibliotecaVacia()
        { 
            var biblioteca = new PFC.Biblioteca();
            Assert.That(biblioteca.EstaVacia(), Is.True);               
        }
        [Test]
        public void crearBibliotecaConAlgo()
        {
           
            var biblioteca = new PFC.Biblioteca();
            biblioteca.AnyadirCancion(new PFC.Cancion());
            Assert.That(biblioteca.EstaVacia(), Is.False);
        }

        [Test]
        public void vaciarBibliotecaInclusoConElementosMeDiceQueEstaVacio()
        {
            var biblioteca = new PFC.Biblioteca();
            biblioteca.AnyadirCancion(new PFC.Cancion());
            biblioteca.Borrar();
            Assert.That(biblioteca.EstaVacia(),Is.True);
        }

        [Test]
        public void anyadeCancionBibliotecaCompruebaContenidoBibliotecaEsSoloEsaCancion()
        {
            var biblioteca = new PFC.Biblioteca();
            var cancion = construirCancionDeTest();
            
            var canciones = anyadirCancionABiblioteca(cancion, biblioteca);

            Assert.That(canciones.Count,Is.EqualTo(1));
            Assert.That(canciones[0],Is.EqualTo(cancion));

        }
        [Test]
        public void anyadeCancionBibliotecaCompruebaDatosCancion ()
        {
            var biblioteca = new PFC.Biblioteca(); 
            var cancion = construirCancionDeTest();
            
            var canciones = anyadirCancionABiblioteca(cancion, biblioteca);
            Assert.That(canciones[0].Titulo, Is.EqualTo("bar"));
            Assert.That(canciones[0].Autor, Is.EqualTo("bero"));
                      
        }

        public static List<Cancion> anyadirCancionABiblioteca(Cancion cancion, Biblioteca biblioteca)
        {
            biblioteca.AnyadirCancion(cancion);
            var canciones = biblioteca.getCanciones();
            return canciones;
        }

        public static Cancion construirCancionDeTest()
        {
            var cancion = new PFC.Cancion();
            cancion.Titulo = "bar";
            cancion.Autor = "bero";
            return cancion;
        }
        [Test]
        public void BibliotecaRecibeCanciones()
        {
            var biblioteca = new PFC.Biblioteca();
            biblioteca.cargarCanciones(
                "C:\\Documents and Settings\\alumno\\Mis documentos\\Mi música\\(2002) Johnny Cash - American IV-The Man Comes Around");
            Assert.That(biblioteca.EstaVacia(), Is.Not.Null);
            var cancion = new Cancion();
            cancion.Titulo = "02. Hurt.mp3";
            Assert.That(biblioteca.canciones.Contains(cancion), Is.True);
        }


    }
}
