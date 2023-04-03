﻿namespace Week11Homework9;


public class Student
{
    private int studentID;
    private string studentName;
    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + " Student Name: " + studentName);
    }
    public static List<Student> student_list = new List<Student>();
    public Student(int studentID, string studentName)
    {
        this.studentID = studentID;
        this.studentName = studentName;
        
        student_list.Add(this);
    }
       
    public int GetStudentID()
    {
        return studentID;
    }
    
    public string GetStudentName()
    {
        return studentName;
    }
}

public class Program
{
    public static void Main()
    {
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");
       
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }
        
        double total = 0;
        
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            total += entry.Value;
        }
        
        double average = total / gradebook.Count;
        Console.WriteLine(" ");
        Console.WriteLine("Average GPA: " + average);
        
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            
            if (entry.Value > average)
            {
                Console.WriteLine(entry.Key + " has a GPA greater than the average GPA");
                {
                
                foreach (Student student in Student.student_list)
                    {
                   
                    if (student.GetStudentName() == entry.Key)
                        {
                       
                            student.PrintInfo();
                        }
                    }
                }
            }
            
        }
        Console.WriteLine("");
    }
}
