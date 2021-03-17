using System;
using System.IO;

namespace MatrixCalc
{
    partial class Program
    {
        /// <summary>
        /// Ввод числа для умножения матрицы на него.
        /// </summary>
        /// <param name="num"></param>
        public static void InputDoubleNum(out double num)
        {
            Console.WriteLine("Введите число на которое хотите умножить матрицу: ");
            while (double.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine("неверный формат. Попробуйте еще раз");
            }
        }

        /// <summary>
        /// Функция ввода размеров матрицы.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public static void InputSizes(out int n, out int k)
        {
            // Ввод количества строк и столбцов.
            Console.WriteLine("Введите количесво строкБ, не более 10");
            InputCommandNum(out n);
            if (n > 10)
                n = 10;
            Console.WriteLine("Введите количесво столбцов, не более 10");
            InputCommandNum(out k);
            if (k > 10)
                k = 10;
        }

        /// <summary>
        /// Ввод целого числа, номера команды
        /// </summary>
        /// <param name="num"></param>
        public static void InputCommandNum(out int num)
        {
            while(int.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine("неверный формат. Попробуйте еще раз");
            }
        }

        /// <summary>
        /// Функция ввода матрицы с клавиатуры.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double[][] InputMatrix(int n, int k)
        {
            double[][] matr = new double[n][];
            for (int i = 0; i < n; i++)
            {
                while( InputNewLine(k, out matr[i]) == false)
                {
                    Console.WriteLine("Ошибка. Возможно вы ввели некорректное значение. Попробуйте еще раз");
                }
            }
            return matr;
        }

        /// <summary>
        /// Функция ввода строки матрицы.
        /// </summary>
        /// <param name="len"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        public static bool InputNewLine(int len, out double[] line)
        {
            Console.WriteLine("Введите строку матрицы, элементы разделяются пробелом.(формат: 1 2 3 4");
            string[] s = Console.ReadLine().Split(' ');
            while(s.Length != len)
            {
                Console.WriteLine("Количество элементов в строке не соответствует заданному. Попробуйте еще");
                s = Console.ReadLine().Split(' ');
            }
            line = new double[len];
            for(int i = 0; i < len; i++)
            {
                if (double.TryParse(s[i], out line[i]) == false)
                    return false;
            }
            return true;
        }

        /// <summary>
        ///  Функция создания матрицы, составленной из рандомных элементов.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double[][] MakeRandomMatrix(int n, int k)
        {
            int dNum, hNum;
            Console.WriteLine("Введите нижнюю границу диапазона генерируемых чисел(целое число)" );
            InputCommandNum(out dNum);
            Console.WriteLine("Введите верхнюю границу диапазона генерируемых чисел(целое число)");
            InputCommandNum(out hNum);
            while(dNum > hNum)
            {
                Console.WriteLine("Некорректные данные, попробуйте еще раз");
                Console.WriteLine("Введите нижнюю границу диапазона генерируемых чисел (целое число)");
                InputCommandNum(out dNum);
                Console.WriteLine("Введите верхнюю границу диапазона генерируемых чисел (целое число)");
                InputCommandNum(out hNum);
            }
            
            double[][] matr = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matr[i] = NewRandomLine(k, dNum, hNum);
            }
            return matr;
        }

        /// <summary>
        /// Создание рандомной строки матрицы.
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static double[] NewRandomLine(int len, int dNum, int hNum)
        {
            double[] line = new double[len];
            Random rnd = new Random();
            for(int i = 0; i < len; i++)
            {
                line[i] = rnd.Next((dNum), (hNum)) + rnd.NextDouble() ;
                if(line[i] > hNum)
                {
                    line[i]--;
                }

            }
            return line;
        }

        /// <summary>
        /// Считывание матрицы из файла.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="matr"></param>
        /// <returns></returns>
        public static bool ReadMatrixFromFile(string path, out double[][] matr)
        {
            try
            {
                string[] s = File.ReadAllLines(path);
                string[][] nums = new string[s.Length][];
                double[] line;

                for (int i = 0; i < s.Length; i++)
                {
                    nums[i] = s[i].Split(' ');
                }

                matr = new double[nums.Length][];
                int k = nums[0].Length;
                line = new double[k];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i].Length != k)
                        return false;
                    line = new double[k];
                    for (int n = 0; n < k; n++)
                    {
                        if (double.TryParse(nums[i][n], out line[n]) == false)
                            return false;
                    }
                    matr[i] = line;
                }
                return true;
            }
            catch(Exception)
            {
                Console.WriteLine("Упс, что-то пошло не так");
                matr = new double[0][];
                return false;
            }
        }
    }
}