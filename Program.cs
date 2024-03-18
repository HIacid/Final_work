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

        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Trim().Length <= 3)
            {
                string[] temp = new string[result.Length + 1];
                Array.Copy(result, temp, result.Length);
                temp[result.Length] = originalArray[i];
                result = temp;
            }
        }

        
        Console.WriteLine("Filtered array: [" + string.Join(",", result) + "]");
    }
}