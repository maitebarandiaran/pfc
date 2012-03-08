using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFC
{
   public class ListaDeReproduccion
    {
       public List<Cancion> canciones = new List<Cancion>();

       public bool estaVacia()
       {
           return (canciones.Count==0);
       }

       public Cancion cancionActual { get; set; }

       public Biblioteca Biblioteca
       {
           set
           {
               canciones.AddRange(value.getCanciones());
               if (canciones.Count>0) 
               cancionActual = canciones[0];
           }

       }
       public ListaDeReproduccion crearListaConAlgo()
       {
           var biblioteca = new PFC.Biblioteca();
           var listaDeReproduccion = new PFC.ListaDeReproduccion();
           biblioteca = biblioteca.crearBibliotecaConAlgo();
           listaDeReproduccion.Biblioteca = biblioteca;
           return listaDeReproduccion;
       }

       public void AnyadeUnaCancionDeLaBibliotecaALaLista(Cancion cancion)
       {
           this.canciones.Add(cancion);
           
       }

       public void EliminaUnaCancionDeLaLista(Cancion cancion)
       {
           var biblioteca = new PFC.Biblioteca();

           biblioteca.canciones.Add(cancion);
           this.canciones.Remove(cancion);
       }
    }

}
