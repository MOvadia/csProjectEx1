namespace C20_Ex01_5_MayOvadia_316252121_MayTzadoky_315530022
{
    class Program
    {
        public static void Main()
        {
            NumberStatistics();
        }

        public static void NumberStatistics()
        {
            System.Console.WriteLine("Please insert a number with 8 digits: ");
            string numberFromTheUser = System.Console.ReadLine();
            int maximumDigit = MaximumDigit(numberFromTheUser);
            int minimumDigit = MinimumDigit(numberFromTheUser);
            int counterDigitsAreDividedByFour = HowManyDigitsAreDividedByFour(numberFromTheUser);
            int counterDigitsWhichLargeThanOnenessDigit = HowManyDigitsWhichLargeThanOnenessDigit(numberFromTheUser);

            string printStatistics = string.Format("The maximum digit of the number is: {0}.\nThe minimum digit of the number is: {1}.\n{2} digits divided by 4.\n{3} digits large than oneness digit.\n", maximumDigit, minimumDigit, counterDigitsAreDividedByFour, counterDigitsWhichLargeThanOnenessDigit);
            System.Console.WriteLine(printStatistics);
        }

        public static int MaximumDigit(string i_Number)
        {
            char[] digitsStr = i_Number.ToCharArray();
            int maxDigit = digitsStr[0] - '0';

            for(int i = 1; i < 8; i++)
            {
                if( maxDigit < (digitsStr[i] - '0'))
                {
                    maxDigit = digitsStr[i] - '0';
                }
            }

            return maxDigit;
        }

        public static int MinimumDigit(string i_Number)
        {
            char[] digitsStr = i_Number.ToCharArray();
            int minDigit = digitsStr[0] - '0';

            for (int i = 1; i < 8; i++)
            {
                if (minDigit > (digitsStr[i] - '0'))
                {
                    minDigit = digitsStr[i] - '0';
                }
            }

            return minDigit;
        }

        public static int HowManyDigitsAreDividedByFour(string i_Number)
        {
            char[] digitsStr = i_Number.ToCharArray();
            int counterDigitsAreDividedByFour = 0;

            for(int i = 0; i < 8; i++)
            {
                if((digitsStr[i] - '0') % 4 == 0)
                {
                    counterDigitsAreDividedByFour++;
                }
            }

            return counterDigitsAreDividedByFour;
        }

        public static int HowManyDigitsWhichLargeThanOnenessDigit(string i_Number)
        {
            char[] digitsStr = i_Number.ToCharArray();
            int onenessDigit = digitsStr[0];
            int counterDigitsWhichLargeThanOnenessDigit = 0;

            for (int i = 1; i < 8; i++)
            {
                if (digitsStr[i] > onenessDigit)
                {
                    counterDigitsWhichLargeThanOnenessDigit++;
                }
            }

            return counterDigitsWhichLargeThanOnenessDigit;
        }
    }
}
