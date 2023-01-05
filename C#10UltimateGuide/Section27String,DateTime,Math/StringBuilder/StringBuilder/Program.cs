using System;
using System.Text;


namespace StringBuilderEx
{
    internal class Program
    {
        static void Main()
        {
            string[] words = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

            string sentence = "";

            #region foreach
            foreach (string word in words)
            {
                sentence += " " + word;
                //la fiecare iteratie se vor creea cate doua obiecte pentru ca facem concatenare de 2 ori
            }
            Console.WriteLine(sentence);
            #endregion
            Console.WriteLine();


            #region StrigBuilder

            StringBuilder builder = new StringBuilder();
            foreach (string word in words)
            {
                builder.Append(word);
                builder.Append(" ");
            }
            Console.WriteLine(builder.ToString());    //ToString va converti StringBuilder in string

            #endregion


            Console.ReadKey();
        }
    }
}
