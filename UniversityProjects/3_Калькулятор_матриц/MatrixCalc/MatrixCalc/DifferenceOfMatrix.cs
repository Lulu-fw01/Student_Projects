using System;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Функция получения разницы двух матриц.
        /// </summary>
        /// <param name="matrOne"></param>
        /// <param name="matrTwo"></param>
        /// <returns></returns>
        public static double[][] GetDifferenceOfTwoMatrix(double[][] matrOne, double[][] matrTwo)
        {
            double[][] newMatr = new double[matrOne.Length][];
            for (int i = 0; i < matrOne.Length; i++)
            {
                // Получение разности двух строк.
                newMatr[i] = GetDifferenceOfTwoLines(matrOne[i], matrTwo[i]);
            }
            return newMatr;
        }

        /// <summary>
        /// Функция получения разнцицы двух строк.
        /// </summary>
        /// <param name="lineOne"></param>
        /// <param name="lineTwo"></param>
        /// <returns></returns>
        public static double[] GetDifferenceOfTwoLines(double[] lineOne, double[] lineTwo)
        {
            double[] newLine = new double[lineOne.Length];
            for (int i = 0; i < lineOne.Length; i++)
                newLine[i] = lineOne[i] - lineTwo[i];
            return newLine;
        }
    }
}