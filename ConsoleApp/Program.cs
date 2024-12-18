// See https://aka.ms/new-console-template for more information

using Mylib.Share;

var student = new Student("John", 20);
var student2 = new Student()
{
    Name = "Jane",
    Age = 21
};
Console.WriteLine($"{student.Name} is {student.Age} years old.");
Console.WriteLine($"{student2.Name} is {student2.Age} years old.");
