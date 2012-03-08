namespace PFC
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSup = new System.Windows.Forms.Panel();
            this.cmdBiblioteca = new System.Windows.Forms.Button();
            this.txtCancionActual = new System.Windows.Forms.TextBox();
            this.panelInf = new System.Windows.Forms.Panel();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdPlayStop = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.panelSup.SuspendLayout();
            this.panelInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.Controls.Add(this.cmdBiblioteca);
            this.panelSup.Controls.Add(this.txtCancionActual);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(292, 100);
            this.panelSup.TabIndex = 0;
            // 
            // cmdBiblioteca
            // 
            this.cmdBiblioteca.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdBiblioteca.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdBiblioteca.Location = new System.Drawing.Point(217, 0);
            this.cmdBiblioteca.Name = "cmdBiblioteca";
            this.cmdBiblioteca.Size = new System.Drawing.Size(75, 100);
            this.cmdBiblioteca.TabIndex = 1;
            this.cmdBiblioteca.Text = "1";
            this.cmdBiblioteca.UseVisualStyleBackColor = true;
            this.cmdBiblioteca.Click += new System.EventHandler(this.cmdBiblioteca_Click);
            // 
            // txtCancionActual
            // 
            this.txtCancionActual.BackColor = System.Drawing.Color.White;
            this.txtCancionActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCancionActual.Location = new System.Drawing.Point(0, 0);
            this.txtCancionActual.Multiline = true;
            this.txtCancionActual.Name = "txtCancionActual";
            this.txtCancionActual.ReadOnly = true;
            this.txtCancionActual.Size = new System.Drawing.Size(100, 100);
            this.txtCancionActual.TabIndex = 0;
            this.txtCancionActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelInf
            // 
            this.panelInf.Controls.Add(this.cmdStop);
            this.panelInf.Controls.Add(this.cmdPlayStop);
            this.panelInf.Controls.Add(this.cmdSiguiente);
            this.panelInf.Controls.Add(this.cmdAnterior);
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 166);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(292, 100);
            this.panelInf.TabIndex = 1;
            // 
            // cmdStop
            // 
            this.cmdStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdStop.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdStop.Location = new System.Drawing.Point(75, 57);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(142, 43);
            this.cmdStop.TabIndex = 3;
            this.cmdStop.Text = "<";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdPlayStop
            // 
            this.cmdPlayStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdPlayStop.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdPlayStop.Location = new System.Drawing.Point(75, 0);
            this.cmdPlayStop.Name = "cmdPlayStop";
            this.cmdPlayStop.Size = new System.Drawing.Size(142, 32);
            this.cmdPlayStop.TabIndex = 2;
            this.cmdPlayStop.Text = "4";
            this.cmdPlayStop.UseVisualStyleBackColor = true;
            this.cmdPlayStop.Click += new System.EventHandler(this.cmdPlayStop_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdSiguiente.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdSiguiente.Location = new System.Drawing.Point(217, 0);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 100);
            this.cmdSiguiente.TabIndex = 1;
            this.cmdSiguiente.Text = ":";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdAnterior.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdAnterior.Location = new System.Drawing.Point(0, 0);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(75, 100);
            this.cmdAnterior.TabIndex = 0;
            this.cmdAnterior.Text = "9";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.panelSup);
            this.Name = "Principal";
            this.Text = "Reproductor";
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.panelInf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdPlayStop;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdBiblioteca;
        private System.Windows.Forms.TextBox txtCancionActual;
    }
}

