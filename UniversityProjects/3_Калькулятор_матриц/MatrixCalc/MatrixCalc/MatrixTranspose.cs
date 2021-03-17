using System;

namespace MatrixCalc
{
    partial class Program
    {

        /// <summary>
        /// Функция траспонирования матрицы.
        /// </summary>
        /// <param name="oldMatr"></param>
        /// <returns></returns>
        public static double[][] GetMatrixTranspose(double[][] oldMatr)
        {
            double[][] transposedMatr = new double[oldMatr[0].Length][];
            for(int i = 0; i < transposedMatr.Length; i++)
            {
                // Преобразование столбца в строку.
                transposedMatr[i] = LineFromStick(oldMatr, i);
            }
            return transposedMatr;
        }

        /// <summary>
        /// Функция конвертирующая столбец матрицы в строку.
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="stickNum"></param>
        /// <returns></returns>
        public static double[] LineFromStick(double[][] matr, int stickNum)
        {
            double[] line = new double[matr.Length];
            for(int i = 0; i < matr.Length; i++)
            {
                line[i] = matr[i][stickNum];
            }
            return line;
        }
    }
}