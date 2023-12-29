using System;
using System.Linq;


namespace Homework_9
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int[] WeeklyHours { get; set; }

        public Employee(string firstName, string lastName, int age, string position, string weeklyHours)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
            WeeklyHours = Array.ConvertAll(weeklyHours.Split(' '), int.Parse);
        }

        public double CalculateWeeklySalary()
        {
            double hourlyRate = 0;
            // To assign the Employee a Position
            switch (Position.ToLower())
            {
                case "manager":
                    hourlyRate = 40;
                    break;
                case "developer":
                    hourlyRate = 30;
                    break;
                case "tester":
                    hourlyRate = 20;
                    break;
                default:
                    hourlyRate = 10;
                    break;
            }
            // To Calculate the Salary
            double weeklySalary = 0;
            const int bonusSalary = 5;
            double weekEndSalary = hourlyRate * 2;
            double weeklyBonus = 0.2;
            int totalWeeklyHours = WeeklyHours.Sum();
            //Console.WriteLine(totalWeeklyHours);

            for (int i = 0; i < WeeklyHours.Length; i++)
            {
                //Console.WriteLine(WeeklyHours[i]);
                if (WeeklyHours[5] > 0 && i == 5)
                {
                    weeklySalary += weekEndSalary * WeeklyHours[5];
                }
                else if (WeeklyHours[6] > 0 && i == 6)
                {

                    weeklySalary += weekEndSalary * WeeklyHours[6];
                }
                else
                {
                    if (WeeklyHours[i] <= 8)
                    {
                        weeklySalary += WeeklyHours[i] * hourlyRate;
                    }
                    else
                    {
                        weeklySalary += ((WeeklyHours[i] - 8) * bonusSalary) + (hourlyRate * 8);
                    }
                }
            }
            /*To Calculate Weekly Bonus*/
            if (totalWeeklyHours > 50)
            {
                weeklySalary += weeklySalary * weeklyBonus;
            }
            return weeklySalary;
        }

    }
}
