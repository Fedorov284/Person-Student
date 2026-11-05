using System;

class Person
{
    public string Name;
    public int Age;
}

class Student : Person
{
    public string Faculty;
    public int Course;
}

// Домашнє завдання
class Teacher : Person
{
    public string Department;
    public decimal Salary;
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Person p = new Person { Name = "Андрій", Age = 40 };
        Student s = new Student { Name = "Богдан", Age = 19, Faculty = "ІТ", Course = 2 };
        Teacher t = new Teacher { Name = "Ольга", Age = 45, Department = "Програмування", Salary = 25000m };

        Console.WriteLine($"Person: {p.Name}, {p.Age} р.");
        Console.WriteLine($"Student: {s.Name}, {s.Age} р., {s.Faculty}, {s.Course} курс");
        Console.WriteLine($"Teacher: {t.Name}, {t.Age} р., {t.Department}, {t.Salary} грн");
    }
}
