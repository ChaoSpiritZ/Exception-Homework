using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Homework_2nd_try
{
    class UserInput
    {
        public UserInput()
        {

        }

        public void GetNumber()
        {
            try
            {
                Console.WriteLine("input a number: ");

                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("you chose number: " + num);
            }
            catch(FormatException)
            {
                throw new MyWrongFormat();
            }
        }

        public void GetNumbers()
        {
            try
            {
                int[] array = new int[4];
                Console.WriteLine("input 5 numbers: ");
                array[0] = int.Parse(Console.ReadLine());
                array[1] = int.Parse(Console.ReadLine());
                array[2] = int.Parse(Console.ReadLine());
                array[3] = int.Parse(Console.ReadLine());
                array[4] = int.Parse(Console.ReadLine());
            }
            catch(IndexOutOfRangeException)
            {
                throw new MyOutOfBounds();
            }
        }

        public void DivideByZero()
        {
            try
            {
                Console.WriteLine("input a number: ");
                int num = int.Parse(Console.ReadLine());
                int y = 0;
                num = num / y;
            }
            catch(DivideByZeroException)
            {
                throw new MyDivideByZero();
            }
        }
    }
}
