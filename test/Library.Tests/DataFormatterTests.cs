using TestDateFormat;
namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {   
        DateFormatter format = new DateFormatter();
        string date = format.ChangeFormat("11-22-2003");
        Assert.AreEqual(date, "2003-22-11");
        date = format.ChangeFormat("11222003");
        Assert.AreNotEqual(date, "11/22/2003");
    }
}