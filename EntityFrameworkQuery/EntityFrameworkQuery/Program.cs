// See https://aka.ms/new-console-template for more information
using EntityFrameworkQuery.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new SchoolContextDBContext())
{
    var students = context.Students;

    foreach (var s in students)
    {
        Console.WriteLine(s.LastName);
    }
}
Console.WriteLine("..............................................");
//Where, Take, Contain ...
{
    var context = new SchoolContextDBContext();
    var students = context.Students
                .Where(s => s.LastName.Contains("a"))
                .OrderByDescending(s => s.LastName)
                .Take(2);
    foreach (var s in students)
    {
        Console.WriteLine(s.LastName);
    }
}
Console.WriteLine("..............................................");
using (var context = new SchoolContextDBContext())
{
    var students = context.Students;
    var student = context.Students.FirstOrDefault(s => (s.Id > 1 && s.LastName.StartsWith("a")));
    if (student != null)
        Console.WriteLine($"{student.LastName}");
}
Console.WriteLine("..............................................");
using (var context = new SchoolContextDBContext())
{
    var students = context.Students;
    var student = context.Students.Find(3);
    if (student != null)
        Console.WriteLine($"{student.LastName}");
}
Console.WriteLine("....................LINQ.................");
using (var context = new SchoolContextDBContext())
{

    var students = (from s in context.Students 
                   select s)
                   .ToList();
    foreach (var s in students)
    {
        Console.WriteLine(s.LastName);
    }
}
Console.WriteLine("....................inner join.................");
using (var context = new SchoolContextDBContext())
{
    var courses = from c in context.Courses
                  join d in context.Departments on c.DepartmentId equals d.DepartmentId
                // where ....
                  select new
                  {
                      CourseName = c.Title,
                      Credit = c.Credits,
                      DepartmentName = d.Name
                  };



    foreach (var c in courses)
    {
        Console.WriteLine($"{c.CourseName} giá {c.Credit} danh mục {c.DepartmentName}");
    }
}