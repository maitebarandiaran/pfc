using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PFC
{
   public class Biblioteca

   {
       public List<Cancion> canciones = new List<Cancion>();

       public bool EstaVacia()
       {
           return canciones.Count==0;
       }

       public void Borrar()
       {
           canciones.Clear();
       }

         public List<Cancion> getCanciones()
         {
             return canciones;
         }

         public void AnyadirCancion(Cancion cancion)
         {
            canciones.Add(cancion);
            
         }
         public Biblioteca crearBibliotecaConAlgo()
         {

             var biblioteca = new PFC.Biblioteca();
             biblioteca.AnyadirCancion(new PFC.Cancion());
             return biblioteca;
         }

       public void cargarCanciones(string ruta)
       {
           
           var archivos = System.IO.Directory.GetFiles(ruta, "*.mp3");
           foreach (var archivo in archivos)
           {
               var cancion = new PFC.Cancion();
               cancion.Titulo = Path.GetFileName(archivo);
               this.AnyadirCancion(cancion);
               
           }
       }

   }
}
