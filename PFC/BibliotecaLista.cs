using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reproductorDeMusica
{
    public partial class BibliotecaLista : Form
    {
        public BibliotecaLista()
        {
            InitializeComponent();
            BibliotecaLista_Paint(null, null);
            this.Resize += new EventHandler(BibliotecaLista_Paint);
        }

        void BibliotecaLista_Paint(object sender, EventArgs e)
        {
            int anchoPanel = Convert.ToInt32(Convert.ToDouble(this.Width)*0.4);

            this.panelBiblioteca.Left = 0;
            this.panelBiblioteca.Top = 0;
            this.panelBiblioteca.Width = anchoPanel;
            this.panelBiblioteca.Height = this.Height;

            this.panelLista.Top = 0;
            this.panelLista.Width = anchoPanel;
            this.panelLista.Height = this.Height;
            this.panelLista.Left = this.Width - anchoPanel;

            this.panelBotones.Top = 0;
            this.panelBotones.Height = this.Height;
            this.panelBotones.Width = Convert.ToInt32(Convert.ToDouble(this.Width)*0.2);
            this.panelBotones.Left = anchoPanel;

            this.cmdAnyadirALista.Height = this.panelBotones.Height/2;
            this.cmdEliminarDeLista.Height = this.panelBotones.Height/2;
        }

        private void BibliotecaLista_Load(object sender, EventArgs e)
        {
            foreach (var cancion in Instancias.biblioteca.canciones)
            {
                this.listBiblioteca.Items.Add(cancion.Titulo);
            }
            foreach (var cancion in Instancias.listaDeReproduccion.canciones)
            {
                this.listLista.Items.Add(cancion.Titulo);
            }
        }

        private void cmdAnyadirALista_Click(object sender, EventArgs e)
        {
            if (listBiblioteca.Items.Count > 0)
            {
                var cancionSeleccionada = listBiblioteca.SelectedItem as PFC.Cancion; 
                if (cancionSeleccionada != null)
                {
                   
                 Instancias.listaDeReproduccion.AnyadeUnaCancionDeLaBibliotecaALaLista(cancionSeleccionada);
                       
                 }
            }
        }
        private void cmdEliminarDeLista_Click(object sender, EventArgs e)
        {
            if (listLista.Items.Count > 0)
            {
                var cancionSeleccionada = listLista.SelectedItem as PFC.Cancion;
                if (cancionSeleccionada != null)
               {

                    Instancias.listaDeReproduccion.EliminaUnaCancionDeLaLista(cancionSeleccionada);

                }
            }
        }

    }

}
