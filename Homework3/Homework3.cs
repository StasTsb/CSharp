using System;

namespace Homework3
{
    class Homework3
    {
        static void Main(string[] args)
        {

            /*
            1. Напишите калькулятор с использованием 
            конструктора switch
            2. Напишите калькулятор с использованием 
            конструктора if/else
            */

            Console.WriteLine("Введите число");
            double firstnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Арифмитическое действие");
            string action = (Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double secondnumber = double.Parse(Console.ReadLine());

            switch (action)
            {
                case "+":
                    double resultplus = firstnumber + secondnumber;
                    Console.WriteLine(resultplus);
                    break;
                case "-":
                    double resultminus = firstnumber - secondnumber;
                    Console.WriteLine(resultminus);
                    break;
                case "*":
                    double multiplication = firstnumber * secondnumber;
                    Console.WriteLine(multiplication);
                    break;
                case "/":
                    double division = firstnumber / secondnumber;
                    Console.WriteLine(division);
                    break;
                case "%":
                    double remains = firstnumber % secondnumber;
                    Console.WriteLine(remains);
                    break;

                default:
                    Console.WriteLine("Действие не поддерживается");
                    break;                                

            }

            /*
             *  IF/ELSE            
            */
            Console.ReadLine();

            Console.WriteLine("Введите число");
            double Fnum = double.Parse(Console.ReadLine());

            Console.WriteLine("Арифмитическое действие");
            string act = (Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double Snum = double.Parse(Console.ReadLine());

            if (act == "+") 
            {
                double pl = Fnum + Snum;
                Console.WriteLine("Равно: "+ pl);            
            };
            if (act == "-")
            {
                double pl = Fnum - Snum;
                Console.WriteLine("Равно: " + pl);
            };
            if (act == "*")
            {
                double pl = Fnum * Snum;
                Console.WriteLine("Равно: " + pl);
            };
            if (act == "/")
            {
                double pl = Fnum / Snum;
                Console.WriteLine("Равно: " + pl);
            };
            if (act == "%")
            {
                double pl = Fnum % Snum;
                Console.WriteLine("Равно: " + pl);
            }
            




        }
    }
}
