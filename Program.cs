using System;

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

    public abstract void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}   

class Student : Person
{
    public string StudentId { get; set; }
    public string Faculty { get; set; }
    public string School { get; set; }

    public Student(int id, string name, int age, string studentId, string faculty, string school) : base(id, name, age)
    {
        StudentId = studentId;
        Faculty = faculty;
        School = school;
    }

    public override void PrintStudentInfo()
    {
        Console.WriteLine("Student Information:");
        PrintInfo();
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Faculty: {Faculty}");
        Console.WriteLine($"School: {School}");
    }
}

class Lecturer : Person
{
    public string Department { get; set; }
    public string Job { get; set; }

    public Lecturer(int id, string name, int age, string job, string department) : base(id, name, age)
    {
        Job = job;
        Department = department;
    }

    public override void PrintLecturerInfo()
    {
        Console.WriteLine("Lecturer Information:");
        PrintInfo();
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
    public int Semester { get; set; }


    public Lecturer_Class(string subjectNumber, int credit, string subjectName, string address, int numberOfStudents, string semester) 
    {
        SubjectName = subjectName;
        Address = address;
        NumberOfStudents = numberOfStudents;
        Semester = semester;
    }

    public void PrintLecturerClassInfo()
    {
        Console.WriteLine("Lecturer Class Information:");
        Console.WriteLine($"Subject Name: {SubjectName}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"NumberOfStudents: {NumberOfStudents}");        
        Console.WriteLine($"Credit: {Semester}");
        Console.WriteLine($"Credit: {Credit}");
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

        Console.WriteLine();

        Subject subject = new Subject("MI1141", 1);
        subject.PrintSubjectInfo();

        Lecturer_Class lecturerClass = new Lecturer_Class("MI1141", "Computer Science", 3, "D8-304", 30, "Fall 2023");
        lecturerClass.PrintLecturerClassInfo();

        Console.WriteLine();
    }
}
 
