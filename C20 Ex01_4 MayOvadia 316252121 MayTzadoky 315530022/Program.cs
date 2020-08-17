namespace C20_Ex01_4_MayOvadia_316252121_MayTzadoky_315530022
{
    public class Program
    {
        public static void Main()
        {
            StringAnalyzer();
        }

        public static void StringAnalyzer()
        {
            bool isNumber = false;
            string stringToAnalyze = GetUserValidInputString(ref isNumber);

            IsPalindrome(stringToAnalyze);
            if (isNumber)
            {
                IsDivideByThree(stringToAnalyze);
            }
            else
            {
                LowerCaseNumberInString(stringToAnalyze);
            }
        }

        public static string GetUserValidInputString(ref bool io_isNumber)
        {
            bool isJustNumOrJustStr;
            bool isInDefinedLength;
            string inputString;
            long stringBecomeNum;

            do
            {
                System.Console.WriteLine("Please enter string 12 chars long:");
                inputString = System.Console.ReadLine();
                io_isNumber = long.TryParse(inputString, out stringBecomeNum);
                isInDefinedLength = inputString.Length == 12;
                isJustNumOrJustStr = io_isNumber || IsOnlyLettersInString(inputString);
            }
            while (!isJustNumOrJustStr || !isInDefinedLength);

            return inputString;
        }

        public static bool IsOnlyLettersInString(string i_inputString)
        {
            bool isOnlyLettersInString = true;

            for (int i = 0; i < i_inputString.Length; ++i)
            {
                bool isDigit = char.IsDigit(i_inputString[i]);
                if (isDigit)
                {
                    isOnlyLettersInString = false;
                    break;
                }
            }

            return isOnlyLettersInString;
        }

        public static void IsPalindrome(string i_stringToAnalyze)
        {
            bool isPalindrome = true;
            string palindromeResult;

            IsPalindromeRec(i_stringToAnalyze, 0, i_stringToAnalyze.Length - 1, ref isPalindrome);
            if (isPalindrome)
            {
                palindromeResult = string.Format("The string: {0} is palindrome", i_stringToAnalyze);
            }
            else
            {
                palindromeResult = string.Format("The string: {0} is not palindrome", i_stringToAnalyze);
            }

            System.Console.WriteLine(palindromeResult);
        }

        public static void IsPalindromeRec(string i_stringToAnalyze, int i_startOfString, int i_endOfString, ref bool io_isValidPalindrome)
        {
            bool isSingleCharOrEmpty = i_startOfString >= i_endOfString;

            if (!isSingleCharOrEmpty && io_isValidPalindrome)
            {
                io_isValidPalindrome = i_stringToAnalyze[i_startOfString] == i_stringToAnalyze[i_endOfString];
                if (!isSingleCharOrEmpty)
                {
                    IsPalindromeRec(i_stringToAnalyze, i_startOfString + 1, i_endOfString - 1, ref io_isValidPalindrome);
                }
            }
        }

        public static void IsDivideByThree(string i_stringToAnalyze)
        {
            int sumOfNumberDigit = 0;

            for (int i = 0; i < i_stringToAnalyze.Length; ++i)
            {
                sumOfNumberDigit += i_stringToAnalyze[i] - '0';
            }

            bool isDivideByThree = sumOfNumberDigit % 3 == 0;
            string divideByThreeResult;

            if(isDivideByThree)
            {
                divideByThreeResult = string.Format("The number: {0} is divide by 3", i_stringToAnalyze);
            }
            else
            {
                divideByThreeResult = string.Format("The number: {0} is not divide by 3", i_stringToAnalyze);
            }

            System.Console.WriteLine(divideByThreeResult);
        }

        public static void LowerCaseNumberInString(string i_stringToAnalyze)
        {
            int numberOfLowerCase = 0;

            for (int i = 0; i < i_stringToAnalyze.Length; ++i)
            {
                if (char.IsLower(i_stringToAnalyze[i]))
                {
                    numberOfLowerCase++;
                }
            }

            System.Console.WriteLine(string.Format("The number of lower letters in the string: {0} is: {1}", i_stringToAnalyze, numberOfLowerCase));
        }
    }
}
