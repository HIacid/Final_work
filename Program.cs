using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array's element divided by comma:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

        Console.WriteLine("Array: [" + string.Join(", ", originalArray) + "]");

        string[] result = new string[0];