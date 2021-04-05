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
        Thread HiloBurbu;
        Thread HiloInser;
        Thread HiloSelec;
        Thread HiloShells;
        Thread HiloMerges;
        Thread HiloHeaps;
        Thread HiloQuicks;
        Thread Lat1;
        Thread Lat2;
        Thread Lat3;
        Thread Lat4;
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
            frm.FormClosing += new FormClosingEventHandler(SalirHilos);

            frm.btnRand.Click += new EventHandler(btnRandom_click);
            frm.btnCasi.Click += new EventHandler(btnCasiOr_click);
            frm.btnInvert.Click += new EventHandler(btnInver_click);
            frm.btnPocas.Click += new EventHandler(btnPocas_click);

        }
        // metodo que toma el evento form closing para abortar los hilos al cerrar el form por le usuario
        private void SalirHilos(object sender, EventArgs e)
        {
            if (HiloBurbu!=null)
            {
                HiloBurbu.Abort();
            }
            if (HiloHeaps != null)
            {
                HiloHeaps.Abort();
            }
            if (HiloInser != null)
            {
                HiloInser.Abort();
            }
            if (HiloMerges != null)
            {
                HiloMerges.Abort();
            }
            if (HiloQuicks != null)
            {
                HiloQuicks.Abort();
            }
            if (HiloSelec != null)
            {
                HiloSelec.Abort();
            }
            if (HiloShells != null)
            {
                HiloShells.Abort();
            }
            if (Lat1 != null)
            {
                Lat1.Abort();
            }
            if (Lat2 != null)
            {
                Lat2.Abort();
            }
            if (Lat3 != null)
            {
                Lat3.Abort();
            }
            if (Lat4 != null)
            {
                Lat4.Abort();
            }
        }
        public void btnInserción_Click(object sender, EventArgs e)
        {
            HiloInser = new Thread(Inserciones);
            HiloInser.Start();

        }

        private void btnSelecion_Click(object sender, EventArgs e)
        {
            HiloSelec = new Thread(Selecciones);
            HiloSelec.Start();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            HiloBurbu = new Thread(Burbujas);
            //HiloBurbu.IsBackground = true; también sirve paraa abortar hilos 
            HiloBurbu.Start();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            HiloShells = new Thread(Shells);
            HiloShells.Start();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            HiloMerges = new Thread(Merges);
            HiloMerges.Start();
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            HiloHeaps = new Thread(Heaps);
            HiloHeaps.Start();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            HiloQuicks = new Thread(Quicks);
            HiloQuicks.Start();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            HiloHeaps = new Thread(Heaps);
            HiloHeaps.Start();

            HiloMerges = new Thread(Merges);
            HiloMerges.Start();

            HiloBurbu = new Thread(Burbujas);
            HiloBurbu.Start();

            HiloInser = new Thread(Inserciones);
            HiloInser.Start();

            HiloSelec = new Thread(Selecciones);
            HiloSelec.Start();

            HiloShells = new Thread(Shells);
            HiloShells.Start();

            HiloQuicks = new Thread(Quicks);
            HiloQuicks.Start();
        }
        private void btnRandom_click(object sender, EventArgs e)
        {
            int i = 0;
            // () =>  para especificar un parametro a un thread
            Lat1 = new Thread(() => LatIn(i));
            Task.Run(() => LatSele(i));
            Task.Run(() => LatBurbu(i));
            Task.Run(() => LatShell(i));
            Task.Run(() => LatQuick(i));
            Task.Run(() => LatMerge(i));
            Task.Run(() => LatHeap(i));
            Lat1.Start();
        }
        private void btnCasiOr_click(object sender, EventArgs e)
        {
            int i = 7;
            // () =>  para especificar un parametro a un thread
            Lat2 = new Thread(() => LatIn(i));
            Task.Run(() => LatSele(i));
            Task.Run(() => LatBurbu(i));
            Task.Run(() => LatShell(i));
            Task.Run(() => LatQuick(i));
            Task.Run(() => LatMerge(i));
            Task.Run(() => LatHeap(i));
            Lat2.Start();
        }
        private void btnPocas_click(object sender, EventArgs e)
        {
            int i = 21;
            // () =>  para especificar un parametro a un thread
            Lat4 = new Thread(() => LatIn(i));
            Task.Run(() => LatSele(i));
            Task.Run(() => LatBurbu(i));
            Task.Run(() => LatShell(i));
            Task.Run(() => LatQuick(i));
            Task.Run(() => LatMerge(i));
            Task.Run(() => LatHeap(i));
            Lat4.Start();
        }
        private void btnInver_click(object sender, EventArgs e)
        {
            int i = 14;
            // () =>  para especificar un parametro a un thread
            Lat3 = new Thread(() => LatIn(i));
            Task.Run(() => LatSele(i));
            Task.Run(() => LatBurbu(i));
            Task.Run(() => LatShell(i));
            Task.Run(() => LatQuick(i));
            Task.Run(() => LatMerge(i));
            Task.Run(() => LatHeap(i));
            Lat3.Start();
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
        //botones del lado izquierdo
        public void LatIn(int i)
        {
            frm.ListaGraficas.ListaGraficas[0+i].Ordenar("Inserción Binaria");
        }
        public void LatSele(int i)
        {
            frm.ListaGraficas.ListaGraficas[1 + i].Ordenar("Selección");
        }
        public void LatBurbu(int i)
        {
            frm.ListaGraficas.ListaGraficas[2 + i].Ordenar("Burbuja Mejorada");
        }
        public void LatShell(int i)
        {
            frm.ListaGraficas.ListaGraficas[3 + i].Ordenar("Shell");
        }
        public void LatQuick(int i)
        {
            frm.ListaGraficas.ListaGraficas[4 + i].Ordenar("Quicksort");
        }
        public void LatMerge(int i)
        {
            frm.ListaGraficas.ListaGraficas[5 + i].Ordenar("Merge");
        }
        public void LatHeap(int i)
        {
            frm.ListaGraficas.ListaGraficas[6 + i].Ordenar("Heap");
        }

    }
}