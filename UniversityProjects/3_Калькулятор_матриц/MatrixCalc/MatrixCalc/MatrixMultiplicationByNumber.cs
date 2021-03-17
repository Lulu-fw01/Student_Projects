using System;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Функция умножения матрицы на число.
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double[][] GetMatrixMultiplicationByNum(double[][] matr, double num)
        {
            double[][] newMatr = new double[matr.Length][];
            for(int i = 0; i < matr.Length; i++)
            {
                // Получение строки, которая равна старой строке, умноженной на число.
                newMatr[i] = GetLineMultiplicationOnNumber(matr[i], num);
            }
            return newMatr;
        }

        /// <summary>
        /// Функция умножения строки матрицы на число.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public  static double[] GetLineMultiplicationOnNumber(double[] line, double num)
        {
            double[] newLine = new double[line.Length];
            // Умножение каждого элемента строки на число.
            for(int i = 0; i < newLine.Length; i++)
            {
                newLine[i] = line[i] * num;
            }
            return newLine;
        }
    }
}