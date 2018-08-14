using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfSpecificNumberOfScores
{
    class AverageOfSpecificNumberOfScores
    {
        static void Main(string[] args)
        {
            string input;
            string letterGrade;
            bool goodInput = true;
            int numberOfScores=0;
            int sum = 0;

            do
            {
                try
                {
                    goodInput = true;
                    Console.WriteLine("Please enter how many scores you will be entering: ");
                    input = Console.ReadLine();
                    numberOfScores = int.Parse(input);
                }catch(FormatException e)
                {
                    Console.WriteLine("You did not enter a valid number. Please try again.");
                    goodInput = false;
                }
            } while (goodInput == false || numberOfScores<=0);
            int[] numbers = new int[numberOfScores];
            for(int i=0;i<numberOfScores;i++)
            {
                do
                {
                    try
                    {
                        goodInput = true;
                        Console.WriteLine($"Please enter test score number {i + 1}: ");
                        input = Console.ReadLine();
                        numbers[i] = int.Parse(input);

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("I'm sorry you did not enter a valid test score please try again.");
                        goodInput = false;
                    }
                } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);
                
            }
            for (int i=0;i<numberOfScores;i++)
            {
                sum += numbers[i];
            }

            var average = sum / numberOfScores;
            if (average >= 94)
                letterGrade = "A";
            else if (average < 94 && average >= 90)
                letterGrade = "A-";
            else if (average < 90 && average >= 86)
                letterGrade = "B+";
            else if (average < 85 && average >= 83)
                letterGrade = "B";
            else if (average < 83 && average >= 80)
                letterGrade = "B-";
            else if (average < 80 && average >= 76)
                letterGrade = "C+";
            else if (average < 76 && average >= 73)
                letterGrade = "C";
            else if (average < 73 && average >= 70)
                letterGrade = "C-";
            else if (average < 70 && average >= 66)
                letterGrade = "D+";
            else if (average < 66 && average >= 63)
                letterGrade = "D";
            else if (average < 63 && average >= 60)
                letterGrade = "D-";
            else
                letterGrade = "F";

            Console.WriteLine($"The average score was {average} and the average letter grade is {letterGrade}");
            Console.Read();
        }


    }
}
