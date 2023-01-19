using methods.Classes;

namespace methods.Tests;

public class TestsCaseER
{
    //Таким тестированием почти не пользуются
    [TestCase(4,8,ExpectedResult = 4)]
    // [TestCase(5,8,ExpectedResult = 17)]
    // [TestCase(6,18,ExpectedResult = 15)]
    //
    // [TestCase(42,38,ExpectedResult = 13)]

    public int EvklidTest(int a, int b)
    {
        ValueOperations operations = new ValueOperations();


        int actual = operations.Evklid(a,b);
//        Assert.AreEqual(excepted,actual);
        return actual;
    }
}