using System;
using System.IO;



namespace FileStreamEx
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "C:\\Users\\tului\\Desktop\\AusyFullstack\\C#10UltimateGuide\\Section28IOSerializationEncoding\\practice\\dog.txt";

            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.Create(filePath); //contine deja fileMode si fileAccess
            //FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);
            //se creeaza un obiect al clasei FileStream in mai multe moduri

            //sau cu fileInfo
            FileInfo fileInfo = new FileInfo(filePath);
            //FileStream fileStream = fileInfo.Create();
            //FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
            FileStream fileStream = fileInfo.OpenWrite();
        }
    }
}
