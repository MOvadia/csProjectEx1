﻿namespace C20_Ex01_5_MayOvadia_316252121_MayTzadoky_315530022
{
    public class Program
    {
        public static void Main()
        {
            NumberStatistics();
        }

        public static void NumberStatistics()
        {
            string numberFromTheUser = GetUserInputValid();
            int maximumDigit = MaximumDigit(numberFromTheUser);
            int minimumDigit = MinimumDigit(numberFromTheUser);
            int counterDigitsAreDividedByFour = HowManyDigitsAreDividedByFour(numberFromTheUser);
            int counterDigitsWhichLargeThanOnenessDigit = HowManyDigitsWhichLargeThanOnenessDigit(numberFromTheUser);

            System.Text.StringBuilder statisticsOutput = new System.Text.StringBuilder();
            statisticsOutput.AppendLine("The maximum digit of the number is: " + maximumDigit);
            statisticsOutput.AppendLine("The minimum digit of the number is: " + minimumDigit);
            statisticsOutput.AppendLine(counterDigitsAreDividedByFour + " digits divided by 4.");
            statisticsOutput.AppendLine(counterDigitsWhichLargeThanOnenessDigit + " digits large than oneness digit.");
            System.Console.WriteLine(statisticsOutput.ToString());
        }

        public static string GetUserInputValid()
        {
            bool isInt = false;
            bool isPositiveNum = false;
            int howManyDigits;
            int numberFromTheUserInt;
            string numberFromTheUserStr;

            do
            {
                System.Console.WriteLine("Please insert a number with 8 digits: ");
                numberFromTheUserStr = System.Console.ReadLine();
                howManyDigits = numberFromTheUserStr.Length;
                isInt = int.TryParse(numberFromTheUserStr, out numberFromTheUserInt);
                if (isInt)
                {
                    isPositiveNum = numberFromTheUserInt > 0;
                }
            }
            while (!isInt || !isPositiveNum || howManyDigits != 8);

            return numberFromTheUserStr;
        }

        public static int MaximumDigit(string i_number)
        {
            int maxDigit = i_number[0] - '0';

            for (int i = 1; i < 8; i++)
            {
                if (maxDigit < (i_number[i] - '0'))
                {
                    maxDigit = i_number[i] - '0';
                }
            }

            return maxDigit;
        }

        public static int MinimumDigit(string i_number)
        {
            int minDigit = i_number[0] - '0';

            for (int i = 1; i < 8; i++)
            {
                if (minDigit > (i_number[i] - '0'))
                {
                    minDigit = i_number[i] - '0';
                }
            }

            return minDigit;
        }

        public static int HowManyDigitsAreDividedByFour(string i_number)
        {
            int counterDigitsAreDividedByFour = 0;

            for (int i = 0; i < 8; i++)
            {
                if ((i_number[i] - '0') % 4 == 0)
                {
                    counterDigitsAreDividedByFour++;
                }
            }

            return counterDigitsAreDividedByFour;
        }

        public static int HowManyDigitsWhichLargeThanOnenessDigit(string i_number)
        {
            int onenessDigit = i_number[0];
            int counterDigitsWhichLargeThanOnenessDigit = 0;

            for (int i = 1; i < 8; i++)
            {
                if (i_number[i] > onenessDigit)
                {
                    counterDigitsWhichLargeThanOnenessDigit++;
                }
            }

            return counterDigitsWhichLargeThanOnenessDigit;
        }
    }
}
