using System;

namespace Homework5
{
    class Homework5
    {
        static void Main(string[] args)
        {
            /*Нарисуйте треугольник
             * в консоли
             */

            Console.WriteLine("Введите высоту треугольника");

            int enterparam = int.Parse(Console.ReadLine());

            for (int firstvalue = 1; firstvalue <= enterparam; firstvalue++)
            {
                for (int secondvalue = 1; secondvalue <=firstvalue; secondvalue++)
                {
                    Console.Write("#");                                     
                }
                Console.WriteLine();
            }            
        }
    }
}
