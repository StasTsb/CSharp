using System;

// Напишите программу, проверяющую число, введенное с клавиатуры на четность
 
namespace Homework2
{

    class Homework2
    {
        static void Main(string[] args)
        {
            
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
        }
    }
}
