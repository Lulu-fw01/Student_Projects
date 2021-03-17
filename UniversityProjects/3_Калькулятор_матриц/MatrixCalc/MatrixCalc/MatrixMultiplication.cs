using System;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Функция перемножения двух матриц.
        /// </summary>
        /// <param name="mas1"></param>
        /// <param name="mas2"></param>
        /// <returns></returns>
        public static double[][] GetMatrixMultiplication(double[][] mas1, double[][] mas2)
        {
            double[][] newmas = new double[mas1.Length][];
            for (int i = 0; i < newmas.Length; i++)
            {
                // Получение новой строки.
                newmas[i] = GetLineForMultiplication(mas1[i], mas2);
            }
            return newmas;
        }

        /// <summary>
        /// Получение новой строки в матрице раной призведению двух.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="secMatr"></param>
        /// <returns></returns>
        public static double[] GetLineForMultiplication(double[] line, double[][] secMatr)
        {
            double[] newLine = new double[secMatr[0].Length];
            for(int i = 0; i < newLine.Length; i++)
            {
                newLine[i] = 0;
                for(int n = 0; n < secMatr.Length; n++)
                {
                    newLine[i] = newLine[i] + line[n] * secMatr[n][i];
                }
            }
            return newLine;
        }
    }

}