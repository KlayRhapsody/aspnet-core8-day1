namespace Mylib.Share;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
