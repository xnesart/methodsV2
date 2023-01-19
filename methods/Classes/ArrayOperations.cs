namespace methods.Classes;

public class ArrayOperations
{
    /// <summary>
    /// Проверяет массив, если он пустой - выдает ошибку
    /// </summary>
    /// <param name="array"></param>
    /// <exception cref="Exception"></exception>
    public void CheckArrayEmpty(int[] array)
    {
        if (array.Length == 0) throw new Exception("вы ввели пустой массив");
    }

    /// <summary>
    /// Находим наибольшее число в массиве
    /// </summary>
    /// <param name="array"></param>
    /// <returns>max</returns>
    public int ArrayMax(int[] array)
    {
        CheckArrayEmpty(array);
        var max = array[0];

        for (var i = 0; i < array.Length; i++)
            if (max < array[i])
                max = array[i];
        return max;
    }

    /// <summary>
    /// Находим наименьшее число в массиве
    /// </summary>
    /// <param name="array"></param>
    /// <returns>min</returns>
    public int ArrayMin(int[] array)
    {
        CheckArrayEmpty(array);

        var min = array[0];
        for (var i = 0; i < array.Length; i++)
            if (min > array[i])
                min = array[i];
        return min;
    }

    /// <summary>
    /// находим индекс минимального числа в массиве
    /// </summary>
    /// <param name="array"></param>
    /// <returns>minIndex</returns>
    public int ArrayMinIndex(int[] array)
    {
        CheckArrayEmpty(array);

        if (array.Length - 1 < 0) throw new Exception("вы ввели пустой массив");
        var minIndex = 0;
        for (var i = 0; i < array.Length; i++)
            if (array[0] > array[i])
                minIndex = i;

        return minIndex;
    }

    /// <summary>
    ///Находим индекс у самого большого числа массива
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int ArrayMaxIndex(int[] array)
    {
        CheckArrayEmpty(array);

        if (array.Length - 1 < 0) throw new Exception("вы ввели пустой массив");
        var maxIndex = 0;
        for (var i = 0; i < array.Length; i++)
            if (array[0] < array[i])
                maxIndex = i;
        return maxIndex;
    }

    /// <summary>
    ///Сделать реверс массива (массив в обратном направлении)
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[] ArrayReverse(int[] array)
    {
        CheckArrayEmpty(array);

        var arrayReverse = new int[array.Length];
        for (var i = array.Length - 1; i >= 0; i--) arrayReverse[array.Length - 1 - i] = array[i];

        return arrayReverse;
    }

    /// <summary>
    /// Сортировка массива по возрастанию методом пузырька
    /// </summary>
    /// <param name="array"></param>
    /// <returns>array</returns>
    public int[] ArraySortToMaxBubble(int[] array)
    {
        CheckArrayEmpty(array);

        int temp;
        for (var i = 0; i < array.Length; i++)
        for (var k = i + 1; k < array.Length; k++)
            if (array[i] > array[k])
            {
                temp = array[k];
                array[k] = array[i];
                array[i] = temp;
            }

        return array;
    }

    /// <summary>
    /// Сортировка массива по убыванию методом пузырька
    /// </summary>
    /// <param name="array"></param>
    /// <returns>array</returns>
    public int[] ArraySortToMinBubble(int[] array)
    {
        CheckArrayEmpty(array);

        int temp;

        for (var i = 0; i < array.Length; i++)
        for (var k = i + 1; k < array.Length; k++)
            if (array[i] < array[k])
            {
                temp = array[k];
                array[k] = array[i];
                array[i] = temp;
            }

        return array;
    }

    /// <summary>
    ///Посчитать количество нечетных элементов массива
    /// </summary>
    /// <param name="array"></param>
    /// <returns>counter</returns>
    public int ArrayFindSumOfOddElements(int[] array)
    {
        CheckArrayEmpty(array);

        var counter = 0;
        for (var i = 0; i < array.Length; i++)
            if (array[i] % 2 != 0)
                counter++;

        return counter;
    }

