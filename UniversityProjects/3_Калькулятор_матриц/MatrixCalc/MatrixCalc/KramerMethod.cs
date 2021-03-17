using System;

namespace MatrixCalc
{
    partial class Program
    {

        /// <summary>
        /// Функция нахождения решения методом крамера.
        /// </summary>
        /// <param name="oddsMatr"></param>
        /// <param name="ansMatr"></param>
        /// <returns></returns>
        public static double[] GetKramerAns(double[][] oddsMatr, double[][] ansMatr)
        {
            double[] unknowns = new double[oddsMatr[0].Length];
            // Получение главного детерминанта.
            double mainDet = GetMatrixDeterminant(oddsMatr);
            for (int i = 0; i < oddsMatr[0].Length; i++)
            {
                // Нахождение каждого корня методом Крамера.
                unknowns[i] = GetMatrixDeterminant(ChangedStickMatrix(oddsMatr, ansMatr, i)) / mainDet;
            }

            return unknowns;
        }

        /// <summary>
        /// Функция замены стобца в матрице.
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="newStick"></param>
        /// <param name="stickNum"></param>
        /// <returns></returns>
        public static double[][] ChangedStickMatrix(double[][] matr, double[][] newStick, int stickNum)
        {
            double[][] newMatr = new double[matr.Length][];
            for (int i = 0; i < newMatr.Length; i++)
            {
                // Получение измененной строки.
                newMatr[i] = GetChangedLine(matr[i], newStick[i], stickNum);
            }
            return newMatr;
        }

        /// <summary>
        /// Функция замены элемента в строке.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="newVal"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double[] GetChangedLine(double[] line, double[] newVal, int num)
        {
            double[] newLine = new double[line.Length];
            for (int i = 0; i < newLine.Length; i++)
            {
                // Замена элемента в строке.
                if (i == num)
                {
                    newLine[i] = newVal[0];
                }
                else
                {
                    newLine[i] = line[i];
                }
            }
            return newLine;
        }
    }
}