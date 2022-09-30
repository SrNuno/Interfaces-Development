using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Aula
    {
        public int[,] notas;
        string[] guardaNombres ;

        public enum Asig
        {
            Pociones,
            Quidditch,
            Criaturas,
            ArtesOscuras
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

        public Aula(string[] nombres)
        {
            this.notas = new int[4, nombres.Length];
            this.guardaNombres = new string[nombres.Length];

            for (int i = 0; i < nombres.Length; i++)
            {
                this.guardaNombres[i] = nombres[i].Trim().ToUpper();
            }

            Random valorNotas = new Random();
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    this.notas[i, j] = valorNotas.Next(11);
                }
            }
        }

        public Aula(string nombres)
            : this(nombres.Split(","))
        {
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


        public double calcMedia()
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    media += notas[i, j];
                }
            }
            media /= notas.Length;
            return media;

        }
        public double mediaAlumno(int posAlumno)
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                media += notas[i, posAlumno];
            }
            media /= notas.GetLength(0);
            return media;
        }
        public double mediaAsignatura(int posMateria)
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                media += notas[posMateria, i];
            }
            media /= notas.GetLength(1);
            return media;
        }
    }
}

