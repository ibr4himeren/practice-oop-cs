using System;

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group("OOP Group");

        Student s1 = new Student(1, "Mudar", "Shawakh", "m@mail.com", 8.5);
        Student s2 = new Student(2, "a", "a", "a@mail.com", 9.1);
        Student s3 = new Student(3, "b", "b", "b@mail.com", 7.8);

        group.AddStudent(s1);
        group.AddStudent(s2);
        group.AddStudent(s3);

        group.PrintAll();

        Console.ReadKey();
    }
}
