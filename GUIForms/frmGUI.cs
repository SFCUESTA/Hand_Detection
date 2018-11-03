using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;


namespace GUIForms
{
    public partial class frmGUI : Form
    {
        Camara ca1 = new Camara();
        Camara ca2 = new Camara();
        Camara ca3 = new Camara();
        List<Camara> ca = new List<Camara>();
        public frmGUI()
        {
            ca.Add(ca1);
            ca.Add(ca2);
            //ca.Add(ca3);
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < ca.Count; x++)
            {
                ca[x].stop();
            }
            imgBox1.Image = null;
            imgBox2.Image = null;
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ca[0].Inicializar(0, imgBox1, imgBox4);
            ca[1].Inicializar(1, imgBox2, imgBox3);
            for (int x = 0; x < ca.Count; x++)
            {
                ca[x].start();
            }
            

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < ca.Count; x++)
            {
                ca[x].stop();
            }
        }
    }
}
