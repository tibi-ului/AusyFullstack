using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        // implicit casting
        sbyte a = 10;

        int b;

        b = a;
        // valuarea lui a este convertita implicit din sbyte in int

        byte c = 20;

        uint d = c;

        char e = 'B';
        int f = e;


       // explicit casting

       int aa = 500;

       float bb;
       bb = (float)aa;

       // loosy conversion
       byte cc;
       cc = (byte)aa;

       Console.WriteLine(aa);
       Console.WriteLine(bb);
       Console.WriteLine(cc);

       // parse
       string aaa = "100";
       int.Parse(aaa);

       int ccc;
       ccc = int.Parse(aaa);
       Console.WriteLine(aaa);

       //TryParse

       string s;
       Console.WriteLine("introdu un numar: ");
       s = Console.ReadLine();

       bool m = int.TryParse(s, out int n);
       Console.WriteLine(n);
       Console.WriteLine(m);
       if (m == true)
       {
           Console.WriteLine("conversion successful");
           Console.WriteLine(n);
       }
       else
       {
           Console.WriteLine("conversion failed");
       }

       // conversion methods
       int x = 1000;
       string y;
       y = Convert.ToString(x);
       Console.WriteLine(x);
       Console.WriteLine(y);


        Console.ReadKey();

    }
}