using PR3_EQ5_TM.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace PR3_EQ5_TM
{
    public partial class Pantalla : Form
    {
        List<Grafica> g1;
        public Pantalla()
        {
            InitializeComponent();
        }

        private void pnlGraficas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            int i = 0;
            int Max = 28;
            int Max2 = 5;
            g1 = new List<Grafica>(Max);
            int Ph = (pnlGraficas.Height) / 4, Pw = (pnlGraficas.Width-10) / 7;
            int A = 0;
            int H = 0;
            int px = 2, py = 2;
            Random Alea = new Random();
            int[] NumAlea = new int[Max2];
            int[] NumAlea2 = { 1,14,2,20,3,4,7,5} ;
            int iA=0;
            int Repe = 0;
            while (iA < Max2)
            {
                NumAlea[iA] = Convert.ToInt32(Alea.Next(1, 20));
                iA++;
            }
            //while (iA < Max2)
            //{

            //    iA++;
            //}

            while (i < Max)
            {
                if (i==7 || i==14 || i==21)
                {
                    A++;
                    H = 0;
                }
                g1.Add(new Grafica(Pw-10, Ph-20, NumAlea));
                //g1[i].Px1 = Pw * H;
                //g1[i].Py1 = Pyy;
                g1[i].Location = new Point(Pw * H, 5+ Ph * A);
                pnlGraficas.Controls.Add(g1[i]);
                //int Pyy = py + Ph * A;
                H++;
                i++;
            }

        }
    }
}
