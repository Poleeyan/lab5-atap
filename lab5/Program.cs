using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace lab5
{
    internal class Program
    {
        static void Main()
        {
            int rows = 8;
            int cols = 8;
            int minValue = 0;
            int maxValue = 100;
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];

            // Генерація матриці
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue + 1);
                }
            }

            // Виведення матриці
            Console.WriteLine("Згенерована матриця:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            // Пошук локальних мінімумів
            int count = 0;
            Console.WriteLine("\nЛокальні мінімуми:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool isLocalMinimum = true;

                    for (int di = -1; di <= 1; di++)
                    {
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            if (di == 0 && dj == 0) continue; // Пропустити сам елемент

                            int ni = i + di; // Рядок сусіда
                            int nj = j + dj; // Стовпець сусіда

                            if (ni >= 0 && ni < rows && nj >= 0 && nj < cols) // Перевірка меж
                            {
                                if (matrix[ni, nj] <= matrix[i, j])
                                {
                                    isLocalMinimum = false;
                                    break;
                                }
                            }
                        }
                        if (!isLocalMinimum) break;
                    }

                    if (isLocalMinimum)
                    {
                        count++;
                        Console.WriteLine($"Значення: {matrix[i, j]} Рядок: {i}, Стовпець: {j}");
                    }
                }
            }

            Console.WriteLine($"\nКількість локальних мінімумів: {count}");
        }
    }
}
*/
namespace lab5_task2
{
    internal class Program
    {
        static void Main()
        {
            // 1. Генерація одновимірного масиву з випадковими числами
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 16); // Випадкові числа в діапазоні [0, 15]
            }

            // 2. Виведення початкового масиву
            Console.WriteLine("Початковий масив:");
            Console.WriteLine(string.Join(", ", array));

            // 3. Знаходимо перший мінімальний та максимальний елементи
            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            // 4. Визначення початку та кінця підмасиву для сортування
            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex) - 1;

            // 5. Сортування елементів між першим мінімумом і максимумом методом бульбашки
            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end - (i - start); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // 6. Виведення перетвореного масиву
            Console.WriteLine("Перетворений масив:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}