using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfNonSpecificNumberOfScores
{
    class AverageOfNonSpecificNumberOfScores
    {
        static void Main(string[] args)
        {
            string input;
            string letterGrade;
            bool end=false;
            int numberInput;
            bool badInput=false;
            List<int> numbers = new List<int>();
            Console.WriteLine("This program allows you to enter as many test scores as you want. When you want to stop entering test scores, please" +
                "enter \"q\".");
            do
            {
                try
                {
                    badInput = false;
                    Console.WriteLine("Please enter a test score: ");
                    input = getInput();
                    if (input.ToLower() == ("q"))
                    {
                        end = true;
                        break;
                    }
                    numberInput = int.Parse(input);
                    if(numberInput<0 || numberInput>100)
                    {
                        badInput = true;
                    }
                    else
                    {
                        numbers.Add(int.Parse(input));
                        end = false;
                        badInput = false;
                    }
                } catch (FormatException e)
                {
                    Console.WriteLine("You did not enter a valid test score or \"q\".");
                    end = false;
                }
            } while (!end || badInput == true);

            var sum = getSum(numbers);
            var average = sum / numbers.Count;
            if (average >= 94)
            {
                letterGrade = "A";
            }
            else if (average < 94 && average >= 90)
            {
                letterGrade = "A-";
            }
            else if (average < 90 && average >= 86)
            {
                letterGrade = "B+";
            }
            else if (average < 85 && average >= 83)
            {
                letterGrade = "B";
            }
            else if (average < 83 && average >= 80)
            {
                letterGrade = "B-";
            }
            else if (average < 80 && average >= 76)
            {
                letterGrade = "C+";
            }
            else if (average < 76 && average >= 73)
            {
                letterGrade = "C";
            }
            else if (average < 73 && average >= 70)
            {
                letterGrade = "C-";
            }
            else if (average < 70 && average >= 66)
            {
                letterGrade = "D+";
            }
            else if (average < 66 && average >= 63)
            {
                letterGrade = "D";
            }
            else if (average < 63 && average >= 60)
            {
                letterGrade = "D-";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine($"The average of the scores entered is {average} and the average letter grade is {letterGrade}");
        }
        public static string getInput()
        {

                string input = Console.ReadLine();
                return input;
        }
        public static int getSum(List<int> numbers)
        {
            int sum = 0;
            for(int i=0;i<numbers.Count;i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
