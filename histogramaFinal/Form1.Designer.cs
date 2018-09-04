namespace histogramaFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.btnCargarGris = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(16, 15);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(141, 28);
            this.btnCargarImagen.TabIndex = 0;
            this.btnCargarImagen.Text = "cargar imagen";
            this.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(16, 50);
            this.imageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(781, 278);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // btnCargarGris
            // 
            this.btnCargarGris.Location = new System.Drawing.Point(177, 15);
            this.btnCargarGris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarGris.Name = "btnCargarGris";
            this.btnCargarGris.Size = new System.Drawing.Size(115, 28);
            this.btnCargarGris.TabIndex = 3;
            this.btnCargarGris.Text = "Cargar Gris";
            this.btnCargarGris.UseVisualStyleBackColor = true;
            this.btnCargarGris.Click += new System.EventHandler(this.btnCargarGris_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(831, 50);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(844, 278);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(329, 15);
            this.btnHistograma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(100, 28);
            this.btnHistograma.TabIndex = 4;
            this.btnHistograma.Text = "Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(4, 389);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(515, 357);
            this.histogramBox1.TabIndex = 5;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(586, 389);
            this.histogramBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(443, 346);
            this.histogramBox2.TabIndex = 6;
            // 
            // histogramBox3
            // 
            this.histogramBox3.Location = new System.Drawing.Point(1133, 389);
            this.histogramBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(472, 346);
            this.histogramBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 748);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btnCargarGris);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.btnCargarImagen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagen;
        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.Button btnCargarGris;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button btnHistograma;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
    }
}

