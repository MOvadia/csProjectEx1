namespace C20_Ex01_1_MayOvadia_316252121_MayTzadoky_315530022
{
    public class Program
    {
        public static void Main()
        {
            BinarySeries();
        }

        public static void BinarySeries()
        {
            System.Console.WriteLine("Please enter 4 binaries numbers: ");
            string binaryNumber1 = GetAndValidateUserInput();
            string binaryNumber2 = GetAndValidateUserInput();
            string binaryNumber3 = GetAndValidateUserInput();
            string binaryNumber4 = GetAndValidateUserInput();
            int decimalNumber1 = BinaryToDecimal(binaryNumber1);
            int decimalNumber2 = BinaryToDecimal(binaryNumber2);
            int decimalNumber3 = BinaryToDecimal(binaryNumber3);
            int decimalNumber4 = BinaryToDecimal(binaryNumber4);

            string printDecimalNumber = string.Format("The decimal numbers are: {0}, {1}, {2}, {3}", decimalNumber1, decimalNumber2, decimalNumber3, decimalNumber4);

            System.Console.WriteLine(printDecimalNumber);
            StatisticsOfBinaryNumbers(binaryNumber1, binaryNumber2, binaryNumber3, binaryNumber4);
            StatisticsOfDecimalNumbers(decimalNumber1, decimalNumber2, decimalNumber3, decimalNumber4);
        }

        public static string GetAndValidateUserInput()
        {
            string binaryNumber;

            do
            {
                binaryNumber = System.Console.ReadLine();
            }
            while (!IsValidUserInput(binaryNumber));

            return binaryNumber;
        }

        public static bool IsValidUserInput(string i_binaryNumber)
        {
            bool isBinary;
            bool isValidUserInput = true;

            if (i_binaryNumber.Length != 8)
            {
                System.Console.WriteLine("Input is invalid!");
                isValidUserInput = false;
            }
            else
            {
                for (int i = 0; i < 8; ++i)
                {
                    isBinary = i_binaryNumber[i] == '0' || i_binaryNumber[i] == '1';
                    if (!isBinary)
                    {
                        System.Console.WriteLine("Invalid input!");
                        isValidUserInput = false;
                    }
                }
            }

            return isValidUserInput;
        }

        public static int CounterZero(string i_binaryNumber)
        {
            int counterZero = 0;

            for (int i = 0; i < 8; ++i)
            {
                if (i_binaryNumber[i] == '0')
                {
                    counterZero++;
                }
            }

            return counterZero;
        }

        public static float AverageOfZero(string i_binaryNumber1, string i_binaryNumber2, string i_binaryNumber3, string i_binaryNumber4)
        {
            float averageOfZero = (float)(CounterZero(i_binaryNumber1) + CounterZero(i_binaryNumber2) + CounterZero(i_binaryNumber3) + CounterZero(i_binaryNumber4)) / 4;

            return averageOfZero;
        }

        public static int CounterOne(string i_binaryNumber)
        {
            int counterOne = 0;

            for (int i = 0; i < 8; ++i)
            {
                if (i_binaryNumber[i] == '1')
                {
                    counterOne++;
                }
            }

            return counterOne;
        }

        public static float AverageOfOne(string i_binaryNumber1, string i_binaryNumber2, string i_binaryNumber3, string i_binaryNumber4)
        {
            float averageOfOne = (float)(CounterOne(i_binaryNumber1) + CounterOne(i_binaryNumber2) + CounterOne(i_binaryNumber3) + CounterOne(i_binaryNumber4)) / 4;

            return averageOfOne;
        }

        public static int BinaryToDecimal(string i_binaryNumber)
        {
            int decimalNumber = 0, powerOfTwo = 1;

            for (int i = 7; i >= 0; i--)
            {
                int digitOfBinaryNumber = int.Parse(i_binaryNumber[i].ToString());
                decimalNumber = decimalNumber + (digitOfBinaryNumber * powerOfTwo);
                powerOfTwo = powerOfTwo * 2;
            }

            return decimalNumber;
        }

        public static int IsPowerOfTwo(int i_decimalNumber)
        {
            double logOfDecimalNum = System.Math.Log(i_decimalNumber, 2);
            bool isPowerOfTwo = logOfDecimalNum % 1 == 0;
            int counterOfPowOfTwo = 0;

            if (isPowerOfTwo)
            {
                counterOfPowOfTwo = 1;
            }

            return counterOfPowOfTwo;
        }

        public static int IsAscendingSeries(int i_decimalNumber)
        {
            int rightDigit = i_decimalNumber % 10;
            bool isAscendingSeries = true;

            i_decimalNumber = i_decimalNumber / 10;

            while (i_decimalNumber > 0 && isAscendingSeries)
            {
                int newRightDigit = i_decimalNumber % 10;
                i_decimalNumber = i_decimalNumber / 10;

                isAscendingSeries = rightDigit <= newRightDigit;
            }

            int counterIsAscendingSeries = 0;

            if (isAscendingSeries)
            {
                counterIsAscendingSeries = 1;
            }

            return counterIsAscendingSeries;
        }

        public static void StatisticsOfBinaryNumbers(string i_binaryNumber1, string i_binaryNumber2, string i_binaryNumber3, string i_binaryNumber4)
        {
            float averageOfZero = AverageOfZero(i_binaryNumber1, i_binaryNumber2, i_binaryNumber3, i_binaryNumber4);
            float averageOfOne = AverageOfOne(i_binaryNumber1, i_binaryNumber2, i_binaryNumber3, i_binaryNumber4);
            System.Text.StringBuilder averageOfZeroAndOneOutput = new System.Text.StringBuilder();

            averageOfZeroAndOneOutput.AppendLine("The average of the digit '0' in the binary numbers is: " + averageOfZero);
            averageOfZeroAndOneOutput.AppendLine("The average of the digit '1' in the binary numbers is: " + averageOfOne);
            System.Console.WriteLine(averageOfZeroAndOneOutput.ToString());
        }

        public static void StatisticsOfDecimalNumbers(int i_decimalNumber1, int i_decimalNumber2, int i_decimalNumber3, int i_decimalNumber4)
        {
            int howMuchPowerOfTwo = HowMuchPowerOfTwo(i_decimalNumber1, i_decimalNumber2, i_decimalNumber3, i_decimalNumber4);
            float averagedNumbers = (float)(i_decimalNumber1 + i_decimalNumber2 + i_decimalNumber3 + i_decimalNumber4) / 4;
            int howMuchAscendingSeries = IsAscendingSeries(i_decimalNumber1) + IsAscendingSeries(i_decimalNumber2) + IsAscendingSeries(i_decimalNumber3) + IsAscendingSeries(i_decimalNumber4);

            PrintStatistics(howMuchPowerOfTwo, howMuchAscendingSeries, averagedNumbers);
        }

        public static int HowMuchPowerOfTwo(int i_decimalNumber1, int i_decimalNumber2, int i_decimalNumber3, int i_decimalNumber4)
        {
            int howMuchPowerOfTwo = IsPowerOfTwo(i_decimalNumber1) + IsPowerOfTwo(i_decimalNumber2) + IsPowerOfTwo(i_decimalNumber3) + IsPowerOfTwo(i_decimalNumber4);

            return howMuchPowerOfTwo;
        }

        public static void PrintStatistics(int i_howMuchPowerOfTwo, int i_howMuchAscendingSeries, float i_averagedNumbers)
        {
            System.Text.StringBuilder statisticsOutput = new System.Text.StringBuilder();
            statisticsOutput.AppendLine(i_howMuchPowerOfTwo + " of the numbers are a power of 2.");
            statisticsOutput.AppendLine("There are " + i_howMuchAscendingSeries + " numbers which are an ascending series.");
            statisticsOutput.AppendLine("The average of the decimal numbers is " + i_averagedNumbers);
            System.Console.WriteLine(statisticsOutput.ToString());
        }
    }
}