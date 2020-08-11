namespace C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022
{
    class Program
    {
        public static void Main()
        {
            PrintHourglassRec(0);
        }

        public static void PrintHourglassRec(int i_numOfSpaces)
        {
            bool isSingleStar = i_numOfSpaces >= 2;

            if (isSingleStar)
            {
                PrintStarsLine(i_numOfSpaces);
                return;
            }

            PrintStarsLine(i_numOfSpaces);
            PrintHourglassRec(i_numOfSpaces + 1);
            PrintStarsLine(i_numOfSpaces);
        }

        public static void PrintStarsLine(int i_numOfSpaces)
        {
            int numOfStars = 5 - i_numOfSpaces * 2;

            PrintSpaces(i_numOfSpaces);

            for (int i = 0; i < numOfStars; ++i)
            {
                System.Console.Write("*");
            }
            PrintSpaces(i_numOfSpaces);
            System.Console.Write("\n");
        }

        public static void PrintSpaces(int i_numOfSpaces)
        {
            for (int i = 0; i < i_numOfSpaces; ++i)
            {
                System.Console.Write(" ");
            }
        }
    }
}
