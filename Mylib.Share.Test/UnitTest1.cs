namespace Mylib.Share.Test;
using Mylib.Share;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStudentInstance()
    {
        var student = new Student(){ Name = "John", Age = 18 };

        Assert.AreEqual("John", student.Name);
        Assert.AreEqual(18, student.Age);
    }
}