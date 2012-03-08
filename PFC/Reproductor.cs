using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFC
{
        public class Reproductor
        {
            
            private List<Cancion> canciones = new List<Cancion>();
            public ListaDeReproduccion listaDeReproduccion { get; set; }
            public Cancion cancionActual{get; set;}
            public Cancion cancionSiguiente{get; set;}
            public Cancion cancionAnterior{get; set;}

            public bool estaVacia()
            {
                return canciones.Count == 0;
            }
            public void siguiente()
            {
                validarListaDeReproduccion();
                this.cancionSiguiente = listaDeReproduccion.canciones[1];
            }
            public void anterior()
            {
                validarListaDeReproduccion();
                this.cancionSiguiente = listaDeReproduccion.canciones[0];
            }
            public void stop()
            {
                this.cancionActual = null;
            }
            public Cancion play()
            {
                validarListaDeReproduccion();
                this.cancionActual = listaDeReproduccion.cancionActual;
                return this.cancionActual;
            }

            private void validarListaDeReproduccion()
            {
                if (listaDeReproduccion == null)
                    throw new ArgumentNullException("listaDeReproduccion");
            }
        }
    
}
