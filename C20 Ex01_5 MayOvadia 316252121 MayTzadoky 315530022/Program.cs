using System;

namespace C20_Ex01_5_MayOvadia_316252121_MayTzadoky_315530022
{
    class Program
    {
        public static void Main()
        {
            StringAnalyzer();
        }

        public static void StringAnalyzer()
        {
            bool isNumber = false;
            string stringToAnalyze = GetUserValidInputString(ref isNumber);
            IsPalindrom(stringToAnalyze);
            if(isNumber)
            {
                IsDivideByThree(stringToAnalyze);
            }
            else
            {
                LowerCaseNumberInString(stringToAnalyze);
            }

        }

        // TODO: validation check
        public static string GetUserValidInputString(ref bool isNumber)
        {
            bool isJustNumOrJustStr;
            bool isInDefinedLength;
            string inputString;
            long stringBecomeNum;
            do
            {
                System.Console.WriteLine("Please enter string:");
                inputString = System.Console.ReadLine();
                isNumber = Int64.TryParse(inputString, out stringBecomeNum);
                isInDefinedLength = (inputString.Length == 12);
                isJustNumOrJustStr = (isNumber || IsOnlyLettersInString(inputString));

            } while (!isJustNumOrJustStr || !isInDefinedLength);

            return inputString;
        }

        public static bool IsOnlyLettersInString(string i_inputString)
        {
            bool isdigit;
            for (int i = 0; i < i_inputString.Length; ++i)
            {
                isdigit = char.IsDigit(i_inputString[i]);
                if (isdigit)
                {
                    return false;
                }
            }
            return true;
        }

        public static void IsPalindrom(string i_stringToAnalyze)
        {
            bool isPalindrom = IsPalindromRec(i_stringToAnalyze, 0, i_stringToAnalyze.Length - 1);
            string palindromResualt;
            if (isPalindrom)
            {
                palindromResualt = string.Format("The string: {0} is palindrom", i_stringToAnalyze);
            }
            else
            {
                palindromResualt = string.Format("The string: {0} is not palindrom", i_stringToAnalyze);
            }

            System.Console.WriteLine(palindromResualt);
        }

        public static bool IsPalindromRec(string i_stringToAnalyze, int i_startOfString, int i_endOfString)
        {
            bool isSingleCharOrEmpty = (i_startOfString >= i_endOfString);

            if (isSingleCharOrEmpty)
            {
                return true;
            }

            bool isFirstAndLastLetterEqual = (i_stringToAnalyze[i_startOfString] == i_stringToAnalyze[i_endOfString]);

            if (!isFirstAndLastLetterEqual)
            {
                return false;
            }

            if(!isSingleCharOrEmpty)
            {
                return IsPalindromRec(i_stringToAnalyze, i_startOfString + 1, i_endOfString - 1);
            }

            return true;
        }

        public static void IsDivideByThree(string i_stringToAnalyze)
        {
            int sumOfNumberDigit = 0;
            for (int i = 0; i < i_stringToAnalyze.Length; ++i)
            {
                sumOfNumberDigit += (i_stringToAnalyze[i] - '0');
            }
            bool isDividByThree = (sumOfNumberDigit % 3 == 0);

            string divideByThreeResualt;
            if (isDividByThree)
            {
                divideByThreeResualt = string.Format("The number: {0} is divide by 3", i_stringToAnalyze);
            }
            else
            {
                divideByThreeResualt = string.Format("The number: {0} is not divide by 3", i_stringToAnalyze);
            }
            System.Console.WriteLine(divideByThreeResualt);
        }

        public static void LowerCaseNumberInString(string i_stringToAnalyze)
        {
            int numberOfLowerCase = 0;
            for(int i = 0; i < i_stringToAnalyze.Length; ++i)
            {
                if(char.IsLower(i_stringToAnalyze[i]))
                {
                    numberOfLowerCase++;
                }
            }

            System.Console.WriteLine(string.Format("The number of lower letters in the string: {0} is: {1}", i_stringToAnalyze, numberOfLowerCase));
        }
    }
}
