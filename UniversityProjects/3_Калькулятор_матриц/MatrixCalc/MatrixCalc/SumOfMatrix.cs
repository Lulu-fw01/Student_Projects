using System;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Функция, считающая разность двух матриц.
        /// </summary>
        /// <param name="matrOne"></param>
        /// <param name="matrTwo"></param>
        /// <returns></returns>
        public static double[][] GetSumOfTwoMatrix(double[][] matrOne, double[][] matrTwo)
        {
            // По-хорошему тут конечно надо написать перегрузки операторов для +, - и возможно * .
            // Но из-за нехватки времени я не могу разобраться с этой темой, А последний раз я писал перегрзуки операторов года 3 назад.

            double[][] newMatr = new double[matrOne.Length][];
            for(int i = 0; i < matrOne.Length; i++)
            {
                // Получение суммы двух строк(линий) матрицы.
                newMatr[i] = GetSumOfTwoLines(matrOne[i], matrTwo[i]);
            }

            return newMatr;
        }

        /// <summary>
        /// Функция, считающая сумму двух строк.
        /// </summary>
        /// <param name="lineOne"></param>
        /// <param name="lineTwo"></param>
        /// <returns></returns>
        public static double[] GetSumOfTwoLines(double[] lineOne, double[] lineTwo)
        {
            double[] newLine = new double[lineOne.Length];
            for (int i = 0; i < lineOne.Length; i++)
                newLine[i] = lineOne[i] + lineTwo[i];
            return newLine;
        }
    }
}