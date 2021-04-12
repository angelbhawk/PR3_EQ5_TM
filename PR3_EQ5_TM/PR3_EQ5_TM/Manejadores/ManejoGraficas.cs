using PR3_EQ5_TM.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Manejadores
{
    class ManejoGraficas
    {
        public int tamaño;
        private Pantalla frm;
        private GeneradorValores gvl;
        public List<Grafica> ListaGraficas;

        public ManejoGraficas() 
        {
            frm = Application.OpenForms.OfType<Pantalla>().FirstOrDefault();
            Tamaño = 30;
            CrearGraficas();
        }
        public ManejoGraficas(int Tam)
        {
            frm = Application.OpenForms.OfType<Pantalla>().FirstOrDefault();
            Tamaño = Tam;
            CrearGraficas();
        }

        public void CrearGraficas()
        {
            int x = 5, y = 5;
            ListaGraficas = new List<Grafica>();
            gvl = new GeneradorValores(tamaño);
            string tipo = "random";

            for (int i = 0; i < 28; i++)
            {
                ListaGraficas.Add(new Grafica());

                switch (i)
                {
                    case 7:
                        x = 5;
                        y = ListaGraficas[i].Height + 10;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Top = y;
                        tipo = "invertido";
                        ListaGraficas[i].Tipo = tipo;
                        break;
                    case 14:
                        x = 5;
                        y = ListaGraficas[i].Height * 2 + 15;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Top = y;
                        tipo = "casiordenado";
                        ListaGraficas[i].Tipo = tipo;
                        break;
                    case 21:
                        x = 5;
                        y = ListaGraficas[i].Height * 3 + 20;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Top = y;
                        tipo = "pocasunicas";
                        ListaGraficas[i].Tipo = tipo;
                        break;
                    default:
                        ListaGraficas[i].Top = y;
                        ListaGraficas[i].Left = x;
                        ListaGraficas[i].Tipo = tipo;
                        break;
                }

                if(ListaGraficas[i].Tipo == "random")
                {
                    ListaGraficas[i].ActualizarDatos(gvl.Arreglo);
                }
                if (ListaGraficas[i].Tipo == "invertido")
                {
                    ListaGraficas[i].ActualizarDatos(gvl.CasiOrdenado1);
                }
                if (ListaGraficas[i].Tipo == "casiordenado")
                {
                    ListaGraficas[i].ActualizarDatos(gvl.Invertido);
                }
                if (ListaGraficas[i].Tipo == "pocasunicas")
                {
                    ListaGraficas[i].ActualizarDatos(gvl.PocasUnicas1);
                }

                ListaGraficas[i].CambioColor("Principal", frm.pnlColorPrincipal.BackColor);
                ListaGraficas[i].CambioColor("Secundario", frm.PnlColorSecundario.BackColor);
                ListaGraficas[i].BackColor = frm.pnlColorFondo.BackColor;

                x += ListaGraficas[i].Width + 5;
                frm.pnlGraficas.Controls.Add(ListaGraficas[i]);
            }
        }

        internal List<Grafica> ListaGraficas1 { get => ListaGraficas; set => ListaGraficas = value; }
        public int Tamaño { get => tamaño; set => tamaño = value; }
    }
}