    /// <summary>
    /// Посчитать сумму элементов массива с нечетными индексами
    /// </summary>
    /// <param name="array"></param>
    /// <returns>odd</returns>
    public int ArraySumOfOddIndexNumbers(int[] array)
    {
        CheckArrayEmpty(array);

        var odd = 0;
        for (var i = 0; i < array.Length; i++)
            if (i % 2 != 0)
                odd += array[i];
        return odd;
    }

    /// <summary>
    /// заполняем массив случайными числами, количество элеметнов передается при вызове
    /// </summary>
    /// <returns>array2</returns>
    public int[] CreateArrRandomNumbers(int count)
    {
        if (count == 0)
        {
            throw new Exception("введенное значение равно нулю, ошибка");
        }
        var random = new Random();
        var array2 = new int[count];
        for (var i = 0; i < array2.Length; i++) array2[i] = random.Next(0, 100);

        return array2;
    }

    /// <summary>
    /// Пользователь вводит 2 числа, проверить, есть ли одинаковые цифры.
    /// </summary>
    /// <param name="userEnterA"></param>
    /// <param name="userEnterB"></param>
    /// <returns>yes</returns>
    public string CompareIdenticalSymbolsOfValues(int userEnterA, int userEnterB)
    {
        var userEnterStringA = userEnterA.ToString();
        var userEnterStringB = userEnterB.ToString();
        var result = false;
        string answer;
        char c;
        char d;
        for (var i = 0; i != userEnterStringA.Length; i++)
        {
            c = userEnterStringA[i];

            for (var j = 0; j != userEnterStringB.Length; j++)
            {
                d = userEnterStringB[j];
                if (c == d)
                {
                    result = true;
                    break;  
                }
            }
        }

        if (result == true)
            answer = "да";
        else
            answer = "нет";

        return answer;
    }

    /// <summary>
    /// Отразить матрицу по второстепенной диагонали
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int[,] TranspositionOnSecondaryDiagonalOfDoubleArray(int a, int b)
    {
        if (a <= 0 || b <= 0) throw new Exception("Вы ввели отрицательный или нулевой размер массива, ошибка");

        var array = new int[a, b];
        for (var i = array.GetLength(0) - 1; i >= 0; i--)
        for (var j = array.GetLength(1) - 1; j >= 0; j--)
        {
            Console.Write("Количество строк, Y: " + (i + 1) + " Количество столбцов, X: " + (j + 1) + "  = ");
            array[i, j] = int.Parse(Console.ReadLine());
        }

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }

