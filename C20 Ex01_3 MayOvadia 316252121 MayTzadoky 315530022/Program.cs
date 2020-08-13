namespace C20_Ex01_3_MayOvadia_316252121_MayTzadoky_315530022
{
    using C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022;

    class Program
    {
        public static void Main()
        {
            //TODO validity check
            System.Console.WriteLine("Please enter the number of lines for the Hour glass: ");

           string lengthOfHourGlass = System.Console.ReadLine();
           int numLengthOfHourGlass =  int.Parse(lengthOfHourGlass);
           C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022.Program.PrintHourglassRec(numLengthOfHourGlass);
        }
    }
}
