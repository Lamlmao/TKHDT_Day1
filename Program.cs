using System;

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Student : Person
{
    public string StudentId { get; set; }

    public Student(int id, string name, int age, string studentId) : base(id, name, age)
    {
        StudentId = studentId;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine("Student Information:");
        PrintInfo();
        Console.WriteLine($"Student ID: {StudentId}");
    }
}

class Lecturer : Person
{
    public string Department { get; set; }

    public Lecturer(int id, string name, int age, string department) : base(id, name, age)
    {
        Department = department;
    }

    public void PrintLecturerInfo()
    {
        Console.WriteLine("Lecturer Information:");
        PrintInfo();
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(1, "John Doe", 20, "S12345");
        student.PrintStudentInfo();

        Console.WriteLine();

        Lecturer lecturer = new Lecturer(2, "Jane Smith", 35, "Computer Science");
        lecturer.PrintLecturerInfo();
    }
}
