using methods.Classes;

namespace methods.Tests;

public class Tests
{


    [Test]
    public void AddTest()
    {
        ValueOperations operations = new ValueOperations();

        int a = 4;
        int b = 8;
        int excepted = 4;

        int actual;
        actual = operations.Evklid(a,b);
        Assert.AreEqual(excepted,actual);
    }
}