using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfScores
{
    class AverageOfScores
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            var sum = 0;
            bool goodInput = true;
            string input;
            string letterGrade;
            Console.WriteLine("This application will add ten numbers between 0 and 100 and determine the average number entered. Please enter whole numbers only");
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the first number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 1:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the second number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);
                        break;
                    case 2:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the third number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 3:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the fourth number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 4:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the fifth number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 5:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the sixth number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 6:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the seventh number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 7:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the eigth number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 8:
                        do
                        {
                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the ninth number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 9:
                        do
                        {

                            try
                            {
                                goodInput = true;
                                Console.WriteLine("Please enter the tenth number: ");
                                input = Console.ReadLine();
                                numbers[i] = int.Parse(input);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                                goodInput = false;
                            }
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                sum += numbers[i];
                
            }
            var average = sum / 10;
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
            Console.Write("The average of: ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write($"{numbers[i]} /10 = ");
                }
                else
                    Console.Write($"{numbers[i]} + ");
            }
            Console.Write($" is {average} and the average letter grade is {letterGrade}");
            Console.Read();
        }
    }
}
