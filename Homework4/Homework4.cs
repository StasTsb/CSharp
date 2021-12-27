using System;

namespace Homework4
{
    class Homework4
    {
        static void Main(string[] args)
        {
            /*Напишите программу которая подсчитает количество четных
             * и нечетных целых чисел, в диапазоне который ввел пользователь*/

            Console.WriteLine("Введите число");
            
            int limit = int.Parse(Console.ReadLine());

            int count = 0;
            int even = 0;
            int odd = 0;

            while (count< limit) 
            {
                count++;
                if (count % 2 == 0) 
                {
                    even++;         
                
                }
                if (count %2 != 0)
                {
                    odd++;
                }                    
                        
            }
            Console.WriteLine("Количество нечетных чисел = " + even);
            Console.WriteLine("Количество четных чисел = " + odd);
        }
    }
}
