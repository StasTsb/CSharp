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

            Console.WriteLine("Среднее арифметическое");
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
            int sum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите еще");
            int sum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ну и еще");
            int sum3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Значение суммы введенных чисел равняется " + (sum1+sum2+sum3));
            Console.WriteLine("Произведение: " + (sum1 * sum2 * sum3));
            
            /*
             * Задание №3
             */


            Console.WriteLine("HW№3");

            double BUNtoUSD = 2.6;
            double BUNtoJPY = 0.022;

            string USDchoose = "USD";
            string JPYchoose = "JPY";

            Console.WriteLine("Хотите конвертировать BUN в USD или JPY ? (впешите USD или JPY)");
            string choose = Console.ReadLine();

            if (choose == USDchoose | choose == JPYchoose)
            {              
                if (choose == USDchoose)
                {
                    Console.WriteLine("Введите сумму в BUN");
                    double USDresult = double.Parse(Console.ReadLine());

                    Console.WriteLine("USD= " + ((double)USDresult * BUNtoUSD));
                }
                if (choose == JPYchoose)
                {
                    Console.WriteLine("Введите сумму в BUN");
                    double JPYresult = double.Parse(Console.ReadLine());

                    Console.WriteLine("JPY= " + ((double)JPYresult * BUNtoJPY));
                }
            }
            else
            {
                Console.WriteLine("Ошибка при вводе валюты, введите USD или JPY");
            }
           



        }
    }
}
