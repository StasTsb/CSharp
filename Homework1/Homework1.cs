using System;

/*
 * 1.Напишите программу, вычисляющую среднее арифметическое двух чисел.
 * 2.Введите три числа и выведите на экран значение суммы и произведения этих чисел.
 * 3.Напишите простой конвертер валют (без возможности динаического выбора валют пользователем).
 * Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
 * 
 */
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Задание №1
             */

            int result1;
            int result2;
            
            Console.WriteLine("Введите перове число");
            result1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Введите второе число");
            result2 = Convert.ToInt32( Console.ReadLine());

            int finalresult= ((result1 + result2)/2);

            Console.WriteLine("Итого: " + finalresult);
            Console.ReadLine();

            /*
             * Задание №2
             */

            Console.WriteLine("HW№2");
            Console.WriteLine("Введите число");

            Console.ReadLine();
        }
    }
}
