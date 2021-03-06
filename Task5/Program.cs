﻿using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input("Введите n: ");
            int[,] matr = FillMatr(n);

            int[] answer = Solve(matr);    

            foreach (var value in answer)
            {
                Console.Write($"{value} ");
            }

        }
        //Функция для нахождения минимальных чисел в матрице до главной диагонали
        static int[] Solve(int[,] matr)
        {
            int n = matr.GetLength(0);
            int[] answer = new int[n];

            for (int i = 0; i < n; i++)
            {
                int minI = matr[i, 0];
                for (int j = 0; j < i + 1; j++)
                {
                    minI = Math.Min(minI, matr[i, j]);
                }
                answer[i] = minI;
            }

            return answer;
        }
        //Функция проверки ввода
        static int Input(string msg)
        {
            Console.Write(msg);
            int x;
            bool ok = int.TryParse(Console.ReadLine(), out x);
            if (!ok)
            {
                Console.WriteLine("Введите число!");
                return Input(msg);
            }
            return x;
        }
        //Функция заполнения матрицы
        static int[,] FillMatr(int n)
        {
            int[,] matr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num = Input($"Введите {i}, {j} элемент матрицы: ");
                    matr[i, j] = num;
                }
            }

            return matr;
        }
    }
}
