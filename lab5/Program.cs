﻿using System;
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
            for (int i = 0; i < rows; i++) // Генерація матриці
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue + 1);
                }
            }
            Console.WriteLine("Згенерована матриця:"); // Виведення матриці
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
            int count = 0;
            Console.WriteLine("\nЛокальнi мiнiмуми:"); // Пошук локальних мінімумів
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
            Console.WriteLine($"\nКiлькiсть локальних мiнiмумiв: {count}");
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
            // Виконуємо всі операції в одному методі
            int[] arr = new int[20];
            Random rand = new Random();

            // Заповнюємо масив випадковими значеннями в діапазоні 0...15
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 16);
            }

            Console.WriteLine("Початковий масив:");
            PrintArray(arr);

            // Знаходимо індекси мінімального та максимального елементів
            int minIndex = Array.IndexOf(arr, arr.Min());
            int maxIndex = Array.IndexOf(arr, arr.Max());

            // Сортуємо всі елементи в порядку зростання
            Array.Sort(arr);

            Console.WriteLine("Вiдсортований масив:");
            PrintArray(arr);

            // Локальна функція для друку масиву
            void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}