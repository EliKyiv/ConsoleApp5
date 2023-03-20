// See https://aka.ms/new-console-template for more information
using System;

internal class Program { 
static void Main(string[] args) { 
    Student John = new Student();
        John.Name = "Johnny";
        John.Lastname = "Carter";
        John.Age = 30;
        John.City = "Kyiv";

        string[] Topics = { "C#", "SQL", "QA" };
        John.Courses = Topics;
        John.Print();

        Array.Resize(ref Topics, Topics.Length + 1);
        Topics[Topics.Length - 1] = "Java";
        John.Courses = Topics;
        John.Print();

        Array.Resize(ref Topics, Topics.Length - 1);
        John.Courses = Topics;
        John.Print();

    }

}

public class Student {
    public int Age { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string City { get; set; }
    public string[] Courses;
    public void Print() {
        Console.WriteLine(Name);
        Console.WriteLine(Lastname);
        Console.WriteLine(City);
        Console.WriteLine(Age);
        Console.WriteLine($"{string.Join(", ", Courses)}");

    }
}