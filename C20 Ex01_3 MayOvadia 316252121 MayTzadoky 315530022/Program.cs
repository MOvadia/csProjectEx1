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
            PrintHourGlassRec(lengthOfHourGlass);
        }

        public static void PrintHourGlassRec(int i_numOfSpaces)
        {
            if(i_numOfSpaces == 0)
            {
                C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022.Program.PrintHourglassRec(i_numOfSpaces);
            }
        }



    }
}
