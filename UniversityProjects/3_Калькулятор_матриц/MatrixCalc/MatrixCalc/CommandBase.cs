using System;
using System.IO;

namespace MatrixCalc
{
    partial class Program
    {
        public static bool MakingConsoleInputSLAU(out double[][] matr, int n, int k)
        {
            try
            {
                matr = InputMatrix(n, k);
                return true;
            }
            catch (Exception)
            {
                matr = new double[0][];
                return false;
            }
        }

        /// <summary>
        /// Функция ввода размеров матрицы и вызов функции ввода матрицы через консоль.
        /// </summary>
        /// <param name="matr"></param>
        /// <returns></returns>
        public static bool MakingConsoleInputMatrix(out double[][] matr)
        {
            int n, k;
            try
            {
                InputSizes(out n, out k);
                matr = InputMatrix(n, k);
                return true;
            }
            catch (Exception)
            {
                matr = new double[0][];
                return false;
            }
        }

        /// <summary>
        /// Функция ввода размеров матрицы и последующее создание рандомной матрицы.
        /// </summary>
        /// <param name="matr"></param>
        /// <returns></returns>
        public static bool MakingRandomMatrix(out double[][] matr)
        {
            int n, k;
            try
            {
                InputSizes(out n, out k);
                matr = MakeRandomMatrix(n, k);
                return true;
            }
            catch
            {
                matr = new double[0][];
                return false;
            }
        }

        /// <summary>
        /// Ввод пути к файлу и вызов функции считывания атрицы из файла.
        /// </summary>
        /// <param name="matr"></param>
        /// <returns></returns>
        public static bool MakingMatrixFromFile(out double[][] matr)
        {
            Console.WriteLine("Введите полный путь к текстовому файлу (формат: D:{0}examplefolder{0}file.txt", Path.DirectorySeparatorChar);
            string path = Console.ReadLine();
            return ReadMatrixFromFile(path, out matr);
        }

        /// <summary>
        /// Все варианты ввода матрицы.
        /// </summary>
        /// <param name="CommandNum"></param>
        /// <param name="matr"></param>
        /// <returns></returns>
        public static bool InputCommandBase(int CommandNum, out double[][] matr)
        {
            switch(CommandNum)
            {
                // Ввод матрицы с клавиатуры.
                case 1:
                    return MakingConsoleInputMatrix(out matr);
                // Составление рандомной матрицы.
                case 2:
                    return MakingRandomMatrix(out matr);
                // Считывание матрицы из файла.
                case 3:
                    return MakingMatrixFromFile(out matr);
                default:
                    matr = new double[0][];
                    return false;
            }
        }

        /// <summary>
        /// Все операции с матрицами.
        /// </summary>
        /// <param name="CommandNum"></param>
        public static void CommandBase(int CommandNum)
        {
            switch(CommandNum)
            {
                // Cлед матрицы.
                case 1:
                    MakeMatrixTrace();
                    break;
                // Транспонирование матрицы.
                case 2:
                    MakeTransposeMatrix();
                    break;
                // Сумма 2-ух матриц. 
                case 3:
                    MakeSumOfTwoMatrixes();
                    break;
                // Разность 2-ух матриц.
                case 4:
                    MakeDifferenceOfTwoMatrixes();
                    break;
                // Произведение двух матриц.
                case 5:
                    MakeMatrixMultiplication();
                    break;
                // Умножение матрицы на число.
                case 6:
                    MakeMatrixMultiplicationByNumber();
                    break;
                // Найти определитель матрицы.
                case 7:
                    MakeMatrixDet();
                    break;
                // Метод Крамера для решения Слау.
                case 8:
                    MakingKramerMethod();
                    break;
                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }
        }

        /*/"1.нахождение следа матрицы;" + '\n' +
                "2.транспонирование матрицы;" + '\n' +
                "3.сумма двух матриц;" + '\n' +
                "4.разность двух матриц;" + '\n' +
                "5.произведение двух матриц;" + '\n' +
                "6.умножение матрицы на число;" + '\n' +
                "7.нахождение определителя матрицы." /*/

