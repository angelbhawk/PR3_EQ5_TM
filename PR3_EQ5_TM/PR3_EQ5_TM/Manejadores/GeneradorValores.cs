using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_EQ5_TM.Manejadores
{
    class GeneradorValores
    {
        int[] arreglo, invertido, casiOrdenado, pocasUnicas;

        public GeneradorValores(int tamaño)
        {
            GenerarArregloAleatorio(tamaño);
            PocasUnicas(tamaño);
            InvertirArreglo(tamaño);
            CasiOrdenado();
        }

        private void GenerarArregloAleatorio(int t)
        {
            Random r = new Random();
            int na = 0;
            arreglo = new int[t];
            invertido = new int[t];
            casiOrdenado = new int[t];
            for (int i = 0; i < t; i++)
            {
                na = r.Next(1, t);
                arreglo[i] = na;
                //invertido[i] = na;
                //casiOrdenado[i] = na;
            }
            invertido = (int[])arreglo.Clone();
            //MessageBox.Show(arreglo[0].ToString());
            casiOrdenado = (int[])arreglo.Clone();

        }
        private void InvertirArreglo(int t)
        {
            Array.Sort(invertido);
            Array.Reverse(invertido);
        }
        private void CasiOrdenado()
        {
            Array.Sort(casiOrdenado);
        }
        private void PocasUnicas(int t)
        {
            int c = 0;
            pocasUnicas = new int[t];
            for (int i = 0; i < t; i++)
            {
                if(c == 5)
                {
                    c = 0;
                }

                pocasUnicas[i] = arreglo[c];
                c++;
            }

            foreach (var item in pocasUnicas)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public int[] Arreglo { get => arreglo; set => arreglo = value; }
        public int[] Invertido { get => invertido; set => invertido = value; }
        public int[] CasiOrdenado1 { get => casiOrdenado; set => casiOrdenado = value; }
        public int[] PocasUnicas1 { get => pocasUnicas; set => pocasUnicas = value; }
    }
}