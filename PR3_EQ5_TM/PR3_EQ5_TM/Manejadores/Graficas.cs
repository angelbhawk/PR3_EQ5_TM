using PR3_EQ5_TM.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Manejadores
{
    class Graficas
    {
        private Form frm;
        private List<Grafica> ListaGraficas;

        public Graficas() 
        {
            frm = Application.OpenForms.OfType<Pantalla>().FirstOrDefault();
        }

        private void CrearGraficas()
        {
            int x = 5, y = 5;
            ListaGraficas = new List<Grafica>();

            for (int i = 0; i < 28; i++)
            {

                ListaGraficas.Add(new Grafica(10));

                switch (i)
                {
                    case 7:
                        x = 5;
                        y = ListaGraficas[i].Height + 10;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Top = y;
                        break;
                    case 14:
                        x = 5;
                        y = ListaGraficas[i].Height * 2 + 15;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Top = y;
                        break;
                    case 21:
                        x = 5;
                        y = ListaGraficas[i].Height * 3 + 20;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Top = y;
                        break;
                    default:
                        ListaGraficas[i].Top = y;
                        ListaGraficas[i].Left = x;
                        break;
                }

                x += ListaGraficas[i].Width + 5;
                //frm.pnlGraficas.Controls.Add(ListaGraficas[i]);
            }
        }

        public void Inserciones()
        {
            //Graficas[0].Ordenar("Inserción Binaria");
            //Graficas[7].Ordenar("Inserción Binaria");
            //Graficas[14].Ordenar("Inserción Binaria");
            //Graficas[21].Ordenar("Inserción Binaria");
        }
        public void Selecciones()
        {
            //Graficas[1].Ordenar("Selección");
            //Graficas[8].Ordenar("Selección");
            //Graficas[15].Ordenar("Selección");
            //Graficas[22].Ordenar("Selección");
        }
        public void Burbujas()
        {
            //Graficas[2].Ordenar("Burbuja Mejorada");
            //Graficas[9].Ordenar("Burbuja Mejorada");
            //Graficas[16].Ordenar("Burbuja Mejorada");
            //Graficas[23].Ordenar("Burbuja Mejorada");
            //this.Refresh();
        }
        public void Shells()
        {
            //Graficas[3].Ordenar("Shell");
            //Graficas[10].Ordenar("Shell");
            //Graficas[17].Ordenar("Shell");
            //Graficas[24].Ordenar("Shell");
            //this.Refresh();
        }
        public void Quicks()
        {
            //Graficas[6].Ordenar("Quicksort");
            //Graficas[13].Ordenar("Quicksort");
            //Graficas[20].Ordenar("Quicksort");
            //Graficas[27].Ordenar("Quicksort");
        }

        public void Merges()
        {
            //Graficas[4].Ordenar("Merge");
            //Graficas[11].Ordenar("Merge");
            //Graficas[18].Ordenar("Merge");
            //Graficas[25].Ordenar("Merge");
        }
        public void Heaps()
        {
            //Graficas[5].Ordenar("Heap");
            //Graficas[12].Ordenar("Heap");
            //Graficas[19].Ordenar("Heap");
            //Graficas[26].Ordenar("Heap");
        }

        internal List<Grafica> ListaGraficas1 { get => ListaGraficas; set => ListaGraficas = value; }
    }
}