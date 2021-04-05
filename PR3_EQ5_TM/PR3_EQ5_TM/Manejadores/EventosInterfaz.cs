using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Manejadores
{
    class EventosInterfaz
    {
        private Pantalla frm;

        public EventosInterfaz() 
        {
            frm = Application.OpenForms.OfType<Pantalla>().FirstOrDefault();
            AñadirEventos();
        }

        private void AñadirEventos() 
        {
            frm.btnColorPrincipal.Click += new EventHandler(btnPrincipal_Click);
            frm.btnColorSecundario.Click += new EventHandler(btnSecundario_Click);
            frm.btnColorFondo.Click += new EventHandler(btnFondo_Click);
            frm.btnCerrar.Click += new EventHandler(btnSalir_Click);
            frm.btn10.Click += new EventHandler(btnValores_Click);
            frm.btn20.Click += new EventHandler(btnValores_Click);
            frm.btn30.Click += new EventHandler(btnValores_Click);
            frm.btn40.Click += new EventHandler(btnValores_Click);
            frm.btn50.Click += new EventHandler(btnValores_Click);
            frm.btnGenerar.Click += new EventHandler(btnGenerar_Click);
            frm.btnGenerar.Click += new EventHandler(btnGenerar_Click2);
        }
        private void btnGenerar_Click2(object seder, EventArgs e)
        {
            frm.ListaGraficas.Tamaño = Convert.ToInt32(frm.NudTam.Value);
            frm.pnlGraficas.Controls.Clear();
            frm.ListaGraficas.CrearGraficas();
            frm.pnlGraficas.Refresh();
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
                    frm.ListaGraficas.ListaGraficas1[i].CambioColor("Principal", color);
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
                    frm.ListaGraficas.ListaGraficas1[i].CambioColor("Secundario", color);
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
                    frm.ListaGraficas.ListaGraficas1[i].BackColor = color;
            }
            frm.Refresh();
        }
        private void btnValores_Click(object sender, EventArgs e)
        {
            Button btnValor = sender as Button;

            frm.btn10.BackColor = Color.FromArgb(27, 38, 49);
            frm.btn10.ForeColor = SystemColors.ActiveCaption;

            frm.btn20.BackColor = Color.FromArgb(27, 38, 49);
            frm.btn20.ForeColor = SystemColors.ActiveCaption;

            frm.btn30.BackColor = Color.FromArgb(27, 38, 49);
            frm.btn30.ForeColor = SystemColors.ActiveCaption;

            frm.btn40.BackColor = Color.FromArgb(27, 38, 49);
            frm.btn40.ForeColor = SystemColors.ActiveCaption;

            frm.btn50.BackColor = Color.FromArgb(27, 38, 49);
            frm.btn50.ForeColor = SystemColors.ActiveCaption;

            btnValor.BackColor = Color.White;
            btnValor.ForeColor = Color.FromArgb(27, 38, 49);
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(frm.btn10.BackColor == Color.White)
            {
                frm.ListaGraficas.Tamaño = 10;
            }
            if (frm.btn20.BackColor == Color.White)
            {
                frm.ListaGraficas.Tamaño = 20;
            }
            if (frm.btn30.BackColor == Color.White)
            {
                frm.ListaGraficas.Tamaño = 30;
            }
            if (frm.btn40.BackColor == Color.White)
            {
                frm.ListaGraficas.Tamaño = 40;
            }
            if (frm.btn50.BackColor == Color.White)
            {
                frm.ListaGraficas.Tamaño = 50;
            }

            frm.pnlGraficas.Controls.Clear();
            frm.ListaGraficas.CrearGraficas();
            frm.pnlGraficas.Refresh();
        }
    }
}