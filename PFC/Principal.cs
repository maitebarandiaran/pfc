using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using reproductorDeMusica;

namespace PFC
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.OnResize(null, null);
            this.Resize += new EventHandler(OnResize);
        }

        void OnResize(object sender, EventArgs e)
        {
            int mitadAltura = this.Height/2;
            int mitadAncho = this.panelInf.Height / 2;

            this.panelSup.Height = mitadAltura;
            this.panelInf.Height = mitadAltura;
            this.cmdBiblioteca.Width = this.cmdBiblioteca.Height;
            this.txtCancionActual.Width = (this.panelSup.Width - this.cmdBiblioteca.Width);          
            this.cmdPlayStop.Height = mitadAncho;
            this.cmdStop.Height = mitadAncho;
        }

        private void cmdBiblioteca_Click(object sender, EventArgs e)
        {
            var bibliotecaLista = new reproductorDeMusica.BibliotecaLista();
            bibliotecaLista.Show();
        }

        private void cmdPlayStop_Click(object sender, EventArgs e)
        {
            Instancias.reproductor.play();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            Instancias.reproductor.stop();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            Instancias.reproductor.siguiente();
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            Instancias.reproductor.anterior();
        }

        
    }
}
