using System;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Samochód:");
        Console.WriteLine($"  Marke: {Make}");
        Console.WriteLine($"  Model: {Model}");
        Console.WriteLine($"  Rok produkcji: {Year}");
    }
}

class Program
{
    static void Main()
    {
        
        Car myCar = new Car("Toyota", "Corolla", 2020);

        myCar.DisplayInfo();
    }
}
