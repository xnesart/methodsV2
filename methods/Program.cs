using methods.Classes;

ValueOperations operations = new ValueOperations();
// int fibonachi = operations.FindFibonachi(20);
// Console.Write(fibonachi);

// string g = operations.SumOddAndEven(30);
// Console.Write(g);

// int countOfOdd = operations.FindOddValuesOfNumber(0);
// Console.WriteLine(countOfOdd);

// int evklid = operations.Evklid(5, 7);
// Console.Write(evklid);

// int maxDiv = operations.FindMaxDivOfValue(100);
// Console.WriteLine(maxDiv);

// int halfDiv = operations.HalfDivisionValue(4);
// Console.Write(halfDiv);

// int revertVal = operations.RevertValue(420);
// Console.Write(revertVal);

// int[] revertValue = operations.RevertValue(new int[] { 0,0,0,5 });
// int[] revertValue = operations.RevertValue(005);
//
// for (int i = revertValue.Length -1; i >= 0;i--)
// {
//     Console.Write(revertValue[i]);
// }

// int even = operations.SumEvenOrSumOdd(3679);
// Console.Write(even);

Functions functions = new Functions();
// double divFunction = functions.HalfDivFunction(23);
// Console.Write(divFunction);

// int[,] convertStringToInt = functions.ConvertStringToInt(new string[,]{});
// Console.Write(convertStringToInt);

ArrayOperations arrays = new ArrayOperations();

// int maxValueArr = arrays.ArrayMax(new int[] { 3, 6, 8 });
// Console.WriteLine(maxValueArr);
//
// int minValueArr = arrays.ArrayMin(new int[] { 5, 6, 1 });
// Console.WriteLine(minValueArr);

// int minIndex = arrays.ArrayMinIndex(new int[] { 3, 8, 1, 5, 0 });
// Console.WriteLine(minIndex);
//
// int maxIndex = arrays.ArrayMaxIndex(new int[] { 3, 8, 1, 5,11,35,67 });
// Console.WriteLine(maxIndex);

// int[] arrayReverse = arrays.ArrayReverse(new int[] { 3, 8, 1, 5,11 });
// for (int i = 0; i < arrayReverse.Length;i++)
// {
//     Console.WriteLine(arrayReverse[i]);
// }

// int[] arraySort = arrays.ArraySortToMaxBubble(new int[] { 3, 8, 1, 5,11 });
// for (int i = 0; i < arraySort.Length;i++)
// {
//     Console.WriteLine(arraySort[i]);
// }

// int[] arraySortToMinBub = arrays.ArraySortToMinBubble(new int[] { 3, 8, 1, 5,11 });
// for (int i = 0; i < arraySortToMinBub.Length;i++)
// {
//     Console.WriteLine(arraySortToMinBub[i]);
// }

// int arrayFindSumOfOdd = arrays.ArrayFindSumOfOddElements(new int[] { 3, 8, 1, 5, 11, 6, 7, 3 });
// Console.WriteLine(arrayFindSumOfOdd);

// int arraySumOfOddIndexNumbers = arrays.ArraySumOfOddIndexNumbers(new int[] { 3, 8, 1, 5, 11, 6, 7, 3});
// Console.WriteLine(arraySumOfOddIndexNumbers);

// int[] arrRandomNumbers = arrays.CreateArrRandomNumbers(0);
// for (int i = 0; i < arrRandomNumbers.Length; i++)
// {
//     Console.WriteLine(arrRandomNumbers[i]);
// }

// string compareNumbers = arrays.CompareIdenticalSymbolsOfValues(30000456,000008769);
// Console.Write(compareNumbers);



// int[,] doubleArrayMax = arrays.DoubleArraySortToMax();

int[,] doubleArrayRandom = arrays.CreateDoubleArrWithRandomNumbers(3, 3);
arrays.PrintDoubleArray(doubleArrayRandom);
// arrays.PrintBiggestNeightborOfDoubleArray(doubleArrayRandom);
// arrays.PrintMaxValueOfDoubleArray(doubleArrayRandom);
// arrays.PrintMinValueOfDoubleArray(doubleArrayRandom);
// arrays.PrintSumOfOddElementsOfDoubleArray(doubleArrayRandom);
// arrays.PrintSumOfEvenElementsOfDoubleArray(doubleArrayRandom);
// arrays.PrintDifferenceOfSumEvenAndOddAtDoubleArray(doubleArrayRandom);
// arrays.PrintCountOfLineAndColumnOfDoubleArray(doubleArrayRandom);
// arrays.PrintSortingColumnsToMax(doubleArrayRandom);

// int[,] arrayTranspositionSecondary = arrays.TranspositionOnSecondaryDiagonalOfDoubleArray(3,3);
// Console.WriteLine(arrayTranspositionSecondary);

// int[,] arrayTranspositionMain = arrays.TranspositionOnMainDiagonalOfDoubleArray(3,3);
// arrays.MatrixTranspositionOfDoubleArray(doubleArrayRandom);


Console.Read();




