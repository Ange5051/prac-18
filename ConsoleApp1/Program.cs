using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {FirstName}");
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Возраст: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person
        {
            FirstName = "Олег",
            LastName = "Тиньков",
            Age = 57
        };

        person.DisplayInfo();
        Console.ReadKey();
    }
}
