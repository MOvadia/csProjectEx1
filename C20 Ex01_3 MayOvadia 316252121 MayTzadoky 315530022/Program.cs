namespace C20_Ex01_3_MayOvadia_316252121_MayTzadoky_315530022
{
    using C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022;

    class Program
    {
        public static void Main()
        {
            PrintHourGlass();
        }

        public static void PrintHourGlass()
        {
            //TODO validity check
            System.Console.WriteLine("Please enter the number of lines for the Hour glass: ");

            int lengthOfHourGlass = int.Parse(System.Console.ReadLine());
            if(lengthOfHourGlass % 2 == 0)
            {
                lengthOfHourGlass += 1;
            }
            PrintHourGlassRec(0,lengthOfHourGlass);
        }

        public static void PrintHourGlassRec(int i_numOfSpaces, int i_lengthOfHourGlass)
        {
            //if (i_lengthOfHourGlass == 5)
            //{
            //    C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022.Program.PrintHourglassRec(i_numOfSpaces);
            //    return;
            //}

            bool isSingleStar = i_lengthOfHourGlass == 1;

            if (isSingleStar)
            {
                PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass);
                return;
            }

            PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass);
            PrintHourGlassRec(i_numOfSpaces + 1, i_lengthOfHourGlass-2);
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