        return array;
    }

    /// <summary>
    /// Отразить матрицу по главной диагонали
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int[,] TranspositionOnMainDiagonalOfDoubleArray(int a, int b)
    {
        if (a <= 0 || b <= 0) throw new Exception("Вы ввели отрицательный или нулевой размер массива, ошибка");

        var array = new int[a, b];
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("Количество строк, Y: " + (i + 1) + " Количество столбцов, X: " + (j + 1) + " ");
                array[i, j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }

        return array;
    }

    /// <summary>
    /// Сортировка двойного массива по возрастанию
    /// </summary>
    /// <returns></returns>
    public int[,] DoubleArraySortToMax()
    {
        var array = new int[,]
        {
            { 212, 111, 323 },
            { 4243, 123, 535 }
        };
        var tmp = 0;
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            for (var k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    array[i, k] = tmp;
                    array[i, k] = array[i, j];
                    array[i, j] = tmp;
                }

                Console.Write($"{array[i, i]} ");
            }

            Console.WriteLine();
        }

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }

        return array;
    }

    /// <summary>
    /// Создает двумерный массив, заполнеят случайными числами
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int[,] CreateDoubleArrWithRandomNumbers(int a, int b)
    {
        var random = new Random();
        var array = new int[a, b];
        for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0, 10);

        return array;
    }

    /// <summary>
    /// Выводит в консоль двойной массив
    /// </summary>
    /// <param name="arr"></param>
    public void PrintDoubleArray(int[,] arr)
    {
        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++) Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Ищет наибольшего соседа среди чисел в массиве.
    /// </summary>
    /// <param name="arr"></param>
    public void PrintBiggestNeightborOfDoubleArray(int[,] arr)
    {
        for (var i = 0; i < arr.GetLength(0); i++)
        for (var j = 0; j < arr.GetLength(1); j++)
            if ((i == 0 || arr[i, j] > arr[i - 1, j])
                && (i >= arr.GetLength(0) - 1 || arr[i, j] > arr[i + 1, j])
                && (j == 0 || arr[i, j] > arr[i, j - 1])
                && (j >= arr.GetLength(1) - 1 || arr[i, j] > arr[i, j + 1]))
            {
                Console.Write("Наибольший элемент = " + arr[i, j] + ". С координатами i:" + (i + 1) + ", j:" + (j + 1) +
                              ";");
                Console.WriteLine();
            }
    }

    /// <summary>
    /// Выводит наибольшее число в двумерном массиве
    /// </summary>
    /// <param name="arr"></param>
    public void PrintMaxValueOfDoubleArray(int[,] arr)
    {
        var temp = 0;
        for (var i = 0; i < arr.GetLength(0); i++)
        for (var j = 0; j < arr.GetLength(1); j++)
            if (temp < arr[i, j])
                temp = arr[i, j];
        Console.WriteLine("Наибольшее значение = " + temp);
    }

    /// <summary>
    /// Выводит в консоль наименьшее число в двойном массиве
    /// </summary>
    /// <param name="arr"></param>
    public void PrintMinValueOfDoubleArray(int[,] arr)
    {
        var temp = arr[0, 0];
        for (var i = 0; i < arr.GetLength(0); i++)
        for (var j = 0; j < arr.GetLength(1); j++)
            if (temp > arr[i, j])
                temp = arr[i, j];
        Console.WriteLine("Наименьшее значение = " + temp);
    }

    /// <summary>
    /// Выводит сумму нечётных элементов двойного массива в консоль
    /// </summary>
    /// <param name="arr"></param>
    public void PrintSumOfOddElementsOfDoubleArray(int[,] arr)
    {
        var sumOfOdd = 0;
        for (var i = 0; i < arr.GetLength(0); i++)
        for (var j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] % 2 != 0)
                sumOfOdd += arr[i, j];
        Console.WriteLine("Сумма нечётных значений массива = " + sumOfOdd);
    }

    /// <summary>
    /// Выводит сумму чётных элементов двойного массива в консоль
    /// </summary>
    /// <param name="arr"></param>
    public void PrintSumOfEvenElementsOfDoubleArray(int[,] arr)
    {
        var sumOfEven = 0;
        for (var i = 0; i < arr.GetLength(0); i++)
        for (var j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] % 2 == 0)
                sumOfEven += arr[i, j];
        Console.WriteLine("Сумма четных значений массива = " + sumOfEven);
    }

    /// <summary>
    /// Выводит разность между суммой чётных и нечетных значений
    /// </summary>
    /// <param name="arr"></param>
    public void PrintDifferenceOfSumEvenAndOddAtDoubleArray(int[,] arr)
    {
        var sumOfOdd = 0;
        var sumOfEven = 0;
        for (var i = 0; i < arr.GetLength(0); i++)
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 != 0) sumOfOdd += arr[i, j];
            if (arr[i, j] % 2 == 0) sumOfEven += arr[i, j];
        }

        Console.WriteLine("Разность между суммой чётных и нечетных значений = " + (sumOfEven - sumOfOdd));
    }

    /// <summary>
    /// Складывает значения строки/столбца и выводит в консоль
    /// </summary>
    /// <param name="arr"></param>
    public void PrintCountOfLineAndColumnOfDoubleArray(int[,] arr)
    {
        var countOfLine = 0;
        var countOfColumn = 0;

        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                countOfLine += arr[i, j];
                countOfColumn += arr[j, i];
            }

            Console.WriteLine("сумма строки №" + i + 1 + " = " + countOfLine);
            Console.WriteLine("сумма столбца №" + i + 1 + " = " + countOfColumn);

            countOfLine = 0;
            countOfColumn = 0;
        }
    }
    
    
    

}