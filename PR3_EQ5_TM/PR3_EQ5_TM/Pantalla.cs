using System;
using System.Windows.Forms;
using PR3_EQ5_TM.Manejadores;

namespace PR3_EQ5_TM
{
    public partial class Pantalla : Form
    {
        private EventosInterfaz manejadorGrafico;
        private ManejoGraficas listaGraficas;
        private ManejoHilos metodosOrdenación;
        public int Tamaño = 30;

        public Pantalla()
        {
            InitializeComponent();
        }

        internal ManejoGraficas ListaGraficas { get => listaGraficas; set => listaGraficas = value; }
        internal EventosInterfaz ManejadorGrafico { get => manejadorGrafico; set => manejadorGrafico = value; }
        internal ManejoHilos MetodosOrdenación { get => metodosOrdenación; set => metodosOrdenación = value; }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            ManejadorGrafico = new EventosInterfaz();
            ListaGraficas = new ManejoGraficas(Tamaño);
            MetodosOrdenación = new ManejoHilos();
        }
    }
}