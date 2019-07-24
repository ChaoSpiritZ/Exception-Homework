using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Homework_2nd_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. input a number");
            Console.WriteLine("2. input an array of numbers");
            Console.WriteLine("3. divide a number by zero");
            int x = int.Parse(Console.ReadLine());
            
            if(x == 1)
            {
                try
                {
                    UserInput UInput = new UserInput();
                    UInput.GetNumber();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (x == 2)
            {
                try
                {
                    UserInput UInput = new UserInput();
                    UInput.GetNumbers();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (x == 3)
            {
                try
                {
                    UserInput UInput = new UserInput();
                    UInput.DivideByZero();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
