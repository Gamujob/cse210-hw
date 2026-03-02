using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numberList.Add(number);
            }
        }
        int sum = numberList.Sum();
        int quantity = numberList.Count;
        float average = (float)sum / quantity;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        numberList.Sort();

        int greaterNum = numberList[0];
        int smallestNum = numberList[quantity -1];
        foreach (int num in numberList)
        {
            if (num > greaterNum)
            {
                greaterNum = num;
            }
            if (num < smallestNum && num > 0)
            {
                smallestNum = num;
            }
        }
        Console.WriteLine($"The largest number is: {greaterNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        Console.WriteLine("The sorted List is:");

        foreach (int numba in numberList)
        {
            Console.WriteLine(numba);
        }

    }
}