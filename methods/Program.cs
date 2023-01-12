using methods.Classes;

ValueOperations operations = new ValueOperations();
// int fibonachi = operations.FindFibonachi(20);
// Console.Write(fibonachi);

// string g = operations.SummOddAndEven(30);
// Console.Write(g);

// int odd = operations.FindOddValuesOfNumber(0);
// Console.Write(odd);

// int evklid = operations.Evklid(4, 8);
// Console.Write(evklid);

// int maxDiv = operations.FindMaxDivOfValue(20);
// Console.Write(maxDiv);

// int halfDiv = operations.HalfDivisionValue(24);
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

// int even = operations.SummEvenOrSummOdd(3679);
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

// int minIndex = arrays.ArrayMinIndex(new int[] { 3, 8, 1, 5 });
// Console.WriteLine(minIndex);
//
// int maxIndex = arrays.ArrayMaxIndex(new int[] { 3, 8, 1, 5,11 });
// Console.WriteLine(maxIndex);

// int[] arrayReverse = arrays.ArrayReverse(new int[] { 3, 8, 1, 5,11 });
// for (int i = arrayReverse.Length -1; i >= 0;i--)
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


// int arrayFindSummOfOdd = arrays.ArrayFindSummOfOdd(new int[] { 3, 8, 1, 5, 11, 6, 7, 3 });
// Console.WriteLine(arrayFindSummOfOdd);

    
// int arraySummOfOddIndexNumbers = arrays.ArraySummOfOddIndexNumbers(new int[] { 3, 8, 1, 5, 11, 6, 7, 3});
// Console.WriteLine(arraySummOfOddIndexNumbers);

// int[] arrRandomNumbers = arrays.CreateArrRandomNumbers();
// for (int i = 0; i < arrRandomNumbers.Length; i++)
// {
//     Console.WriteLine(arrRandomNumbers[i]);
// }

// string compareNumbers = arrays.Compare(33,26);
// if (compareNumbers != "да")
// {
//     Console.Write("нет");
// }
// else
// {
//     Console.Write(compareNumbers);
//
// }

// int[,] arrayTranspositionSecondary = arrays.DoubleArrayTranspositionOnSecondaryDiagonal(3,3);
// Console.WriteLine(arrayTranspositionSecondary);

// int[,] arrayTranspositionMain = arrays.DoubleArrayTranspositionOnMainDiagonal(3,3);

// int[,] doubleArrayMax = arrays.DoubleArraySortToMax();

int[,] doubleArrayRandom = arrays.CreateDoubleArrWithRandomNumbers(3, 3);
arrays.PrintDoubleArray(doubleArrayRandom);
arrays.PrintBiggestNeightborOfDoubleArray(doubleArrayRandom);
arrays.PrintMaxValueOfDoubleArray(doubleArrayRandom);
arrays.PrintMinValueOfDoubleArray(doubleArrayRandom);
arrays.PrintSummOfOddElementsOfDoubleArray(doubleArrayRandom);
arrays.PrintSummOfEvenElementsOfDoubleArray(doubleArrayRandom);
arrays.PrintDifferenceOfSummEvenAndOddAtDoubleArray(doubleArrayRandom);





Console.Read();




