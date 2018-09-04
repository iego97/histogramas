using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace histogramaFinal
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> inputImage;
        Image<Gray, byte> grayImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            string filename = "c:\\lenna.jpg";
            inputImage = new Image<Bgr, byte>(filename);

            if(inputImage == null)
            {
                MessageBox.Show("Imagen no cargada");
                return;
            }

            imageBox.Image = inputImage;
            imageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
        }

        private void btnCargarGris_Click(object sender, EventArgs e)
        {
            grayImage = inputImage.Convert<Gray, byte>();

            if(inputImage == null)
            {
                MessageBox.Show("imagen no cargada");
                return;
                    
            }

            imageBox2.Image = grayImage;
            imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;

        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { inputImage[0]}, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            //Azul
            histogramBox1.AddHistogram("Histograma de color azul", Color.Blue, m, 256, new float[] { 0, 255 });
            
            //Verde
            histogramBox2.AddHistogram("Histograma de color azul", Color.Green, m, 256, new float[] { 0, 255 });

            //Rojo
            histogramBox3.AddHistogram("Histograma de color azul", Color.Red, m, 256, new float[] { 0, 255 });



            histogramBox1.Refresh();
        }
    }
}
