using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number in box 1 : ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Input number in box 2 : ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Input number in box 3 : ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Box1 = {0} Box2 = {1} Box3 = {2}", A, B, C);
            int i;

            for (i = 0; A != 0 || B != 0 || C != 0; i++)
            {
                Console.Write("Choose a box : ");
                int numberbox = int.Parse(Console.ReadLine());
                numberbox = Math.Abs(numberbox);
                Console.Write("Enter the number you want to take out : ");
                int boxout = int.Parse(Console.ReadLine());
                boxout = Math.Abs(boxout);
                if (numberbox == 1)
                {
                    A = A - boxout;
                }
                else if (numberbox == 2)
                {
                    B = B - boxout;
                }
                else if (numberbox == 3)
                {
                    C = C - boxout;
                }
                Console.WriteLine("Box1 = {0} Box2 = {1} Box3 = {2}", A, B, C);
            }
            if (A == 0 && B == 0 && C == 0)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Player B is a winner");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Player A is a winner");
                }
            }
            Console.ReadLine();
        }
    }
}
