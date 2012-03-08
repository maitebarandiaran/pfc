using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PFC;
using reproductorDeMusica.Properties;

namespace reproductorDeMusica
{
    public class Instancias
    {
        
        public static Biblioteca biblioteca { get; set; }
        public static ListaDeReproduccion listaDeReproduccion { get; set; }
        public static Reproductor reproductor { get; set; }

        static Instancias()
        {
            var biblioteca = new PFC.Biblioteca();
            biblioteca.cargarCanciones(Settings.Default.rutaCanciones);
            var listaDeReproduccion = new PFC.ListaDeReproduccion();
            listaDeReproduccion.Biblioteca = biblioteca;
            var reproductor = new PFC.Reproductor();
            reproductor.listaDeReproduccion = listaDeReproduccion;

            Instancias.biblioteca = biblioteca;           
            Instancias.listaDeReproduccion = listaDeReproduccion;
            Instancias.reproductor = reproductor;    
        
        }

              
    }
}
