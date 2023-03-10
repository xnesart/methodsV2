using methods.Classes;

namespace methods.Tests;

public class TestsCaseValueOperations
{
    //Актуальное тестирование
    [TestCase(2,1)]
    [TestCase(3,2)]
    [TestCase(0,0)]
    public void FindFibonachiTest(int n, int excepted)
    {
        ValueOperations operations = new ValueOperations();
        int actual = operations.FindFibonachi(n);
        Assert.AreEqual(excepted,actual);
    }
    
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
    
    [TestCase(4,64)]
    [TestCase(2,8)]

    public void HalfDivisionValueTest(int a, int excepted)
    {
        ValueOperations operations = new ValueOperations();
        int actual = operations.HalfDivisionValue(a);
        Assert.AreEqual(excepted,actual);
    }
    
    [TestCase(123,new int[]{3,2,1})]
    [TestCase(32354,new int[]{4,5,3,2,3})]
    [TestCase(6059320,new int[]{0,2,3,9,5,0,6})]
    public void RevertValueTest(int value, int[] excepted)
    {
        ValueOperations operations = new ValueOperations();
        int[] actual = operations.RevertValue(value);
        Assert.AreEqual(excepted,actual);
    }
    
    [TestCase(10,5)]
    [TestCase(12,6)]
    [TestCase(21,10)]
    public void SumEvenOfValueTests(int a, int excepted)
    {
        ValueOperations operations = new ValueOperations();
        int actual = operations.SumEvenOfValue(a);
        Assert.AreEqual(excepted,actual);
    }
}