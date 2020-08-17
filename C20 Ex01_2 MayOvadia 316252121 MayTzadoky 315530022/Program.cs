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
            AppendToStringHourGlassRec(i_numOfSpaces, i_lengthOfHourGlass, ref hourGlassBuild);
            System.Console.WriteLine(hourGlassBuild.ToString());
        }

        public static void AppendToStringHourGlassRec(int i_numOfSpaces, int i_lengthOfHourGlass, ref System.Text.StringBuilder io_hourGlassBuild)
        {
            bool isSingleStar = i_lengthOfHourGlass == 1;

            if (isSingleStar)
            {
                AppendStarsLine(i_numOfSpaces, i_lengthOfHourGlass, ref io_hourGlassBuild);
            }
            else
            {
                AppendStarsLine(i_numOfSpaces, i_lengthOfHourGlass, ref io_hourGlassBuild);
                AppendToStringHourGlassRec(i_numOfSpaces + 1, i_lengthOfHourGlass - 2, ref io_hourGlassBuild);
                AppendStarsLine(i_numOfSpaces, i_lengthOfHourGlass, ref io_hourGlassBuild);
            }
        }

        public static void AppendStarsLine(int i_numOfSpaces, int i_lengthOfHourGlass, ref System.Text.StringBuilder io_hourGlassBuild)
        {
            AppendSpaces(i_numOfSpaces, ref io_hourGlassBuild);
            for (int i = 0; i < i_lengthOfHourGlass; ++i)
            {
                io_hourGlassBuild.Append("*");
            }

            io_hourGlassBuild.AppendLine();
        }

        public static void AppendSpaces(int i_numOfSpaces, ref System.Text.StringBuilder io_hourGlassBuild)
        {
            for (int i = 0; i < i_numOfSpaces; ++i)
            {
                io_hourGlassBuild.Append(" ");
            }
        }
    }
}
