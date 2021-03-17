using System;

namespace MatrixCalc
{
    partial class Program
    {

        /// <summary>
        /// Функция нахождения следа матрицы.
        /// </summary>
        /// <param name="matr"></param>
        /// <param name="trace"></param>
        /// <returns></returns>
        public static bool GetMatrixTrace(double[][] matr, out double trace)
        {
            // Если матрица не квадратная, то вернется false.
            if (matr.Length != matr[0].Length)
            {
                trace = 0;
                return false; 
            }
            else
            {
                // Если матрица квадратная, то складываем все элементы на главной диагонале.
                trace = 0;
                for(int i = 0; i < matr.Length; i++)
                {
                    trace += matr[i][i];
                }
                return true;
            }
        }
    }
}

/*/
 using System;

namespace MatrixCalc
{
    partial class Program
    {
        
    }
}
/*/