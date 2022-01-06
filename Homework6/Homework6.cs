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


        }
    }
}
