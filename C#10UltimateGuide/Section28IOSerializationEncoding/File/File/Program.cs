using System;
using System.IO;


namespace FileEx
{
    class Program
    {
        static void Main()
        {
            File.Create(@"C:\Users\tului\Desktop\AusyFullstack\C#10UltimateGuide\Section28IOSerializationEncoding\test\test@.txt").Close();
            File.Delete(@"C:\Users\tului\Desktop\AusyFullstack\C#10UltimateGuide\Section28IOSerializationEncoding\test\test@.txt");

            string filePath = "C:\\Users\\tului\\Desktop\\AusyFullstack\\C#10UltimateGuide\\Section28IOSerializationEncoding\\test\\test.txt";
            string content = "sarbatori fericite \u1F43 \n\u4E10";
            string unicodeSymbol = "\u0543";
            Console.WriteLine(unicodeSymbol);

            File.Create(filePath).Close();
            File.WriteAllText(filePath, content);

            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);





            Console.ReadKey();
        }
    }
}
