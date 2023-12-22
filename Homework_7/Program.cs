using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            /*1.მოცემულია კვადრატი და კვადრატში ჩახატული წრე.ამ წრეში
            ჩახატულია კიდევ ერთი სხვა კვადრატი.
            დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის
            ფართობებს შორის.
            Input : 5(რადიუსი)
            Output: 50
            */

            //Console.WriteLine("Please enter the radous of the Circle");
            //double radiusCircle = Convert.ToDouble(Console.ReadLine());
            //double sLengthOuterSquare;
            //double sLengthInnerSquare;
            //double areaOuterSquare;
            //double areaInnerSquare;

            //sLengthOuterSquare = 2 * radiusCircle;
            //sLengthInnerSquare = Math.Sqrt(2) * radiusCircle;
            //areaOuterSquare = Math.Pow(sLengthOuterSquare, 2);
            //areaInnerSquare = Math.Pow(sLengthInnerSquare, 2);
            //var areaDiff = Math.Round(areaOuterSquare - areaInnerSquare);
            //Console.WriteLine(areaDiff);

            #endregion

            #region Task2
            /*დაწერეთ პროგრამა რომელიც შეამოწმებს ამოუვიდა თუ არა იუზერს
            ჯეკპოტი.
            */
            //Console.WriteLine("please enter the amount of items in array");
            //int arrayRange = Convert.ToInt32(Console.ReadLine());
            //string[] userInputsArray = new string[arrayRange];
            //for (int i = 0; i < arrayRange; i++)
            //{
            //    Console.WriteLine($"Please type the symbol/number/letter - {i + 1}");
            //    string userInputs = Console.ReadLine();
            //    userInputsArray[i] = userInputs;
            //}

            //bool hasJackpotInArray = CheckForJackpot(userInputsArray);

            //Console.WriteLine($"User has the jackpot in the array: {hasJackpotInArray}");

            //// check,if all other elements are the same as the first element.
            //bool CheckForJackpot(string[] userInput)
            //{
            //    return userInput.All(x => x == userInput[0]);
            //}
            #endregion

            #region Task3
            //int won, draw, lost ;
            //Console.WriteLine("Amount of games won");
            //won = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amount of games that were draw ");
            //draw = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amount of games lost ");
            //lost = Convert.ToInt32(Console.ReadLine());
            //int finalScore = won * 3 + draw * 1 + 0 * lost;
            //Console.WriteLine(finalScore);

            #endregion

            #region Task4
            /*
            დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1
            კვირის განმავლობაში.
            გაითვალისწინეთ:
            a. დღეში თანამშრომელი მუშაობს 8 საათს და საათში იღებს 10 $
            b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
            c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს
            */
            //int amountOfSalary = 0;
            //int numberOfHoursWorked;
            //string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for (int i = 0; i <weekDays.Length; i++)
            //{
            //    Console.WriteLine($"Number of hours worked on { weekDays[i]}");
            //    numberOfHoursWorked = Convert.ToInt32(Console.ReadLine());
            //    if (weekDays[i] == "Saturday" || weekDays[i] == "Sunday") 
            //    {
            //        amountOfSalary += 20 * numberOfHoursWorked;
            //    }
            //    else
            //    {   
            //        if (numberOfHoursWorked > 8 ) 
            //        {
            //            amountOfSalary += 10 * 8 + ((numberOfHoursWorked - 8) * 5);
            //        }
            //        else
            //        {
            //            amountOfSalary += 10 * numberOfHoursWorked;
            //        }

            //    }


            //}
            //Console.WriteLine($"The sum of the Salary is {amountOfSalary}");


            #endregion

            #region Task5
            /*გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს
            .შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ იმ
            დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.
            */

            //int resultOfBetterExercise = 0;
            //Console.WriteLine("Please enter the number of days an athlete has spent on workout");
            //int arrayRange1 = Convert.ToInt32(Console.ReadLine());
            //int[] exerciseArray = new int[arrayRange1];
            //Random random = new Random();

            //for (int i = 0; i < exerciseArray.Length; i++)
            //{
            //    exerciseArray[i] = random.Next(1, 7);
            //    Console.WriteLine(exerciseArray[i]);
            //}

            //Array.Sort(exerciseArray);
            //Console.WriteLine("[{0}]", string.Join(", ", exerciseArray));

            //for (int i = 1; i < exerciseArray.Length; i++)
            //{
            //    if (exerciseArray[i - 1] < exerciseArray[i])
            //    {
            //        resultOfBetterExercise += 1;
            //    }
            //}
            //Console.WriteLine($"Number of days with better exercises: {resultOfBetterExercise}");

            #endregion

            #region Task6
            Console.WriteLine("Please enter the minimum number of letters should a word contain");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = { "Hello", "World", "Programming", "communication" };

            string[] filteredWords = inputArray.Where(w => w.Length >= userInput).ToArray();
            string words = string.Join(", ", filteredWords);
            Console.WriteLine(words);
            #endregion
        }    
    }
}
