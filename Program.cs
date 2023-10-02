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
    public string Faculty { get; set; }
    public string School { get; set; }

    public Student(int id, string name, int age, string studentId, string faculty, string school) : base(id, name, age)
    {
        StudentId = studentId;
        Faculty = faculty;
        School = school;
    }

    public void PrintStudentInfo()
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

    public void PrintLecturerInfo()
    {
        Console.WriteLine("Lecturer Information:");
        PrintInfo();
        Console.WriteLine($"Job: {Job}");
        Console.WriteLine($"Department: {Department}");
    }
}

class Lecturer_Class
{
    public string SubjectNumber { get; set; }
    public string SubjectName { get; set; }
    public int Credit { get; set; }

    public Lecturer_Class(string subjectNumber, string subjectName, int credit)
    {
        SubjectNumber = subjectNumber;
        SubjectName = subjectName;
        Credit = credit;
    }

    public void PrintLecturerClassInfo()
    {
        Console.WriteLine("Lecturer Class Information:");
        Console.WriteLine($"Subject Number: {SubjectNumber}");
        Console.WriteLine($"Subject Name: {SubjectName}");
        Console.WriteLine($"Credit: {Credit}");
    }
}

class Subject
{
    public string SubjectNumber { get; set; }
    public int ClassNumber { get; set; }
    public int NumberOfStudents { get; set; }
    public string Semester { get; set; }

    public Subject(string subjectNumber, int classNumber, int numberOfStudents, string semester)
    {
        SubjectNumber = subjectNumber;
        ClassNumber = classNumber;
        NumberOfStudents = numberOfStudents;
        Semester = semester;
    }

    public void PrintSubjectInfo()
    {
        Console.WriteLine("Subject Information:");
        Console.WriteLine($"Subject Number: {SubjectNumber}");
        Console.WriteLine($"Class Number: {ClassNumber}");
        Console.WriteLine($"Number of Students: {NumberOfStudents}");
        Console.WriteLine($"Semester: {Semester}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(1, "Hoang Long", 20, "S12345", "Electronics", "SEEE");
        student.PrintStudentInfo();

        Console.WriteLine();

        Lecturer lecturer = new Lecturer(2, "Hoang Lam", 35, "Vice-president", "Algebra");
        lecturer.PrintLecturerInfo();

        Console.WriteLine();

        Lecturer_Class lecturerClass = new Lecturer_Class("MI1141", "Computer Science", 3);
        lecturerClass.PrintLecturerClassInfo();

        Console.WriteLine();

        Subject subject = new Subject("MI1141", 1, 30, "Fall 2023");
        subject.PrintSubjectInfo();
    }
}
 