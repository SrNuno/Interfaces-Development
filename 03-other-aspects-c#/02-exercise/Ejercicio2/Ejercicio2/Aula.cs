using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Aula
    {
        public int[,] notas = { };
        string[] guardaNombres = { };
        Random valorNotas = new Random();

        public Aula(string[] nombres)
        {
            notas = new int[nombres.Length, 4];
            numeros();

            for (int i = 0; i < nombres.Length; i++)
            {
                guardaNombres[i] = nombres[i].Trim().ToUpper();
            }
        }

        public Aula(string nombres)
        {
            numeros();
            string[] auxiliar = nombres.Split(',');
            for (int i = 0; i < guardaNombres.Length; i++)
            {
                guardaNombres[i] = auxiliar[i].Trim().ToUpper();
            }
        }

        void minMaxAlumno(int numAlumno, ref int min, ref int max)
        {
            int auxMin = 10;
            int auxMax = 0;

            for (int i = 0; i < notas.GetUpperBound(1); i++)
            {
                if (notas[numAlumno, i] < auxMin)
                {
                    min = notas[numAlumno, i];
                }

                if (notas[numAlumno, i] > auxMax)
                {
                    max = notas[numAlumno, i];
                }

            }
        }

        public int this[int i, int j]
        {
            set
            {
                notas[i, j] = value;
            }

            get
            {
                return notas[i, j];
            }
        }

        public void numeros()
        {
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = valorNotas.Next(0, 10);
                }
            }
        }
    }
}
