using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR3_EQ5_TM.Manejadores
{
    class ManejadorFlujo
    {
        Graficas graficas;

        public ManejadorFlujo() 
        {
            graficas = new Graficas();
        }

        public void btnInserción_Click(object sender, EventArgs e)
        {
            Thread HiloInser = new Thread(graficas.Inserciones);
            HiloInser.Start();
        }

        private void btnSelecion_Click(object sender, EventArgs e)
        {
            Thread HiloSelec = new Thread(graficas.Selecciones);
            HiloSelec.Start();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Thread HiloBurbu = new Thread(graficas.Burbujas);
            HiloBurbu.Start();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            Thread HiloShells = new Thread(graficas.Shells);
            HiloShells.Start();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            Thread HiloMerges = new Thread(graficas.Merges);
            HiloMerges.Start();
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            Thread HiloHeaps = new Thread(graficas.Heaps);
            HiloHeaps.Start();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            Thread HiloQuicks = new Thread(graficas.Quicks);
            HiloQuicks.Start();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Thread HiloHeap = new Thread(graficas.Heaps);
            HiloHeap.Start();

            Thread HiloMerges = new Thread(graficas.Merges);
            HiloMerges.Start();

            Thread HiloBurbu = new Thread(graficas.Burbujas);
            HiloBurbu.Start();

            Thread HiloInser = new Thread(graficas.Inserciones);
            HiloInser.Start();

            Thread HiloSelec = new Thread(graficas.Selecciones);
            HiloSelec.Start();

            Thread HiloShells = new Thread(graficas.Shells);
            HiloShells.Start();

            Thread HiloQuicks = new Thread(graficas.Quicks);
            HiloQuicks.Start();
        }
    }
}