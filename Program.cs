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

    Course QA = new Course();
        QA.Name = "QA";
        QA.Teacher = "Christina";
        QA.Duration = 30;
        QA.StudentsQty = 20;
        QA.Print();

        QA.StudentsQty ++;
        QA.Print();
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
    public Student() {
        Age = 0;
        Name = string.Empty;
        Lastname = string.Empty;
        City = string.Empty;
    }

    public Student(string name, string lastname, string city, int age) {
        Name = name;
        Lastname = lastname;
        City = city;
        Age = age;
    }

}

public class Course { 
    public string Name { get; set; }
    public string Teacher { get; set; }
    public int Duration { get; set; }
    public int StudentsQty { get; set; }

    public void Print () {
        Console.WriteLine(Name);
        Console.WriteLine(Teacher);
        Console.WriteLine(Duration);
        Console.WriteLine(StudentsQty);
    }

    public Course() { 
        Name = string.Empty;
        Teacher = string.Empty;
        Duration = 0;
        StudentsQty = 0;
    }

    public Course(string name, string teacher, int duration, int studentsQty) {
        Name = name;
        Teacher = teacher;
        Duration = duration;
        StudentsQty = studentsQty;
    }

}