using System;

namespace Homework6
{
    class Homework6
    {
        static void Main(string[] args)

        {
            /*
             * тернарный оператор
             */
            bool accesAllowed;
            string inputdata = Console.ReadLine();
            string enterPassowrd = "qwer";

            accesAllowed = enterPassowrd == inputdata ? true : false;

            Console.WriteLine(accesAllowed);

            /*
             * тернарный оператор
             */

            //создаем массив (переменную)
            int[] myArray;

            //выделяем место, границу массива в 5 (начинается с 0)
            myArray = new int[5];

            //по индексу 1 присваеваем число 3 
            myArray[1] = 3;

            //выводим массив под индексом 1
            Console.WriteLine(myArray[1]);




        }
    }
}
