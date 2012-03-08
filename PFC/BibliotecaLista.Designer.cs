namespace reproductorDeMusica
{
    partial class BibliotecaLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBiblioteca = new System.Windows.Forms.Panel();
            this.listBiblioteca = new System.Windows.Forms.ListBox();
            this.panelLista = new System.Windows.Forms.Panel();
            this.listLista = new System.Windows.Forms.ListBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cmdEliminarDeLista = new System.Windows.Forms.Button();
            this.cmdAnyadirALista = new System.Windows.Forms.Button();
            this.panelBiblioteca.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBiblioteca
            // 
            this.panelBiblioteca.Controls.Add(this.listBiblioteca);
            this.panelBiblioteca.Location = new System.Drawing.Point(9, 10);
            this.panelBiblioteca.Name = "panelBiblioteca";
            this.panelBiblioteca.Size = new System.Drawing.Size(100, 235);
            this.panelBiblioteca.TabIndex = 0;
            // 
            // listBiblioteca
            // 
            this.listBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBiblioteca.FormattingEnabled = true;
            this.listBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.listBiblioteca.Name = "listBiblioteca";
            this.listBiblioteca.Size = new System.Drawing.Size(100, 225);
            this.listBiblioteca.TabIndex = 0;
            // 
            // panelLista
            // 
            this.panelLista.Controls.Add(this.listLista);
            this.panelLista.Location = new System.Drawing.Point(179, 12);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(98, 232);
            this.panelLista.TabIndex = 1;
            // 
            // listLista
            // 
            this.listLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLista.FormattingEnabled = true;
            this.listLista.Location = new System.Drawing.Point(0, 0);
            this.listLista.Name = "listLista";
            this.listLista.Size = new System.Drawing.Size(98, 225);
            this.listLista.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.cmdEliminarDeLista);
            this.panelBotones.Controls.Add(this.cmdAnyadirALista);
            this.panelBotones.Location = new System.Drawing.Point(116, 12);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(53, 231);
            this.panelBotones.TabIndex = 2;
            // 
            // cmdEliminarDeLista
            // 
            this.cmdEliminarDeLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdEliminarDeLista.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdEliminarDeLista.Location = new System.Drawing.Point(0, 204);
            this.cmdEliminarDeLista.Name = "cmdEliminarDeLista";
            this.cmdEliminarDeLista.Size = new System.Drawing.Size(53, 27);
            this.cmdEliminarDeLista.TabIndex = 1;
            this.cmdEliminarDeLista.Text = "3";
            this.cmdEliminarDeLista.UseVisualStyleBackColor = true;
            // 
            // cmdAnyadirALista
            // 
            this.cmdAnyadirALista.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdAnyadirALista.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdAnyadirALista.Location = new System.Drawing.Point(0, 0);
            this.cmdAnyadirALista.Name = "cmdAnyadirALista";
            this.cmdAnyadirALista.Size = new System.Drawing.Size(53, 23);
            this.cmdAnyadirALista.TabIndex = 0;
            this.cmdAnyadirALista.Text = "4";
            this.cmdAnyadirALista.UseVisualStyleBackColor = true;
            // 
            // BibliotecaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panelBiblioteca);
            this.Name = "BibliotecaLista";
            this.Text = "BibliotecaLista";
            this.Load += new System.EventHandler(this.BibliotecaLista_Load);
            this.panelBiblioteca.ResumeLayout(false);
            this.panelLista.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBiblioteca;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.ListBox listBiblioteca;
        private System.Windows.Forms.ListBox listLista;
        private System.Windows.Forms.Button cmdEliminarDeLista;
        private System.Windows.Forms.Button cmdAnyadirALista;

    }
}