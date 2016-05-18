


namespace Problem_05_Concatenate_Data
{
using System;
    class ConcatenateData
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sity = Console.ReadLine();
            Console.WriteLine($"You are {name} {lastName}, a {age}-years old person from {sity}.");
        }
    }
}
