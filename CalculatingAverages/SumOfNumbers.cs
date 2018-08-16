using System;

namespace CalculatingAverages
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            var sum = 0;
            bool goodInput = true;
            string input;
            Console.WriteLine("This application will add ten numbers between 0 and 100. Please enter whole numbers only");
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        do
                        {
                            Console.WriteLine("Please enter the first number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 1:
                        do
                        {
                            
                            Console.WriteLine("Please enter the second number: ");
                            goodInput = getInput(i, numbers);
                            
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Please enter the third number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Please enter the fourth number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Please enter the fifth number: ");
                            goodInput = getInput(i, numbers);

                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine("Please enter the sixth number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("Please enter the seventh number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 7:
                        do
                        {
                            Console.WriteLine("Please enter the eigth number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 8:
                        do
                        {
                            Console.WriteLine("Please enter the ninth number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                    case 9:
                        do
                        {
                            Console.WriteLine("Please enter the tenth number: ");
                            goodInput = getInput(i, numbers);
                        } while (goodInput == false || numbers[i] < 0 || numbers[i] > 100);

                        break;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                sum += numbers[i];
            }
            Console.Write("The sum of: ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write($"{numbers[i]} =");
                }
                else
                {
                    Console.Write($"{numbers[i]} + ");
                }
            }
            Console.Write($" is {sum}");
            Console.Read();
        }

        public static bool getInput(int i, int []numbers)
        {
            bool goodInput;
            try
            {
                goodInput = true;
                string input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("I'm sorry but you did not enter a valid whole number. Please try again.");
                goodInput = false;
            }
            return goodInput;
        }
    }
}
