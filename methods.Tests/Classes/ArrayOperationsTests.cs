using methods.Classes;
namespace methods.Tests;

public class TestCaseArrayOperations
{
    [TestCase(1,55)]
    [TestCase(2,9)]
    [TestCase(3,0)]
    public void ArrayMaxTests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int actual = arrays.ArrayMax(arr);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,2)]
    [TestCase(2,3)]
    [TestCase(3,0)]
    public void ArrayMinTests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int actual = arrays.ArrayMin(arr);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,3)]
    [TestCase(2,3)]
    [TestCase(3,0)]
    public void ArrayMinIndexTests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int actual = arrays.ArrayMinIndex(arr);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,1)]
    [TestCase(2,2)]
    [TestCase(3,0)]
    public void ArrayMaxIndexTests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int actual = arrays.ArrayMaxIndex(arr);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,new int[] {2,7,55,3})]
    [TestCase(2,new int[] {3,9,7,5})]
    [TestCase(3,new int[] {0,0,0,0})]
    public void ArrayReverseTests(int mockNumber,int[] expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int[] actual = arrays.ArrayReverse(arr);
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,new int[] {2,3,7,55})]
    [TestCase(2,new int[] {3,5,7,9})]
    [TestCase(3,new int[] {0,0,0,0})]
    public void ArraySortToMaxBubbleTests(int mockNumber,int[] expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int[] actual = arrays.ArraySortToMaxBubble(arr);
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,new int[] {55,7,3,2})]
    [TestCase(2,new int[] {9,7,5,3})]
    [TestCase(3,new int[] {0,0,0,0})]
    public void ArraySortToMinBubbleTests(int mockNumber,int[] expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int[] actual = arrays.ArraySortToMinBubble(arr);
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,3)]
    [TestCase(2,4)]
    [TestCase(3,0)]
    public void ArrayFindSumOfOddElementsTests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int actual = arrays.ArrayFindSumOfOddElements(arr);
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,57)]
    [TestCase(2,10)]
    [TestCase(3,0)]
    public void ArraySumOfOddIndexNumbersTests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        ArrayMock mock = new ArrayMock();
        int[] arr = mock.GetMock(mockNumber);
        int actual = arrays.ArraySumOfOddIndexNumbers(arr);
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(13425,62190, "да")]
    [TestCase(03981,12066, "да")]
    [TestCase(13425,67890, "нет")]
    [TestCase(0000,000000, "да")]
    public void CompareIdenticalSymbolsOfValuesTests(int value1, int value2,string expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        string actual = arrays.CompareIdenticalSymbolsOfValues(value1,value2);
        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(1,4)]
    [TestCase(2,4)]
    [TestCase(3,0)]
    public void CountOfBiggestNeighborsOfDoubleArray_Tests(int mockNumber,int expected)
    {
        ArrayOperations arrays = new ArrayOperations();
        DoubleArrayMock mock = new DoubleArrayMock();
        int[,] arr = mock.GetMock(mockNumber);
        int actual = arrays.CountOfBiggestNeighborsOfDoubleArray(arr);
        
        Assert.AreEqual(expected, actual);
    }
    public class ArrayMock
    {
        public int[] GetMock(int number)
        {
            int[] result = new int[0];
            switch (number)
            {
                case 1:
                    result = new int[] { 3, 55, 7, 2 };

                    break;
                case 2:
                    result = new int[] { 5, 7, 9, 3 };
                    
                    break;
                case 3:
                    result = new int[] { 0, 0, 0, 0 };
                    
                    break;
            }

            return result;
        }
        
    }
    public class DoubleArrayMock
    {
        public int[,] GetMock(int number)
        {
            int[,] result = new int[0,0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        {1,3,5,6},
                        {3,5,2,1},
                        {7,3,5,2}
                    };
                    
                    break;
                case 2:
                    result = new int[,]
                    {
                        {1,3,5},
                        {3,5,2},
                        {7,3,5}
                    };
                    
                    break;
            }

            return result;
        }
    }
}