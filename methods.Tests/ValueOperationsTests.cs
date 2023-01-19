using methods.Classes;

namespace methods.Tests;

public class TestsCaseValueOperations
{
    //Актуальное тестирование
    [TestCase(5,9,1)]
    [TestCase(4,16,4)]
    public void EvklidTest(int a, int b, int excepted)
    {
        ValueOperations operations = new ValueOperations();


        int actual = operations.Evklid(a,b);
        Assert.AreEqual(excepted,actual);
    }
    
    [TestCase(100,1)]
    [TestCase(505,2)]
    [TestCase(345,2)]
    [TestCase(000,0)]
    public void FindOddValuesOfNumberTest(int userEnterValue, int excepted)
    {
        ValueOperations operations = new ValueOperations();


        int actual = operations.FindOddValuesOfNumber(userEnterValue);
        Assert.AreEqual(excepted,actual);
    }
    
    
    [TestCase(100,50)]
    [TestCase(0,0)]
    [TestCase(40,20)]
    public void FindMaxDivOfValueTest(int a, int excepted)
    {
        ValueOperations operations = new ValueOperations();


        int actual = operations.FindMaxDivOfValue(a);
        Assert.AreEqual(excepted,actual);
    }
}