namespace Problem_03_Inches_To_Centimeters
{
    using System;
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            double readValueToCnvert = double.Parse(Console.ReadLine());
            Console.WriteLine(readValueToCnvert*2.54f);
        }
    }
}
