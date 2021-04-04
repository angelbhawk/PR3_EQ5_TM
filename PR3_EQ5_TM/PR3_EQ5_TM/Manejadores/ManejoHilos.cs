using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Manejadores
{
    class ManejoHilos
    {
        private Pantalla frm;

        public ManejoHilos() 
        {
            frm = Application.OpenForms.OfType<Pantalla>().FirstOrDefault();
            AñadirEventos();
        }

        private void AñadirEventos()
        {
            frm.btnInserción.Click += new EventHandler(btnInserción_Click);
            frm.btnSelecion.Click += new EventHandler(btnSelecion_Click);
            frm.btnBurbuja.Click += new EventHandler(btnBurbuja_Click);
            frm.btnShell.Click += new EventHandler(btnShell_Click);
            frm.btnMerge.Click += new EventHandler(btnMerge_Click);
            frm.btnHeap.Click += new EventHandler(btnHeap_Click);
            frm.btnQuick.Click += new EventHandler(btnQuick_Click);
            frm.btnTodos.Click += new EventHandler(btnAll_Click);
        }

        public void btnInserción_Click(object sender, EventArgs e)
        {
            Thread HiloInser = new Thread(Inserciones);
            HiloInser.Start();

        }

        private void btnSelecion_Click(object sender, EventArgs e)
        {
            Thread HiloSelec = new Thread(Selecciones);
            HiloSelec.Start();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Thread HiloBurbu = new Thread(Burbujas);
            HiloBurbu.Start();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            Thread HiloShells = new Thread(Shells);
            HiloShells.Start();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            Thread HiloMerges = new Thread(Merges);
            HiloMerges.Start();
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            Thread HiloHeaps = new Thread(Heaps);
            HiloHeaps.Start();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            Thread HiloQuicks = new Thread(Quicks);
            HiloQuicks.Start();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Thread HiloHeap = new Thread(Heaps);
            HiloHeap.Start();

            Thread HiloMerges = new Thread(Merges);
            HiloMerges.Start();

            Thread HiloBurbu = new Thread(Burbujas);
            HiloBurbu.Start();

            Thread HiloInser = new Thread(Inserciones);
            HiloInser.Start();

            Thread HiloSelec = new Thread(Selecciones);
            HiloSelec.Start();

            Thread HiloShells = new Thread(Shells);
            HiloShells.Start();

            Thread HiloQuicks = new Thread(Quicks);
            HiloQuicks.Start();
        }

        public void Inserciones()
        {
            frm.ListaGraficas.ListaGraficas[0].Ordenar("Inserción Binaria");
            frm.ListaGraficas.ListaGraficas[7].Ordenar("Inserción Binaria");
            frm.ListaGraficas.ListaGraficas[14].Ordenar("Inserción Binaria");
            frm.ListaGraficas.ListaGraficas[21].Ordenar("Inserción Binaria");
        }
        public void Selecciones()
        {
            frm.ListaGraficas.ListaGraficas[1].Ordenar("Selección");
            frm.ListaGraficas.ListaGraficas[8].Ordenar("Selección");
            frm.ListaGraficas.ListaGraficas[15].Ordenar("Selección");
            frm.ListaGraficas.ListaGraficas[22].Ordenar("Selección");
        }
        public void Burbujas()
        {
            frm.ListaGraficas.ListaGraficas[2].Ordenar("Burbuja Mejorada");
            frm.ListaGraficas.ListaGraficas[9].Ordenar("Burbuja Mejorada");
            frm.ListaGraficas.ListaGraficas[16].Ordenar("Burbuja Mejorada");
            frm.ListaGraficas.ListaGraficas[23].Ordenar("Burbuja Mejorada");
        }
        public void Shells()
        {
            frm.ListaGraficas.ListaGraficas[3].Ordenar("Shell");
            frm.ListaGraficas.ListaGraficas[10].Ordenar("Shell");
            frm.ListaGraficas.ListaGraficas[17].Ordenar("Shell");
            frm.ListaGraficas.ListaGraficas[24].Ordenar("Shell");
        }
        public void Quicks()
        {
            frm.ListaGraficas.ListaGraficas[6].Ordenar("Quicksort");
            frm.ListaGraficas.ListaGraficas[13].Ordenar("Quicksort");
            frm.ListaGraficas.ListaGraficas[20].Ordenar("Quicksort");
            frm.ListaGraficas.ListaGraficas[27].Ordenar("Quicksort");
        }

        public void Merges()
        {
            frm.ListaGraficas.ListaGraficas[4].Ordenar("Merge");
            frm.ListaGraficas.ListaGraficas[11].Ordenar("Merge");
            frm.ListaGraficas.ListaGraficas[18].Ordenar("Merge");
            frm.ListaGraficas.ListaGraficas[25].Ordenar("Merge");
        }
        public void Heaps()
        {
            frm.ListaGraficas.ListaGraficas[5].Ordenar("Heap");
            frm.ListaGraficas.ListaGraficas[12].Ordenar("Heap");
            frm.ListaGraficas.ListaGraficas[19].Ordenar("Heap");
            frm.ListaGraficas.ListaGraficas[26].Ordenar("Heap");
        }
    }
}