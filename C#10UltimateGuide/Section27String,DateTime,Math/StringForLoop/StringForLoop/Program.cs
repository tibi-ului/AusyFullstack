using System;
using System.Collections.Generic;
using System.Linq;


namespace StringForLoop
{
    internal class Program
    {
        static void Main()
        {
            string name = "developer@example.com";
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            #region For Loop
            int vowelsCount = 0;
            for (int i = 0; i <= name.Length -1; i++)
            {
                bool isMatch = false;

                for (int j = 0; j < vowels.Length; j++)
                
                    if (name[i] == vowels[j])
                        isMatch = true;

                if (isMatch)
                    vowelsCount++;
                    
                    Console.WriteLine(name[i] + " " + isMatch);

            }
            Console.WriteLine(vowelsCount + " " + "vowels");
            #endregion
            Console.WriteLine();

            #region For Loop with Methods of arrays / collections

            vowelsCount= 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (Array.IndexOf(vowels, name[i]) >= 0)
                    vowelsCount++;
            }
            Console.WriteLine(vowelsCount + " " + "vowels");



            #endregion
            Console.WriteLine();

            #region LINQ methods

            int numberOfVowels = name.Count(ch => Array.IndexOf(vowels, ch) >= 0);
            Console.WriteLine(numberOfVowels + " vowels");

            #endregion
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
