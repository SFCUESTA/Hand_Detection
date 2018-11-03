using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PreProcess
    {
        #region Variables
        Image<Gray, byte> img;
        #region Detecion de Mano
        Image<Hsv, byte> hsv;
        //Hsv min = new Hsv(135,88,72);
        //Hsv max = new Hsv(255, 255, 255);
        Hsv min = new Hsv(100, 0, 0);
        Hsv max = new Hsv(255, 100, 100);
        #endregion
        #region Convex hull
        VectorOfVectorOfPointF contornos = new VectorOfVectorOfPointF();
        PointF[][] c;
        Mat her = new Mat();
        MCvScalar s = new MCvScalar(255, 100, 100);
        PointF[] hull;
        Point[] pts;
        int m;
        #endregion
        #endregion
        #region Metodos Principales 
        public PreProcess()
        {

        }

        public Image<Gray, byte> Procesar(Mat img2)
        {
            hsv = img2.ToImage<Hsv, byte>();
            img = img2.ToImage<Gray, byte>();
            Piel();
            Hull();
            return img;
        }
        #endregion
        #region Metodos Secundarios 
        public void Piel()
        {
            img = hsv.InRange(min, max);

        }


        public Image<Gray, byte> Cont(Mat img2)
        {
            return img.Canny(200, 400);
        }


        public void Hull()
        {
            CvInvoke.FindContours(img, contornos, her, RetrType.External, ChainApproxMethod.ChainApproxNone);
            CvInvoke.DrawContours(img, contornos, 1, s);
            /*c = contornos.ToArrayOfArray();
            foreach (PointF[] p in c ){
                hull =CvInvoke.ConvexHull(p, true);
                m = 0;
                foreach (PointF p2 in hull){
                    pts[m] = Point.Round(p2);
                    m++;
                }
                CvInvoke.Polylines(img,pts, true,s);
            }*/

        }
        #endregion
    }
}
