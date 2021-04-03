


using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Manejadores
{
    class ManejadorGrafico
    {
        private Form frm;
        private Graficas gfc;

        public ManejadorGrafico() 
        {
            frm = Application.OpenForms.OfType<Pantalla>().FirstOrDefault();
            AñadirEventos();
        }

        private void AñadirEventos() 
        {
             
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            ColorDialog color2 = new ColorDialog();
            if (color2.ShowDialog() == DialogResult.OK)
            {
                color = color2.Color;
                for (int i = 0; i < 28; i++)
                    gfc.ListaGraficas1[i].CambioColor("Principal", color);
            }
            frm.Refresh();
        }
        private void btnSecundario_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            ColorDialog color2 = new ColorDialog();
            if (color2.ShowDialog() == DialogResult.OK)
            {
                color = color2.Color;
                for (int i = 0; i < 28; i++)
                    gfc.ListaGraficas1[i].CambioColor("Secundario", color);
            }
            frm.Refresh();
        }
        private void btnFondo_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            ColorDialog color2 = new ColorDialog();
            if (color2.ShowDialog() == DialogResult.OK)
            {
                color = color2.Color;
                for (int i = 0; i < 28; i++)
                    gfc.ListaGraficas1[i].BackColor = color;
            }
            frm.Refresh();
        }
    }
}