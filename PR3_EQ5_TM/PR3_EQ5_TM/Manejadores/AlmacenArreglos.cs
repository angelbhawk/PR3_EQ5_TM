using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_EQ5_TM.Manejadores
{
    class AlmacenArreglos
    {
        int[] arreglo, invertido, casiOrdenado, pocasUnicas;

        public AlmacenArreglos(int tamaño)
        {
            GenerarArregloAleatorio();
            InvertirArreglo();
            CasiOrdenado();
            PocasUnicas();
        }

        private void GenerarArregloAleatorio()
        {

        }
        private void InvertirArreglo()
        {

        }
        private void CasiOrdenado()
        {

        }
        private void PocasUnicas()
        {

        }

        public int[] Arreglo { get => arreglo; set => arreglo = value; }
        public int[] Invertido { get => invertido; set => invertido = value; }
        public int[] CasiOrdenado1 { get => casiOrdenado; set => casiOrdenado = value; }
        public int[] PocasUnicas1 { get => pocasUnicas; set => pocasUnicas = value; }
    }
}