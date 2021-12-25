using System;

// Напишите программу, проверяющую число, введенное с клавиатуры на четность
 
namespace Homework2
{

    class Homework2
    {
        static void Main(string[] args)
        {

            /*
             * Вариант №1
             */

            Console.WriteLine("Введите число, для проверки на четность");

            int numbers = int.Parse(Console.ReadLine());

            int result = numbers / 2;
            
            if (result * 2 == numbers)
            {
                Console.WriteLine("Четное");
            }

            else
            {
                Console.WriteLine("Число не четное");
            }
            Console.ReadLine();

            /*
             * Вариант №2 
             */

            Console.WriteLine("Введите число, для проверки на четность");

            int num = int.Parse(Console.ReadLine());
                        

            if (num % 2 == 0)
            {
                Console.WriteLine("Четное");
            }

            else
            {
                Console.WriteLine("Число не четное");
            }
            Console.ReadLine();


        }

    }
}
