using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace AppZoneTestProjects.Functional.Reports
{
    public class ReportEngine
    {
        public static int Count = 0;
        public static int Divisor = 0;
        public static int Counting = 0;
        public static String[] Lines = { };
        public  static int[] Counter = { };
        public static String ReadPath = null;
        public static String WritePath = null;
        public static String Result = null;

        public static void ReportEngineGlobal(int Divisor, String ReadPath, String WritePath, String Result)
        {
            if (Count % Divisor == 0)
            {
                ++Counting;
                Counter = new int[Counting];
                Console.WriteLine(Counter.Length);
                File.WriteAllText(ReadPath, Counter.Length.ToString());
                String Readfiles = File.ReadAllText(ReadPath);
                Int32 myInt = Int32.Parse(Readfiles);
                String start = myInt.ToString() + "   " + Result;
                Array.Resize(ref Lines, Lines.Length + 1);
                Lines[Lines.GetUpperBound(0)] = start;
                File.WriteAllLines(WritePath, Lines);
            }
        }
       
    }
}
