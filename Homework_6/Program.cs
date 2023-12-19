using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            int number;
            Console.WriteLine("Please enter the number :");
            var randomNum = Console.ReadLine();
            bool isValidInteger = int.TryParse(randomNum, out number);
            int[] mainArray = new int[number];
            int[] onlyEvenValue;
            int[] onlyOddValue;
            if (isValidInteger && number != 0)
            {


                for (int i = 1; i <= number; i++)
                {
                    mainArray[i - 1] = i;
                }

                Console.WriteLine("[{0}]", string.Join(", ", mainArray));
            }
            else
            {
                Console.WriteLine("Please enter the real number :");
            }
            #region Find Even and Odd Numbers

            // Count the number of even and odd numbers in the array
            int evenCount = 0;
            int oddCount = 0;
            foreach (int num in mainArray)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                    //Console.WriteLine(evenCount);
                }
                else
                {
                    oddCount++;
                }
            }
            // To make an empty array with corresponding amount of even and odd numbers
            onlyEvenValue = new int[evenCount];
            onlyOddValue = new int[oddCount];

            // To add even and odd numbers at the index place in onlyEvenValue array
            int evenIndex = 0;
            int oddIndex = 0;
            foreach (int num in mainArray)
            {
                if (num % 2 == 0)
                {
                    onlyEvenValue[evenIndex] = num;
                    evenIndex++;
                }
                else
                {
                    onlyOddValue[oddIndex] = num;
                    oddIndex++;
                }
            }
            #endregion
            Console.WriteLine("Even numbers: [{0}]", string.Join(", ", onlyEvenValue));
            Console.WriteLine("Odd numbers: [{0}]", string.Join(", ", onlyOddValue));

            #endregion

            #region Task 2

            Console.WriteLine("Please enter the number:");
            var randomInput1 = Convert.ToInt32(Console.ReadLine());
            int[] arrayWithRanNums = new int[randomInput1];

            // Use Random class to generate random numbers and add them to arrayWithRanNums
            Random random = new Random();
            for (int i = 0; i < randomInput1; i++)
            {
                arrayWithRanNums[i] = random.Next(1, randomInput1); // Generates a random number between 1 and our input
            }

            Console.WriteLine("[{0}]", string.Join(", ", arrayWithRanNums));

            // Find and display the count of duplicate numbers
            Dictionary<int, Tuple<int, int>> numberInfo = new Dictionary<int, Tuple<int, int>>();

            foreach (int num in arrayWithRanNums)
            {
                if (numberInfo.ContainsKey(num))
                {
                    var info = numberInfo[num];
                    numberInfo[num] = Tuple.Create(info.Item1 + 1, info.Item2 + num);
                    //Console.WriteLine(info);
                }
                else
                {
                    numberInfo[num] = Tuple.Create(1, num);
                }
            }
            //Console.WriteLine("[{0}]", string.Join(", ", numberInfo));
            Console.WriteLine("Duplicate numbers,their counts and their sum:");
            Console.WriteLine("Number\tCount\tSum");
            foreach (var n in numberInfo)
            {
                Console.WriteLine($"{n.Key}\t{n.Value.Item1}\t{n.Value.Item2}");
            }

            #endregion

            #region Task 3
            Console.WriteLine("Please enter the number:");
            var randomInput2 = Convert.ToInt32(Console.ReadLine());
            int[] arrayWithRanNums2 = new int[randomInput2];

            // Use Random class to generate random numbers and add them to arrayWithRanNums
            Random randomNum2 = new Random();
            for (int i = 0; i < randomInput2; i++)
            {
                arrayWithRanNums2[i] = randomNum2.Next(1, 30);
            }
            Array.Sort(arrayWithRanNums2);
            Console.WriteLine("[{0}]", string.Join(", ", arrayWithRanNums2));

            int[] randArray;
            Console.Write("Please choose how many highest score would you like to see: ");
            var inputNum = Convert.ToInt32(Console.ReadLine());

            randArray = new int[inputNum];
            var indexNum = 0;
            for (int i = 0; i < inputNum; i++)
            {
                randArray[indexNum] = arrayWithRanNums2[arrayWithRanNums2.Length - i - 1];
                indexNum++;
            }

            Array.Sort(randArray);
            Console.WriteLine("[{0}]", string.Join(", ", randArray));

            #endregion
        }
    }
}
