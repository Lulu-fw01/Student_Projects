using System;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Вывод матрицы в консоль;
        /// </summary>
        /// <param name="mas"></param>
          public static void PrintMatrix(double[][] mas)
        {
            try
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int n = 0; n < mas[i].Length; n++)
                        Console.Write(mas[i][n] + " ");
                    Console.WriteLine();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Упс, не получилось вывести матрицу ");
            }
        }

        /// <summary>
        /// Функция вывода в консоль следа матрицы.
        /// </summary>
        /// <param name="matr"></param>
        public static void PrintMatrixTrace(double[][] matr)
        {
            double trace;
            Console.WriteLine("Матрица: " + '\n');
            PrintMatrix(matr);
            // Нахждение следа матрицы.
            if (GetMatrixTrace(matr, out trace))
                Console.WriteLine("След матрицы равен: {0}", trace);
            else
                Console.WriteLine("Упс, не получиось вычислить след матрицы, возможно матрица не кваратная");
        }

        /// <summary>
        /// Функция вывода в консоль транспонированной матрицы.
        /// </summary>
        /// <param name="matr"></param>
        public static void PrintTransposedMatrix(double[][] matr)
        {
            Console.WriteLine("Матрица: " + '\n');
            PrintMatrix(matr);
            try
            {
                // Получение транспонированной матрицы.
                double[][] transposedMatr = GetMatrixTranspose(matr);
                Console.WriteLine("Транспонированная матрица: " + '\n');
                PrintMatrix(transposedMatr);
            }
            catch(Exception)
            {
                Console.WriteLine("Упс, не получилось транспонировать марицу :(  ");
            }
        }

        /// <summary>
        /// Вывод суммы двух матриц.
        /// </summary>
        /// <param name="matrOne"></param>
        /// <param name="matrTwo"></param>
        public static void PrintSumOftwoMatrixes(double[][] matrOne, double[][] matrTwo)
        {
            Console.WriteLine("Матрица 1: " + '\n');
            PrintMatrix(matrOne); 
            Console.WriteLine("Матрица 2: " + '\n');
            PrintMatrix(matrTwo);
            try
            {
                if (matrOne.Length == matrTwo.Length && matrOne[0].Length == matrTwo[0].Length)
                {
                    // Получение суммы двух матриц.
                    double[][] newMatr = GetSumOfTwoMatrix(matrOne, matrTwo);
                    Console.WriteLine("Сумма матриц: " + '\n');
                    PrintMatrix(newMatr);
                }
                else
                {
                    Console.WriteLine("Ошибка. Матрицы разного размера");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Упс, не получилось сложить матрицы :(  ");
            }

        }

        /// <summary>
        /// Выод разности двух матриц в консоль.
        /// </summary>
        /// <param name="matrOne"></param>
        /// <param name="matrTwo"></param>
        public static void PrintDifferenceOftwoMatrixes(double[][] matrOne, double[][] matrTwo)
        {
            Console.WriteLine("Матрица 1: " + '\n');
            PrintMatrix(matrOne);
            Console.WriteLine("Матрица 2: " + '\n');
            PrintMatrix(matrTwo);
            try
            {
                if (matrOne.Length == matrTwo.Length && matrOne[0].Length == matrTwo[0].Length)
                {
                    // Получение разности двух матриц.
                    double[][] newMatr = GetDifferenceOfTwoMatrix(matrOne, matrTwo);
                    Console.WriteLine("Сумма матриц: " + '\n');
                    PrintMatrix(newMatr);
                }
                else
                {
                    Console.WriteLine("Ошибка. Матрицы разного размера");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Упс, не получилось получить разность матриц :(  ");
            }
        }

        /// <summary>
        /// Вывод результата перемножения двух матриц в консоль.
        /// </summary>
        /// <param name="matrOne"></param>
        /// <param name="matrTwo"></param>
        public static void PrintMatrixMultiplication(double[][] matrOne, double[][] matrTwo)
        {
            Console.WriteLine("Матрица 1: " + '\n');
            PrintMatrix(matrOne);
            Console.WriteLine("Матрица 2: " + '\n');
            PrintMatrix(matrTwo);
            try
            {
                if (matrOne[0].Length == matrTwo.Length)
                {
                    // Получение произведения двух мтриц.
                    double[][] newMatr = GetMatrixMultiplication(matrOne, matrTwo);
                    Console.WriteLine("Произведение матриц: " + '\n');
                    PrintMatrix(newMatr);
                }
                else
                {
                    Console.WriteLine("Ошибка. Неверные размеры матриц");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Упс, не получилось получилось перемножить матрицы :(  ");
            }
        }

        /// <summary>
        /// Вывод результата умножения матрица на число.
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="num"></param>
        public static void PrintMatrixMultiplicationOnNumber(double[][] matr, double num)
        {
            Console.WriteLine("Матрица: " + '\n');
            PrintMatrix(matr);
            Console.WriteLine("число: " + '\n' + num);
            try
            {
                // Получение матрицы умноженной на число.
                double[][] newMatr = GetMatrixMultiplicationByNum(matr, num);
                Console.WriteLine("Произведение матрицы на число: " + '\n');
                PrintMatrix(newMatr);
            }
            catch(Exception)
            {
                Console.WriteLine("Упс, не получилось умножить матрицу на число :(  ");
            }
        }

        /// <summary>
        /// Вывод значения детерминанта матрицы в консоль.
        /// </summary>
        /// <param name="matr"></param>
        public static void PrintMatrixDeterminant(double[][] matr)
        {
            Console.WriteLine("Матрица: " + '\n');
            PrintMatrix(matr);
            try
            {
                if (matr.Length == matr[0].Length)
                {
                    // Получение определителя.
                    double det = GetMatrixDeterminant(matr);
                    Console.WriteLine("определитель матрицы: " + '\n' + det);
                }
                else
                {
                    Console.WriteLine("Матрица не квадратная");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Упс, что-то пошло не так, и у нас не получилось вычислить определитель :(  ");
            }
        }

        /// <summary>
        /// Вывод решения СЛАУ методом Крамера.
        /// </summary>
        /// <param name="oddsMatr"></param>
        /// <param name="ansMatr"></param>
        public static void PrintKramerMethod(double[][] oddsMatr, double[][] ansMatr)
        {
            try
            {
                double[] ans = GetKramerAns(oddsMatr, ansMatr);
                for (int i = 0; i < ans.Length; i++)
                {
                    Console.WriteLine("X{0} = {1}", i,ans[i]);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Не получилось найти решения  :(");
            }
        }
    }
}