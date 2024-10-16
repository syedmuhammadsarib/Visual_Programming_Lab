using System;

public class Person
{
    public string name { get; set; }

    //Default Constructor
    public Person()
    {
        name = "Null";
    }

    //Parameterized Constructor
    public Person(string name)
        { 
        this.name = name; 
    }
}

public class Student:Person 
{
    public string regNo {  get; set; }
    public int age { get; set; }
    public Department program { get; set; }

    //Default Constructor
    public Student():base()
    {
        regNo = "Null";
        age = 0;
       program = Department.Null;
    }

    //Parameterized Constructor
    public Student(string name,string regNo, int age, Department program):base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }


}
public enum Department
{ 
    CS,CYS,SE,AF,AI,Null
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        Console.WriteLine(" These are default values after calling default Constructor ---------------");
        Console.WriteLine($" Name: {student.name}\n RegNo: {student.regNo}\n Age: {student.age}\n Program: {student.program}\n");

        Student student1 = new Student("Syed Muhammad Sarib","233505",18,Department.CS);
       
        Console.WriteLine(" This are values after calling Parameterized Constructor ---------------");
        Console.WriteLine($" Name: {student1.name}\n RegNo: {student1.regNo}\n Age: {student1.age}\n Program: {student1.program}\n");
    }
}