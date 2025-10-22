using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name;
    public int Age;
    public string City;
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 22, City = "Delhi" },
            new Person { Name = "Bob", Age = 30, City = "Mumbai" },
            new Person { Name = "Charlie", Age = 28, City = "Delhi" },
            new Person { Name = "David", Age = 35, City = "Chennai" },
            new Person { Name = "Emma", Age = 26, City = "Delhi" }
        };

        string selectedCity = "Delhi"; 

        var filteredPeople = people
            .Where(p => p.Age > 25 && p.City == selectedCity)
            .Select(p => new { p.Name, p.Age }) 
            .ToList();

        Console.WriteLine($"People above 25 from {selectedCity}:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
