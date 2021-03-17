using System;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Функция вычисления детерминанта.
        /// </summary>
        /// <param name="matr"></param>
        /// <returns></returns>
        public static double GetMatrixDeterminant(double[][] matr)
        {
            double det = 0;
            if (matr.Length == 1 && matr[0].Length == 1)
            {
                det = matr[0][0];
            }
            else
            {
                double[] byStr = matr[0];
                // Нахождение определителя разложением по строке.
                for (int i = 0; i < byStr.Length; i++)
                {
                    det = det + Math.Pow(-1, 1 + i + 1) * byStr[i] * GetMatrixDeterminant(GetCuttedMatrix(matr, 0, i));
                }
            }
            return det;
        }

        /// <summary>
        /// вычеркивание из матрицы строки вызов функции вычеркивания элемента из строки.
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static double[][] GetCuttedMatrix(double[][] matr, int i, int j)
        {
            double[][] newMatr = new double[matr.Length - 1][];
            for(int n = 0, k = 0; n < matr.Length; n++)
            {
                // Вычеркиваем ненужную строку.
                if(n != i)
                {
                    // Получение строки без элемента вычеркнутого столбца.
                    newMatr[k] = GetCuttedLine(matr[n], j);
                    k++;
                }
            }
            return newMatr;
        }

        /// <summary>
        /// Функция вычеркивания элемента из строки.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static double[] GetCuttedLine(double[] line, int j)
        {
            double[] newLine = new double[line.Length - 1];
            for(int i = 0, n = 0; i < line.Length; i++)
            {
                // Вычеркиваем ненужный элемент.
                if(i != j)
                {
                    newLine[n] = line[i];
                    n++;
                }
            }
            return newLine;
        }

    }
}