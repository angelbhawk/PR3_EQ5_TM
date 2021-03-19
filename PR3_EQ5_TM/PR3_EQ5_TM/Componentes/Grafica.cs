using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Componentes
{
    class Grafica : Panel
    {
        // Variables globales

        private int[] numerosAleatorios; // Guarda los numerosAleatorios generados aleatoriamente
        private Rectangle[] rectangulosGraficados; // Grafica los numerosAleatorios del arreglo
        private string métodoSelecionado;
        private int aux, avx, ba, bb, bc, bd, be, rectanguloMenor = -1, rectanguloMayor = -1;
        private double pv;
        private bool band;

        // Gráficos
        private Pen p;
        private Graphics g;
        private Brush pincelPrincipal, pincelSecundario;
        private Color colorPrimario, colorSecundario, colorFondo;

        public Grafica()
        // : base(parametros pero no tiene)
        {
            Colores();
            this.Width = 100;
            this.Height = 100;
            this.Paint += new PaintEventHandler(Grafica_Paint);
            this.BackColor = colorFondo;
            int[] valoresIniciales = { 1,2,3,4,5 };
            numerosAleatorios = valoresIniciales;
            DibujarRectangulos();
        }

        public Grafica(int alto, int ancho, int[] valores)
        // : base(parametros pero no tiene) 
        {
            this.Width = alto;
            this.Height = ancho;
            this.Paint += new PaintEventHandler(Grafica_Paint);
            this.BackColor = Color.White;

            numerosAleatorios = valores;
            DibujarRectangulos();
        }

        // Graficación

        private void Colores()
        {
            colorPrimario = new Color();
            colorPrimario = Color.FromArgb(44, 62, 80);
            colorSecundario = new Color();
            colorSecundario = Color.FromArgb(27, 38, 49);
            colorFondo = new Color();
            colorFondo = Color.FromArgb(0, 0, 0);
        }

        private void DibujarRectangulos() 
        {
            rectangulosGraficados = new Rectangle[numerosAleatorios.Length]; // Crea el arreglo de rectangulos
            for (int numRec = 0; numRec < numerosAleatorios.Length; numRec++) // Genera los rectangulos con la lista de numerosAleatorios
            {
                if (numRec == 0)
                    rectangulosGraficados[numRec] = new Rectangle(2, 2, 10, this.Height / numerosAleatorios[numRec] - 4);
                else
                    rectangulosGraficados[numRec] = new Rectangle(rectangulosGraficados[numRec - 1].Right + 2, 2, 10, this.Height / numerosAleatorios[numRec] - 4);
            }
        }

        private void Animacion(int k, int w)
        {
            rectanguloMenor = k;
            rectanguloMayor = w;
            int distancia = rectangulosGraficados[rectanguloMenor].Left - rectangulosGraficados[rectanguloMayor].Left;
            int x = 5;
            while (x <= distancia)
            {
                g.FillRectangle(pincelSecundario, rectangulosGraficados[rectanguloMenor]);
                g.FillRectangle(pincelSecundario, rectangulosGraficados[rectanguloMayor]);
                Thread.Sleep(10);
                rectangulosGraficados[rectanguloMenor].Location = new Point((rectangulosGraficados[rectanguloMenor].Left) + 5, 18);
                rectangulosGraficados[rectanguloMayor].Location = new Point((rectangulosGraficados[rectanguloMayor].Left) - 5, 18);
                Refresh();
                x += 5;
            }
            g.FillRectangle(pincelPrincipal, rectangulosGraficados[rectanguloMayor]);
            g.FillRectangle(pincelPrincipal, rectangulosGraficados[rectanguloMayor]);
            rectanguloMenor = -1;
            rectanguloMayor = -1;
        } // Anima xd

        // Ordenación

        public void Ordenar(string métodoSelecionado) 
        {
            switch (métodoSelecionado)
            {
                case "Burbuja Tradicional":
                    BurbujaT();
                    break;
                case "Burbuja Mejorada":
                    BurbujaM();
                    break;
                case "Quicksort":
                    Quicksort(0, numerosAleatorios.Length - 1);
                    break;
                case "Shell":
                    Shell();
                    break;
                case "Inserción Simple":
                    Baraja();
                    break;
                case "Inserción Binaria":
                    Binario();
                    break;
                default:
                    MessageBox.Show("Selecione un método de ordenamiento");
                    break;
            }
        }

        // Métodos

        #region Código de los métodos

        public void BurbujaT()
        {
            // Ordena la lista
            for (ba = 1; ba < numerosAleatorios.Length; ba++)
            {
                for (bb = numerosAleatorios.Length - 1; bb >= ba; bb--)
                {
                    if (numerosAleatorios[bb - 1] > numerosAleatorios[bb]) // Intercambio de datos
                    {
                        aux = numerosAleatorios[bb - 1];
                        Animacion(bb - 1, bb);
                        numerosAleatorios[bb - 1] = numerosAleatorios[bb];
                        numerosAleatorios[bb] = aux;
                        DibujarRectangulos();
                    }
                }
            }
        }              // Burbuja tradicional // Sí
        public void BurbujaM()
        {
            // Ordena la lista
            band = true; bd = 0;
            do
            {
                bd++;
                band = true;
                for (ba = 0; ba < numerosAleatorios.Length - bd; ba++)
                {
                    if (numerosAleatorios[ba] > numerosAleatorios[ba + 1])
                    {
                        aux = numerosAleatorios[ba];
                        Animacion(ba, ba + 1);
                        numerosAleatorios[ba] = numerosAleatorios[ba + 1];
                        numerosAleatorios[ba + 1] = aux;
                        DibujarRectangulos();
                        band = false;
                    }
                }
            }
            while (!band);
        }              // Burbuja mejorado // Sí
        public void Shell()
        {
            // Ordena la lista
            ba = numerosAleatorios.Length / 2;
            while (ba > 0)
            {
                band = true;
                while (band)
                {
                    band = false;
                    bb = 1;
                    while (bb <= (numerosAleatorios.Length - ba))
                    {
                        if (numerosAleatorios[bb - 1] > numerosAleatorios[(bb - 1) + ba]) // Intercambio de datos
                        {
                            aux = numerosAleatorios[(bb - 1) + ba];
                            Animacion(bb - 1, (bb - 1) + ba);
                            numerosAleatorios[(bb - 1) + ba] = numerosAleatorios[bb - 1];
                            numerosAleatorios[(bb - 1)] = aux;
                            DibujarRectangulos();
                            band = true;
                        }
                        bb++;
                    }
                }
                ba = ba / 2;
            }
        }                 // Shell // Sí
        public void Quicksort(int p, int u)
        {
            // Ordena la lista
            bc = (p + u) / 2;
            pv = numerosAleatorios[bc];
            ba = p;
            bb = u;
            do
            {
                while (numerosAleatorios[ba] < pv) ba++;
                while (numerosAleatorios[bb] > pv) bb--;
                if (ba <= bb)
                {
                    aux = numerosAleatorios[ba];
                    Animacion(ba, bb);
                    numerosAleatorios[ba] = numerosAleatorios[bb];
                    numerosAleatorios[bb] = aux;
                    DibujarRectangulos();
                    ba++;
                    bb--;
                }
            } while (ba <= bb);

            if (p < bb)
            {
                Quicksort(p, bb);
            }
            if (ba < u)
            {
                Quicksort(ba, u);
            }

        } // Quicksort // Sí
        public void Baraja()
        {
            // Ordena la lista
            for (ba = 0; ba < numerosAleatorios.Length; ba++)
            {
                aux = numerosAleatorios[ba];
                bc = ba - 1;
                while ((bc >= 0) && (aux < numerosAleatorios[bc])) // Intercambio de numerosAleatorios
                {
                    Animacion(bc, bc + 1);
                    numerosAleatorios[bc + 1] = numerosAleatorios[bc];
                    DibujarRectangulos();
                    bc--;
                }
                numerosAleatorios[bc + 1] = aux;
            }
        }                // Inserción directa // Sí
        public void Binario()
        {
            // Ordena la lista

            for (int ba = 0; ba < numerosAleatorios.Length; ba++)
            {
                aux = numerosAleatorios[ba];
                avx = ba;
                be = 0;
                bd = ba - 1;
                while (be <= bd)
                {
                    bc = (be + bd) / 2;
                    if (aux <= numerosAleatorios[bc])
                    {
                        bd = bc - 1;
                    }
                    else
                    {
                        be = bc + 1;
                    }
                }
                for (int bb = ba - 1; bb >= be; bb--)
                {
                    numerosAleatorios[bb + 1] = numerosAleatorios[bb];
                }
                Animacion(be, avx);
                numerosAleatorios[be] = aux;
                DibujarRectangulos();
            }
        }               // Inserción binaria // Sí

        #endregion

        // Eventos

        private void Grafica_Paint(object sender, PaintEventArgs e)
        {
            // Crea los graficos
            g = this.CreateGraphics();
            p = new Pen(new SolidBrush(Color.Black));
            pincelPrincipal = new SolidBrush(colorPrimario);
            pincelSecundario = new SolidBrush(colorSecundario);

            // Dibuja rectangulo
            g.DrawRectangles(p, rectangulosGraficados);
            g.FillRectangles(pincelPrincipal, rectangulosGraficados);

            if (rectanguloMenor >= 0 && rectanguloMayor >= 0)
            {
                g.FillRectangle(pincelSecundario, rectangulosGraficados[rectanguloMenor]);
                g.FillRectangle(pincelSecundario, rectangulosGraficados[rectanguloMayor]);
            }
        }
    }
}