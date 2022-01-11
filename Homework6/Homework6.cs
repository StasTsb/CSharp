using System;

namespace Homework6
{
    class Homework6
    {
        static void Main(string[] args)

        {
            /*
               //обьявляем массив (переменную)
               int[] myArray;
               //int[] myArray = new int[5]

               //выделяем место, границу массива в 5 (начинается с 0)
               myArray = new int[5];

               //по индексу 1 присваеваем число 3 
               myArray[1] = 3;

               //выводим массив под индексом 1
               Console.WriteLine(myArray[1]);

               //Инициализация массива
               int[] myArray1 = new int[5] { 5, 6, 7, 8, 9 };
               //Можно не создавать элементы, тогда можно задавать их количество совбодно
               int[] myArray2 = new int[] { 5, 6, 7, 8 };
               //Можно не указывать синтаксис
               int[] myArray3 = new [] { 5, 6, 7, 8 };

               int[] myArray4 = { 10, 3, 2, 55 };

               for (int i = 0; i < myArray.Length; i++)
               {
                   Console.WriteLine(myArray[i]);
               }
               Console.ReadLine();


               /*
                * ДЗ
                * 1.Заполнить массив с клавиатуры
                * 2.Вывести массив в обратном порядке
                * 3.Найти сумму четных чисел 
                * 4.Найти наименьшее числов массиве
                */

            
            Console.Write("Введите количество элементов массива: ");

            int elemets = int.Parse(Console.ReadLine());
            int[] myArray0 = new int[elemets];
                        
            for (int i = 0; i < myArray0.Length; i++)
            {
                Console.WriteLine("Введите значение элемента с индексом: ");
                myArray0[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < myArray0.Length; i++)
            {
                Console.WriteLine(myArray0[i]);
            }
            Console.ReadLine();



        }
    }
}
