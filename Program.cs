//Задача 54:
/*Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 54. Введите количество строк");
        int linesVol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int columnsVol = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = new int[linesVol, columnsVol];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine();
        Console.WriteLine("Массив до изменения");
        PrintArray(numbers);

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1) - 1; j++)
            {
                for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                {
                    if (numbers[i, z] < numbers[i, z + 1])
                    {
                        int temp = 0;
                        temp = numbers[i, z];
                        numbers[i, z] = numbers[i, z + 1];
                        numbers[i, z + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Массив с упорядоченными значениями");
        PrintArray(numbers);

        void FillArrayRandomNumbers(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("]");
                Console.WriteLine("");
            }
        }

        //Задача 56: 
        /*Задайте прямоугольный двумерный массив. Напишите программу,
        которая будет находить строку с наименьшей суммой элементов.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        5 2 6 7
        Программа считает сумму элементов в каждой строке и выдаёт номер строки
        с наименьшей суммой элементов: 1 строка
        */

        Console.WriteLine("Задача 56. Введите размер массива m x n и диапазон случайных значений:");
        int m = InputNumbers("Введите m: ");
        int n = InputNumbers("Введите n: ");
        int range = InputNumbers("Введите диапазон: от 1 до ");

        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);

        int minSumLine = 0;
        int sumLine = SumLineElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        }

        Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


        int SumLineElements(int[,] array, int i)
        {
            int sumLine = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i, j];
            }
            return sumLine;
        }

        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(range);
                }
            }
        }

        void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        //Задача 62. 
        /*Напишите программу, которая заполнит спирально массив 4 на 4.
        Например, на выходе получается вот такой массив:
        01 02 03 04
        12 13 14 05
        11 16 15 06
        10 09 08 07
        */

        Console.WriteLine("Задача 62. Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());

        int[,] nums = new int[size, size];

        int num = 1;
        int i = 0;
        int j = 0;

        while (num <= size * size)
        {
            nums[i, j] = num;
            if (i <= j + 1 && i + j < size - 1)
                ++j;
            else if (i < j && i + j >= size - 1)
                ++i;
            else if (i >= j && i + j > size - 1)
                --j;
            else
                --i;
            ++num;
        }

        PrintArray(nums);
    }
        void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}

