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

            C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022.Program.PrintHourGlassRec(0, lengthOfHourGlass);
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
    }
}