using System;
using System.Linq;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            const int x = 5;
            Console.WriteLine("Please type the number :");
            int y = Convert.ToInt32(Console.ReadLine());
            var result = y % x == 0 ? "Yes" : "No";
            Console.WriteLine(result);
            #endregion

            #region Task2
            Console.WriteLine("Please type the First number :");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type the Second number :");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum > secondNum && secondNum != 0)
            {
                Console.WriteLine(firstNum + secondNum);
                Console.WriteLine(firstNum-secondNum);
                Console.WriteLine(firstNum * secondNum);
                Console.WriteLine((double)firstNum/secondNum);
            }
            else if (firstNum == 0 || secondNum == 0) 
            {
                
                Console.WriteLine(firstNum + secondNum);
                Console.WriteLine(firstNum - secondNum);
                Console.WriteLine(firstNum * secondNum);
                Console.WriteLine("Not Allowed to Devide by Zero");
            }
            else if(firstNum < secondNum && firstNum != 0) 
            {
                Console.WriteLine(firstNum + secondNum);
                Console.WriteLine(secondNum - firstNum);
                Console.WriteLine(firstNum * secondNum);
                Console.WriteLine((double)secondNum / firstNum);
            }

            #endregion

            #region Task3
            int a = 5;
            int b = 12;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            #endregion

            #region Task4
            Console.WriteLine("Please enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (int index in Enumerable.Range(1, 9))
            { 
                int answer = number*index;
                Console.WriteLine($"{number} * {index} = {answer}");
            }

            #endregion

            #region Task5
            const int n = 15;

            foreach (int index in Enumerable.Range(1, n))
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine(index*index);
                }
            }

            #endregion
        }
    }
}
