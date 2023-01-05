using System;

class Sample
{
    static void Main()
    {
        System.Console.Write("enter the radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());
       double pi = 3.14159;
       double areaCircle = pi * radius * radius;
       System.Console.Write("the area of the circle is: ");


       System.Console.WriteLine(areaCircle);
       System.Console.ReadKey();
    }
} 