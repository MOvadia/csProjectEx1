namespace C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022
{
    public class Program
    {
        public static void Main()
        {
            PrintHourGlassRec(0, 5);
        }

        public static void PrintHourGlassRec(int i_numOfSpaces, int i_lengthOfHourGlass)
        {
            bool isSingleStar = i_lengthOfHourGlass == 1;

            if (isSingleStar)
            {
                PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass);
                return;
            }

            PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass);
            PrintHourGlassRec(i_numOfSpaces + 1, i_lengthOfHourGlass - 2);
            PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass);
        }

        public static void PrintStarsLine(int i_numOfSpaces, int i_lengthOfHourGlass)
        {
            int numOfStars = i_lengthOfHourGlass;

            PrintSpaces(i_numOfSpaces);

            for (int i = 0; i < numOfStars; ++i)
            {
                System.Console.Write("*");
            }

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