        /// <summary>
        /// Функция ввода матрицы и вызова функции нахождения следа матрицы.
        /// </summary>
        public static void MakeMatrixTrace()
        {
            InputMatrixVariantsMessage();
            InputCommandNum(out int commandNum);
            double[][] ourMatrix;
            if (InputCommandBase(commandNum, out ourMatrix) == true)
            {
                PrintMatrixTrace(ourMatrix);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Ввод матрицы и вызов функции транспонирования данной матрицы.
        /// </summary>
        public static void MakeTransposeMatrix()
        {
            InputMatrixVariantsMessage();
            InputCommandNum(out int commandNum);
            double[][] ourMatrix;
            if (InputCommandBase(commandNum, out ourMatrix) == true)
            {
                PrintTransposedMatrix(ourMatrix);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Ввод матриц и вывод их суммы.
        /// </summary>
        public static void MakeSumOfTwoMatrixes()
        {
            Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ. Чтобы вычислить сумму двух матриц, их размеры должны быть одинаковы");
            CommandsForTwoMatrixes(out int commandNumFirst, out int commandNumSecond);
            double[][] ourMatrixFirst;
            double[][] ourMatrixSecond;
            Console.WriteLine("Если вы выбрали пункт 1 или 2 для обеих матриц, то сначала введите размеры первой матрицы, а затем размеры второй матрицы");
            if (InputCommandBase(commandNumFirst, out ourMatrixFirst) == true && InputCommandBase(commandNumSecond, out ourMatrixSecond) == true)
            {
                PrintSumOftwoMatrixes(ourMatrixFirst, ourMatrixSecond);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Ввод матриц и вывод их разницы.
        /// </summary>
        public static void MakeDifferenceOfTwoMatrixes()
        {
            Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ. Чтобы вычислить разность двух матриц, их размеры должны быть одинаковы");
            CommandsForTwoMatrixes(out int commandNumFirst, out int commandNumSecond);
            double[][] ourMatrixFirst;
            double[][] ourMatrixSecond;
            Console.WriteLine("Если вы выбрали пункт 1 или 2 для обеих матриц, то сначала введите размеры первой матрицы, а затем размеры второй матрицы");
            if (InputCommandBase(commandNumFirst, out ourMatrixFirst) == true && InputCommandBase(commandNumSecond, out ourMatrixSecond) == true)
            {
                PrintDifferenceOftwoMatrixes(ourMatrixFirst, ourMatrixSecond);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Ввод матриц и вызов функции их перемножения.
        /// </summary>
        public static void MakeMatrixMultiplication()
        {
            Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ." + '\n' + "Чтобы перемножить матрицы, количество столбцов в перой матрице должно быть равно количеству строк во второй " + '\n');
            CommandsForTwoMatrixes(out int commandNumFirst, out int commandNumSecond);
            double[][] ourMatrixFirst;
            double[][] ourMatrixSecond;
            Console.WriteLine("Если вы выбрали пункт 1 или 2 для обеих матриц, то сначала введите размеры первой матрицы, а затем размеры второй матрицы");
            if (InputCommandBase(commandNumFirst, out ourMatrixFirst) == true && InputCommandBase(commandNumSecond, out ourMatrixSecond) == true)
            {
                PrintMatrixMultiplication(ourMatrixFirst, ourMatrixSecond);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Ввод команд для функций, где происходят операции с двумя матрицами.
        /// </summary>
        /// <param name="commandOne"></param>
        /// <param name="commandTwo"></param>
        public static void CommandsForTwoMatrixes(out int commandOne, out int commandTwo)
        {
            Console.WriteLine("Как вы хотите ввести первую матрицу ?");
            InputMatrixVariantsMessage();
            InputCommandNum(out commandOne);
            Console.WriteLine("Как вы хотите ввести вторую матрицу ?");
            InputMatrixVariantsMessage();
            InputCommandNum(out commandTwo);
        }

        /// <summary>
        /// Ввод матрицы и числа и вызов функции умножения матрицы на число.
        /// </summary>
        public static void MakeMatrixMultiplicationByNumber()
        {
            Console.WriteLine("Как вы хотите ввести матрицу ?");
            InputMatrixVariantsMessage();
            InputCommandNum(out int commandNum);
            double[][] ourMatrix;
            if (InputCommandBase(commandNum, out ourMatrix) == true )
            {
                InputDoubleNum(out double ourNum);
                PrintMatrixMultiplicationOnNumber(ourMatrix, ourNum);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Функция ввода матрицы и вызов функции нахождения определителя.
        /// </summary>
        public static void MakeMatrixDet()
        {
            Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ." + '\n' + "Чтобы вчислить определитель матрицы, она должна быть квадратной" + '\n');
            Console.WriteLine("Как вы хотите ввести матрицу ?");
            InputMatrixVariantsMessage();
            InputCommandNum(out int commandNum);
            double[][] ourMatrix;
            if (InputCommandBase(commandNum, out ourMatrix) == true)
            {
                PrintMatrixDeterminant(ourMatrix);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, возможно неверные данные в файле");
            }
        }

        /// <summary>
        /// Ввод СЛАУ и вызов решения методом Крамера.
        /// </summary>
        public static void MakingKramerMethod()
        {
            Console.WriteLine("Сколько уравнений в сестеме ?");
            InputCommandNum(out int equa);
            Console.WriteLine("Сколько неизвестных ?");
            InputCommandNum(out int unknown);
            Console.WriteLine("Введите матрицу, где ее элементы - это коэффециенты прит неизвестных: ");
            InputMatrixVariantsMessage();
            InputCommandNum(out int commandNum);
            double[][] ourMatrix;
            if (MakingConsoleInputSLAU(out ourMatrix,equa, unknown) == true)
            {
                Console.WriteLine("Теперь в столбик введиете значения, которым равно каждое уравнение: ");
                double[][] ans;
                if (MakingConsoleInputSLAU(out ans, equa, 1) == true)
                {
                    PrintKramerMethod(ourMatrix, ans);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}