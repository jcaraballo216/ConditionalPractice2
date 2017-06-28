using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Age distribution practice
            //Console.WriteLine("Please type your age!");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("Still in Mamma's Arm");
            //}
            //else if (age >= 3 && age <= 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if (age >= 5 && age <= 11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if (age >= 12 && age <= 14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (age >= 15 && age <= 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else if (age >= 19 && age <= 22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (age >= 23 && age <= 65)
            //{
            //    Console.WriteLine("Working for the Man");
            //}
            //else if (age >= 65 && age <= 100)
            //{
            //    Console.WriteLine("The Golden Years");
            //}
            ////fix this
            //else 
            //{
            //    Console.WriteLine("This Program is for humans");
        //}

        //Word to digits

        Console.WriteLine("Please type the number in lower case word form");
            string numberWord = Console.ReadLine();
            switch (numberWord)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "5":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;






            }
        }
        

    }
}
