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
using System.Threading;


namespace PR3_EQ5_TM
{

    public partial class Pantalla : Form
    {

        private List<Grafica> Graficas;

        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            int x = 5, y = 5;
            Graficas = new List<Grafica>();

            for (int i = 0; i < 28; i++)
            {

                Graficas.Add(new Grafica());
                switch (i)
                {
                    case 7:
                        x = 5;
                        y = Graficas[i].Height + 10;
                        Graficas[i].Left = x;
                        Graficas[i].Top = y;
                        break;
                    case 14:
                        x = 5;
                        y = Graficas[i].Height * 2 + 15;
                        Graficas[i].Left = x;
                        Graficas[i].Top = y;
                        break;
                    case 21:
                        x = 5;
                        y = Graficas[i].Height * 3 + 20;
                        Graficas[i].Left = x;
                        Graficas[i].Top = y;
                        break;
                    default:
                        Graficas[i].Top = y;
                        Graficas[i].Left = x;
                        break;
                }

                x += Graficas[i].Width + 5;
                pnlGraficas.Controls.Add(Graficas[i]);
            }

            #region version de Alan
            //int i = 0;
            //int Max = 28;
            //int Max2 = 5;
            //g1 = new List<Grafica>(Max);
            //int Ph = (pnlGraficas.Height) / 4, Pw = (pnlGraficas.Width-10) / 7;
            //int A = 0;
            //int H = 0;
            //Random Alea = new Random();
            //int[] NumAlea = new int[Max2];
            //int[] NumAlea2 = { 1,2,8,5,4} ;
            //int iA=0;
            //while (iA < Max2)
            //{
            //    NumAlea[iA] = Convert.ToInt32(Alea.Next(1, 20));
            //    iA++;
            //}

            //while (i < Max)
            //{
            //    if (i==7 || i==14 || i==21)
            //    {
            //        A++;
            //        H = 0;
            //    }
            //    g1.Add(new Grafica(Pw-10, Ph-20, NumAlea2));
            //    g1[i].Location = new Point(Pw * H, 5+ Ph * A);
            //    pnlGraficas.Controls.Add(g1[i]);
            //    H++;
            //    i++;
            //}
            #endregion

        }
        public void Inserciones()
        {
            Graficas[0].Ordenar("Inserción Binaria");
            Graficas[7].Ordenar("Inserción Binaria");
            Graficas[14].Ordenar("Inserción Binaria");
            Graficas[21].Ordenar("Inserción Binaria");
        }
        public void Burbujas()
        {
            Graficas[2].Ordenar("Burbuja Mejorada");
            Graficas[9].Ordenar("Burbuja Mejorada");
            Graficas[16].Ordenar("Burbuja Mejorada");
            Graficas[23].Ordenar("Burbuja Mejorada");
            //this.Refresh();
        }
        public void Shells()
        {
            Graficas[3].Ordenar("Shell");
            Graficas[10].Ordenar("Shell");
            Graficas[17].Ordenar("Shell");
            Graficas[24].Ordenar("Shell");
            //this.Refresh();
        }
        public void Quicks() 
        {
            Graficas[6].Ordenar("Quicksort");
            Graficas[13].Ordenar("Quicksort");
            Graficas[20].Ordenar("Quicksort");
            Graficas[27].Ordenar("Quicksort");
        }
        public void btnInserción_Click(object sender, EventArgs e)
        {
            Thread HiloInser = new Thread(Inserciones);
            HiloInser.Start();
            //this.Invoke(new MethodInvoker(Refresh));
            //Graficas[0].Ordenar("Inserción Binaria");
        }

        private void btnSelecion_Click(object sender, EventArgs e)
        {
            Graficas[1].Ordenar("");
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Thread HiloBurbu = new Thread(Burbujas);
            HiloBurbu.Start();
            //Graficas[2].Ordenar("Burbuja Mejorada");
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            Graficas[3].Ordenar("Shell");
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            Graficas[4].Ordenar("");
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            Graficas[5].Ordenar("");
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            Graficas[6].Ordenar("Quicksort");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Thread HiloBurbu = new Thread(Burbujas);
            HiloBurbu.Start();

            Thread HiloInser = new Thread(Inserciones);
            HiloInser.Start();

            Thread HiloShells = new Thread(Shells);
            HiloShells.Start();

            Thread HiloQuicks = new Thread(Quicks);
            HiloQuicks.Start();
        }
    }
}
