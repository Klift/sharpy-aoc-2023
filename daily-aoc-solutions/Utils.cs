using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_aoc_solutions
{
    internal class Utils
    {
        public static string DataDirectory = @"C:\Users\a.nitijevskis\Documents\aoc2023\data";

        public static int GetDayNumber(string className)
        {
            return Int32.Parse(string.Join("", className.ToCharArray().Where(c => Char.IsDigit(c)).ToList()));
        }

        public static string GetInputPath(string className, string inputType)
        {
            int dayNumber = GetDayNumber(className);
            return Path.Combine(new string[] { DataDirectory, $"day-{dayNumber:00}-{inputType}.txt" });
        }
        public static string GetOutputPath(string className, string inputType)
        {
            int dayNumber = GetDayNumber(className);
            return Path.Combine(new string[] { DataDirectory, $"day-{dayNumber:00}-{inputType}-output.txt" });
        }
        public static string GetExpectedExampleOutputPath(string className, int part)
        {
            int dayNumber = GetDayNumber(className);
            return Path.Combine(new string[] { DataDirectory, $"day-{dayNumber:00}-expected-sample-output-part{part}.txt" });
        }
    }
}
