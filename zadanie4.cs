using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Dodaj pracownika");
            Console.WriteLine("2. Wyświetl listę pracowników");
            Console.WriteLine("3. Zakończ");

            Console.Write("Wybierz opcję: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    DisplayEmployees();
                    break;
                case 3:
                    Console.WriteLine("Zakończenie programu.");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddEmployee()
    {
        Console.Write("Podaj nazwisko pracownika: ");
        string name = Console.ReadLine();
        employees.Add(new Employee(name));
        Console.WriteLine($"Pracownik {name} dodany do listy.");
        Console.WriteLine("Oto zaaktualizowana lista pracownikow:");
      foreach (var employee in employees)
        {
            Console.WriteLine($"  {employee.Name}");
        }
    }

    static void DisplayEmployees()
    {
        Console.WriteLine("Lista pracowników:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"  {employee.Name}");
        }
    }
}
