﻿using System;

namespace Homework6
{
    class Homework6
    {
        static void Main(string[] args)

        {

            /*
             * ДЗ
             * 1.Заполнить массив с клавиатуры
             * 2.Вывести массив в обратном порядке
             * 3.Найти сумму четных чисел 
             * 4.Найти наименьшее числов массиве
             */

            Console.WriteLine("Дз1");

            Console.Write("Введите количество элементов массива: ");

            int elemets = int.Parse(Console.ReadLine());
            int[] myArray0 = new int[elemets];
                        
            for (int i = 0; i < myArray0.Length; i++)
            {
                Console.Write($"\nВведите значение элемента массива под индексом {i}: \t");
                myArray0[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < myArray0.Length; i++)
            {
                Console.WriteLine(myArray0[i]);
            }
            Console.ReadLine();
            

            Console.WriteLine("Дз2");

            Console.Write("Введите количество элементов массива: \t");

            int elements2 = int.Parse(Console.ReadLine());            
            int[] myArray100 = new int [elements2];

            for (int i = 0; i < myArray100.Length; i++) 
            {
                Console.Write($"\nВведите значение элемента массива под индексом {i}: \t");
                myArray100[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива в обратном порядке:");

            for (int i = myArray100.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArray100[i]);
            }

            Console.WriteLine("ДЗ 3");

            Console.Write("Введите количество элементов массива: \t");

            int elements3 = int.Parse(Console.ReadLine());
            int[] myArray101 = new int[elements3];
            int result =0;
            
            
            for (int i = 0; i < myArray101.Length; i++)
            {
                Console.Write($"\nВведите значение элемента массива под индексом {i}: \t");
                myArray101[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод:");

            for (int i = 0; i < myArray101.Length; i++)
            {
                if (myArray101[i] % 2 == 0)
                {
                    result += myArray101[i];
                }                
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
}
}
