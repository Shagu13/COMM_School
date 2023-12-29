using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს   a, b, n 
            a. a - მინიმალური რიცხვი
            b. b - მაქსიმალური რიცხვი
            c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
            იპოვეთ ყველა რიცხვი a - &gt; b შუალედში რომლის n ხარისხი
            მოთავსებულია ამ ინტერვალში*/

            //Console.WriteLine("Please enter the 'a' number :");
            //int firstInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the 'b' number :");
            //int secondInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the 'n' number :");
            //int powerInput = Convert.ToInt32(Console.ReadLine());

            //List<int> resultList = Calculate(a: firstInput, b: secondInput, n: powerInput);

            //Console.Write($"Number of items : {resultList.Count}\n");
            //Console.WriteLine("[{0}]", string.Join(", ", resultList));

            #endregion

            #region Task2
            /*დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
            აღნიშნულია ორი ერთნაირი სიმბოლოთი.*/

            //Console.WriteLine("Please enter the text");
            //string userInput = Console.ReadLine().ToUpper();

            //List<string> finalList = helpNick(userInput);
            //Console.Write($"Number of items : {finalList.Count}\n");
            //Console.WriteLine("[{0}]", string.Join(" ", finalList));

            //helpNick2(userInput);

            #endregion

            #region Task3
            /*დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
            ბოლოსართს ორ სტრინგს შორის .*/

            //Console.WriteLine("Please enter the text-1 to compare:");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Please enter the text-2 to compare:");
            //string str2 = Console.ReadLine();

            //string commonSuffix = FindCommonSuffix(str1, str2);
            //Console.WriteLine("Common Suffix: " + commonSuffix);

            #endregion

            #region Task4
            /*დაწერეთ ფუნქცია რომელიც მიიღებს Generic ტიპის ლისტს , შეამოწმებს
            გადაცემული ლისტის ტიპს და შემოწმების შემდეგ ჩაატარებს შემდეგ
            ოპერაციებს .
            თუ გადაეცემა სტრინგების ლისტი - დაბეჭდავს ყველა სტრინგს UpperCase-ში
            თუ გადაეცემა ნებისმიერი რიცხვითი ტიპის მასივი ( int) - დაითვლის მათ ჯამს
            თუ გადაეცემა Bool - გამოიტანს ლისტის პირველ, ბოლო და შუაში მყოფ
            ელემენტს .*/

            //Console.WriteLine("Enter a list of integers separated by spaces:");
            //var input = Console.ReadLine();
            //checkTheInput(input);

            #endregion

            #region Task5
            /*რეკურსია
            დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს .*/

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            Console.Write("Separated digits: ");
            SeparateDigits(input, 0);

            #endregion

            #region Task6
            /*დაწერეთ პროგრამა რომელიც შეამოწმებს შეიცავს თუ არა მასივი
            დუბლიკატებს*/

            //Console.WriteLine("Please enter random numbers: ");
            //var userInputs = Console.ReadLine();

            //Console.WriteLine(checkDuplicates(userInputs));

            #endregion
        }


        static List<int> Calculate(int a, int b, int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i <= b; i++)
            {
                if (Math.Pow(i, n) >= a && Math.Pow(i, n) <= b)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        static List<string> helpNick(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            Console.WriteLine(sortedString);
            List<string> list = new List<string>();
            string pairsFound = "";
            for (int i = 0; i < sortedString.Length - 1; i++)
            {
                if (sortedString[i] == sortedString[i + 1])
                {
                    pairsFound += $"{sortedString[i]}{sortedString[i + 1]}";
                    list.Add(pairsFound);
                    pairsFound = "";
                    i += 1;

                }
            }
            return list;
        }
        static void helpNick2(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            Console.WriteLine(sortedString);
            int numberOfPairs = 0;
            for (int i = 0; i < sortedString.Length; i++)
            {
                //Check if the current character has already been counted
                if (i == 0 || sortedString[i] != sortedString[i - 1])
                {
                    int count = userInput.Count(letter => letter == sortedString[i]);
                    Console.WriteLine($"Character '{sortedString[i]}' occurs {count} times.");
                    numberOfPairs += count / 2;
                }
            }
            Console.WriteLine(numberOfPairs);
        }

        static void checkTheInput(string input)
        {            
            string[] numStrings = input.Split(' ');
            List<int> numList = new List<int>();

            foreach (string numString in numStrings)
            {
                if (int.TryParse(numString, out int parsedNum))
                {
                    numList.Add(parsedNum);
                }
                else if (numString == "true" || numString == "false")
                {
                    Console.WriteLine($"The first element is - {numStrings[0]}\nThe last element is - " +
                        $"{numStrings[numStrings.Length - 1]}\nThe middle element is -" +
                        $"{numStrings[numStrings.Length / 2]}");
                    return;
                }
                else
                {
                    Console.WriteLine(numString.ToUpper());
                }
            }
            int addedValue = numList.Where(n => n >= 0).Sum();
            Console.WriteLine(addedValue);
        }

        static string FindCommonSuffix(string string1, string string2)
        {
            int length1 = string1.Length;
            int length2 = string2.Length;
            int minLength = Math.Min(length1, length2);
            Console.WriteLine(minLength);

            // Find the index where the strings differ
            int index = 0;
            while (index < minLength && string1[length1 - 1 - index] == string2[length2 - 1 - index])
            {
                index++;
            }

            // Extract the common suffix
            string commonSuffix = string1.Substring(length1 - index);

            return commonSuffix;
        }

        static void SeparateDigits(string number, int index)
        {
            // Base case: if we reached the end of the string
            if (index == number.Length - 1)
            {
                Console.Write(number[index]);
            }
            else
            {
                Console.Write(number[index] + " - ");
                // Recursively call the function for the next digit
                SeparateDigits(number, index + 1);
            }
        }

        static bool checkDuplicates(string input)
        {
        string[] array = input.Split(" ").ToArray();
        Array.Sort(array);
        for (int i = 0; i < array.Length-1; i++)
        {
            if (string.Equals(array[i], array[i + 1]))
            {
                return true;
            }
        }
            
        return false;
        }
    }
}
