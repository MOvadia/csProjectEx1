namespace C20_Ex01_2_MayOvadia_316252121_MayTzadoky_315530022
{
    public class Program
    {
        public static void Main()
        {
            PrintHourGlass(0, 5);
        }

        public static void PrintHourGlass(int i_numOfSpaces, int i_lengthOfHourGlass)
        {
            System.Text.StringBuilder hourGlassBuild = new System.Text.StringBuilder();
            PrintHourGlassRec(i_numOfSpaces, i_lengthOfHourGlass, ref hourGlassBuild);
            System.Console.WriteLine(hourGlassBuild.ToString());
        }

        public static void PrintHourGlassRec(int i_numOfSpaces, int i_lengthOfHourGlass, ref System.Text.StringBuilder io_hourGlassBuild)
        {
            bool isSingleStar = i_lengthOfHourGlass == 1;

            if (isSingleStar)
            {
                PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass, ref io_hourGlassBuild);
                return;
            }

            PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass, ref io_hourGlassBuild);
            PrintHourGlassRec(i_numOfSpaces + 1, i_lengthOfHourGlass - 2, ref io_hourGlassBuild);
            PrintStarsLine(i_numOfSpaces, i_lengthOfHourGlass, ref io_hourGlassBuild);
        }

        public static void PrintStarsLine(int i_numOfSpaces, int i_lengthOfHourGlass, ref System.Text.StringBuilder io_hourGlassBuild)
        {
            PrintSpaces(i_numOfSpaces, ref io_hourGlassBuild);

            for (int i = 0; i < i_lengthOfHourGlass; ++i)
            {
                io_hourGlassBuild.Append("*");
            }

            io_hourGlassBuild.AppendLine();
        }

        public static void PrintSpaces(int i_numOfSpaces, ref System.Text.StringBuilder io_hourGlassBuild)
        {
            for (int i = 0; i < i_numOfSpaces; ++i)
            {
                io_hourGlassBuild.Append(" ");
            }
        }
    }
}
