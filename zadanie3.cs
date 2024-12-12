using System;

class Program
{
    static void Main()
    {
        //tablica
        int[] numbers = { 10, 20, 30, 40, 50 };

        //Fumkcja 
        int CalculateSum(int[] array)
        {
            int total = 0;
            foreach (int number in array)
            {
                total += number;
            }
            return total;
        }

        //Obliczenie
        int sum = CalculateSum(numbers);

        Console.WriteLine($"Suma wszystkich elementów tablicy: {sum}");
    }
}
