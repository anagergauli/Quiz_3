//Task_1, Quiz_3

//Student, Teacher and Subject classes + ToString Method
//constructors with and without constructors

using System;
using System.Collections.Generic;
public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public long PersonalNumber { get; set; }
    public List<string> Subjects { get; set; }
    public List<string> Semesters { get; set; }
    public double GPA { get; set; }

    public string FullName => $"{Name} {Surname}";

    public Student(string name, string surname, long personalNumber)
    {
        Name = name;
        Surname = surname;
        PersonalNumber = personalNumber;
        Subjects = new List<string>();
        Semesters = new List<string>();
        GPA = 0;
    }

    public void AddSemester(string semester)
    {
        Semesters.Add(semester);
    }

    public void AddSubjectToSemester(string semester, string subject)
    {
        if (!Semesters.Contains(semester))
        {
            throw new ArgumentException("Semester not found!");
        }

        Subjects.Add(subject);
    }

    public List<string> GetSubjectsForSemester(string semester)
    {
        if (!Semesters.Contains(semester))
        {
            throw new ArgumentException("Semester not found!");
        }

        return Subjects.Where(s => Semesters.IndexOf(semester) == Subjects.IndexOf(s)).ToList();
    }

    public List<string> GetLecturersForSemester(string semester)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{FullName} ({PersonalNumber})";
    }
}

public class Teacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> Subjects { get; set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Subjects = new List<string>();
    }

    public void AddSubject(string subject)
    {
        if (Subjects.Count >= 3)
        {
            throw new InvalidOperationException("Teacher can't teach more than 3 subjects!");
        }

        Subjects.Add(subject);
    }

    public void ModifySubject(int index, string subject)
    {
        if (index < 0 || index >= Subjects.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range!");
        }

        Subjects[index] = subject;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public class Subject
{
    public string Name { get; set; }
    public List<string> Prerequisites { get; set; }
    public int Credits { get; set; }
    public int MaxStudents { get; set; }

    public Subject(string name, List<string> prerequisites, int credits, int maxStudents)
    {
        Name = name;
        Prerequisites = prerequisites;
        Credits = credits;
        MaxStudents = maxStudents;
    }

    public override string ToString()
    {
        return Name;
    }
}
