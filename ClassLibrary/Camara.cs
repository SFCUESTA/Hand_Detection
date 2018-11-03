
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Camara
    {
        private VideoCapture capture;
        public Mat Frame;
        private ImageBox imgBox1, imgBox2;
        
        private int Indice1 = 0;
        public bool calib = false;

        Image<Gray, byte> Edge, Alt;
        PreProcess pr = new PreProcess();
        public Camara()
        {

        }

        public void Inicializar(int Indice, ImageBox imgBox, ImageBox imgBoxA)
        {

            Indice1 = Indice;
            imgBox1 = imgBox;
            imgBox2 = imgBoxA;
            Frame = new Mat();
            capture = new VideoCapture(Indice);
            capture.SetCaptureProperty(CapProp.FrameHeight, imgBox1.Height);
            capture.SetCaptureProperty(CapProp.FrameWidth, imgBox1.Width);
            capture.FlipHorizontal = true;
            capture.ImageGrabbed += CapturarImagen;


        }

        private void CapturarImagen(object sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                try
                {
                    capture.Retrieve(Frame);
                    //Alt = pr.Cont(Frame);
                    //Edge = pr.Procesar(Frame);
                    imgBox1.Image = Frame;
                    //imgBox1.Image = Edge;
                    //imgBox2.Image = Alt;

                }
                catch { }
            }

        }

        public void start()
        {
            
            if (capture != null)
            {
                try
                {
                    capture.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void stop()
        {
            capture.Stop();
            capture.Dispose();
            imgBox1.Image = null;
            imgBox2.Image = null;
        }
    }
}
