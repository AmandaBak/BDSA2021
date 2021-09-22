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
            if (year % 400 == 0) return true; 
            else if (year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            else return false;
        }
    }
}
