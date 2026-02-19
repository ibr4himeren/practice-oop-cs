using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group("OOP Group");
        GroupService service = new GroupService();

        Student s1 = new Student(1, "Ali", "Yilmaz", "ali@mail.com", new List<int> { 8, 9, 10 });
        Student s2 = new Student(2, "Ayse", "Demir", "ayse@mail.com", new List<int> { 7, 8, 9 });
        Student s3 = new Student(3, "Mehmet", "Kaya", "mehmet@mail.com", new List<int> { 6, 7, 8 });

        service.RegisterStudent(group, s1);
        service.RegisterStudent(group, s2);
        service.RegisterStudent(group, s3);

        foreach (var student in service.GetAllStudents(group))
        {
            Console.WriteLine(student.Describe());
        }

        Console.ReadKey();
    }
}
