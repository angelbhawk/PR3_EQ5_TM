using System;
using System.Windows.Forms;
using PR3_EQ5_TM.Manejadores;

namespace PR3_EQ5_TM
{
    public partial class Pantalla : Form
    {
        ManejadorGrafico manejadorGrafico;
        Graficas graficas;

        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            manejadorGrafico = new ManejadorGrafico();
            graficas = new Graficas();
        }
    }
}
