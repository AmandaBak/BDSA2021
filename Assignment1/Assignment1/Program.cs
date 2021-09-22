using System;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter leap year");
            int input = Int32.Parse(Console.ReadLine());
            if(IsLeapYear(input) == true) Console.WriteLine("yay");
            else Console.WriteLine("nay");

        }

        public static bool IsLeapYear(int year) {
            if (year < 1582) {
                Console.WriteLine("Only years from 1582 and onwards");
                return false;
            }
            if (year % 400 == 0) return true; 
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }
    }
}
