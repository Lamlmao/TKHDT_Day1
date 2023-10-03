using System;
using System.Collections.Generic;

abstract class Person
{
    protected int Id { get; set; }
    protected string Name { get; set; }
    protected int Age { get; set; }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public abstract void PrintInfo();
}

class Student : Person
{
    public string StudentId { get; set; }
    public string Faculty { get; set; }
    public string School { get; set; }
    private List<Lecturer_Class> lecturerClasses = new List<Lecturer_Class>();

    public Student(int id, string name, int age, string studentId, string faculty, string school)
        : base(id, name, age)
    {
        StudentId = studentId;
        Faculty = faculty;
        School = school;
    }

    public void AddLecturerClass(Lecturer_Class lecturerClass)
    {
        lecturerClasses.Add(lecturerClass);
    }

    public void ListLecturerClasses()
    {
        foreach (var lecturerClass in lecturerClasses)
        {
            Console.WriteLine($"Subject Name: {lecturerClass.SubjectName}");
            Console.WriteLine($"Address: {lecturerClass.Address}");
            Console.WriteLine($"Number of Students: {lecturerClass.NumberOfStudents}");
            Console.WriteLine($"Semester: {lecturerClass.Semester}");
            Console.WriteLine($"Credit: {lecturerClass.Credit}");
            Console.WriteLine();
        }
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Student Information:");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Faculty: {Faculty}");
        Console.WriteLine($"School: {School}");
    }
}

class Lecturer : Person
{
    public string Department { get; set; }
    public string Job { get; set; }
    private List<Lecturer_Class> lecturerClasses = new List<Lecturer_Class>();

    public Lecturer(int id, string name, int age, string job, string department)
        : base(id, name, age)
    {
        Job = job;
        Department = department;
    }

    public void AddLecturerClass(Lecturer_Class lecturerClass)
    {
        lecturerClasses.Add(lecturerClass);
    }

    public void ListLecturerClasses()
    {
        foreach (var lecturerClass in lecturerClasses)
        {
            Console.WriteLine($"Subject Name: {lecturerClass.SubjectName}");
            Console.WriteLine($"Address: {lecturerClass.Address}");
            Console.WriteLine($"Number of Students: {lecturerClass.NumberOfStudents}");
            Console.WriteLine($"Semester: {lecturerClass.Semester}");
            Console.WriteLine($"Credit: {lecturerClass.Credit}");
            Console.WriteLine();
        }
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Lecturer Information:");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Job: {Job}");
        Console.WriteLine($"Department: {Department}");
    }
}

class Subject
{
    public string SubjectNumber { get; set; }
    public int Credit { get; set; }

    public Subject(string subjectNumber, int credit)
    {
        SubjectNumber = subjectNumber;
        Credit = credit;
    }

    public void PrintSubjectInfo()
    {
        Console.WriteLine("Subject Information:");
        Console.WriteLine($"Subject Number: {SubjectNumber}");
        Console.WriteLine($"Credit: {Credit}");
    }
}

class Lecturer_Class : Subject  
{
    public string SubjectName { get; set; }
    public string Address { get; set; }
    public int NumberOfStudents { get; set; }
    public string Semester { get; set; }

    public Lecturer_Class(string subjectNumber, int credit, string subjectName, string address, int numberOfStudents, string semester) : base(subjectNumber, credit)
    {
        SubjectName = subjectName;
        Address = address;
        NumberOfStudents = numberOfStudents;
        Semester = semester;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(1, "Hoang Long", 20, "S12345", "Electronics", "SEEE");
        student.PrintInfo();
        
        Console.WriteLine();
        
        Lecturer lecturer = new Lecturer(2, "Hoang Lam", 35, "Vice-president", "Algebra");
        lecturer.PrintInfo();

        Lecturer_Class lecturerClass1 = new Lecturer_Class("IT1141", 3, "Computer Science", "D8-304", 60, "2023.1");
        Lecturer_Class lecturerClass2 = new Lecturer_Class("IT1142", 4, "Software Engineering", "D8-305", 45, "2023.1");

        student.AddLecturerClass(lecturerClass1);
        student.AddLecturerClass(lecturerClass2);

        lecturer.AddLecturerClass(lecturerClass1);

        Console.WriteLine("Lecturer Classes for Student:");
        student.ListLecturerClasses();

        Console.WriteLine();

        Console.WriteLine("Lecturer Classes for Lecturer:");
        lecturer.ListLecturerClasses();
    }
}
