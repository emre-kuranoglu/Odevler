using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 2021;
            int number2 = 1992;
            var result = Age(number1, number2);
            
            Console.WriteLine("Yaşınız: "+ result);

            int number3 = 2030;
            int number4 = 1992;
            var result2 = Age2(ref number3, number4);

            Console.WriteLine("Yaşınız: " + result2);

            int number5;
            int number6 = 1992;
            var result3 = Age3(out number5,number6);

            Console.WriteLine("Yaşınız: " + result3);

        }

        static int Age(int number1, int number2)
        {
            return number1 - number2;
        }   

        static int Age2(ref int number3, int number4)
        {
            number3 = 2021;
            return number3 - number4;
        }

        static int Age3(out int number5, int number6)
        {
            number5 = 2021;
            return number5 - number6;
        }
    }
}

