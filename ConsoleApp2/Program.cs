using System;

class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public void DisplayAddress()
    {
        Console.WriteLine($"Индекс: {Index}");
        Console.WriteLine($"Страна: {Country}");
        Console.WriteLine($"Город: {City}");
        Console.WriteLine($"Улица: {Street}");
        Console.WriteLine($"Дом: {House}");
        Console.WriteLine($"Квартира: {Apartment}");
    }
}

class Program
{
    static void Main()
    {
        Address address = new Address
        {
            Index = "98001",
            Country = "США",
            City = "Вашингтон",
            Street = "Пенсильвания-авеню",
            House = "110",
            Apartment = "125"
        };

        address.DisplayAddress();
        Console.ReadKey();
    }
}
