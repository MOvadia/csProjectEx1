namespace C20_Ex01_3_MayOvadia_316252121_MayTzadoky_315530022
{
    using C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022;

    public class Program
    {
        public static void Main()
        {
            PrintHourGlass();
        }

        public static void PrintHourGlass()
        {
            int lengthOfHourGlass = GetUserInputValid();
            
            if (lengthOfHourGlass % 2 == 0)
            {
                lengthOfHourGlass += 1;
            }

            PrintHourGlassRec(0, lengthOfHourGlass);
        }

        public static int GetUserInputValid()
        {
            bool isInt = false;
            bool isPositiveNum = false;
            string lengthOfHourGlassStr;
            int lengthOfHourGlassInt;
            do
            {
                System.Console.WriteLine("Please enter the number of lines for the Hour glass: ");
                lengthOfHourGlassStr = System.Console.ReadLine();
                isInt = int.TryParse(lengthOfHourGlassStr, out lengthOfHourGlassInt);
                if (isInt)
                {
                    isPositiveNum = lengthOfHourGlassInt >= 0;
                }
            }
            while (!isInt || !isPositiveNum);

            return lengthOfHourGlassInt;
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

            C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022.Program.PrintSpaces(i_numOfSpaces);

            for (int i = 0; i < numOfStars; ++i)
            {
                System.Console.Write("*");
            }

            System.Console.Write("\n");
        }
    }
}