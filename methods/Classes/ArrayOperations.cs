namespace methods.Classes;

public class ArrayOperations
{
    public int ArrayMax(int[] array)
    {
        //Находим наибольшее число в массиве
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }
    public int ArrayMin(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }
    public int ArrayMinIndex(int[] array)
    {
        int min = array[0];
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                minIndex = i;
            }
        }
        return minIndex;
    }
    public int ArrayMaxIndex(int[] array)
    {
        //Находим индекс у самого большого числа массива
        int max = array[0];
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    
    public int[] ArrayReverse(int[] array)
    {
        //Сделать реверс массива (массив в обратном направлении)
        int[] arrayReverse = new int[array.Length];
        int temp = array.Length - 1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            arrayReverse[temp] = array[i];
            temp--;
        }
        return arrayReverse;
    }
    public int[] ArraySortToMaxBubble(int[] array)
    {
        //Сортировка массива по возрастанию методом пузырька


        // int[] array = new int[] { 3, 8, 1, 5,11 };
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int k = i + 1; k < array.Length; k++)
            {
                if (array[i] > array[k])
                {
                    temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;

                }

            }
            // Console.WriteLine(array[i]);
        }

        return array;
        Console.ReadLine();
    }
    
    public int[] ArraySortToMinBubble(int[] array)
    {
        //Сортировка массива по убыванию методом пузырька


        // int[] array = new int[] { 10, 11, 5, 23, 12 };
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int k = i + 1; k < array.Length; k++)
            {
                if (array[i] < array[k])
                {
                    temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }

            }
            // Console.WriteLine(array[i]);
        }

        return array;
        Console.ReadLine();
    }
    
    public int ArrayFindSummOfOdd(int[] array)
    {
        //Посчитать количество нечетных элементов массива
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                counter++;
            }
        }
        return counter;
    }
    
    public int ArraySummOfOddIndexNumbers(int[] array)
    {
        //Посчитать сумму элементов массива с нечетными индексами
        int odd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                odd += array[i];
            }
        }
        return odd;
    }
    
    public int[] CreateArrRandomNumbers()
    {
        //заполняем массив случайными числами

        // int[] array = new int[10];
        // for (int i = 0; i < array.Length; i++)
        // {
        //     array[i] = i * i;
        //     Console.Write(array[i] + " ");
        // }
        // Console.ReadLine();
        //
        //заполняем массив случайными числами методом Random

        Random random = new Random();
        int[] array2 = new int[10];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = random.Next(0, 100);
            // Console.Write(array2[i] + " ");
        }

        return array2;
    }
    public string Compare(int userEnterA, int userEnterB)
    {
        string userEnterStringA = userEnterA.ToString();
        string userEnterStringB = userEnterB.ToString();
        // Пользователь вводит 2 числа, проверить, есть ли одинаковые числа.
        string yes = "да";
        string no = "нет";
        char c;
        char d;
        for (int i = 0; i != userEnterStringA.Length; i++)
        {
            c = userEnterStringA[i];

            for (int j = 0; j != userEnterStringB.Length; j++)
            {
                d = userEnterStringB[j];
                if (c == d)
                {
                    return yes;
                }
                else
                {
                    return no;
                }
            }
            // for (int j = 0; j != userEnterB.Length; j++)
            // {
            //     d = userEnterB[j];
            //     if (c != d)
            //     {
            //         Console.WriteLine("да");
            //         return no;
            //     }
            // }
        }

        return yes;
    }

    public int[,] DoubleArrayTranspositionOnSecondaryDiagonal(int a, int b)
    {
        
        if (a <= 0 || b <= 0)
        {
            throw new Exception("Вы ввели отрицательный или нулевой размер массива, ошибка");
        }
        
        int[,] array = new int[a, b];
        for (int i = array.GetLength(0)-1; i >= 0 ; i--)
        {
            for (int j = array.GetLength(1)-1; j >= 0 ; j--)
            {
                Console.Write("Количество строк, Y: " + (i + 1) + " Количество столбцов, X: " + (j + 1)+ "  = "  );
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < array.GetLength(0) ; i++)
        {
            for (int j = 0; j < array.GetLength(1) ; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        return array;

    }
    
    public int[,] DoubleArrayTranspositionOnMainDiagonal(int a, int b)
    {
        
        if (a <= 0 || b <= 0)
        {
            throw new Exception("Вы ввели отрицательный или нулевой размер массива, ошибка");
        }
        
        int[,] array = new int[a, b];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("Количество строк, Y: " + (i + 1) + " Количество столбцов, X: " + (j + 1)+ " " );
                array[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

        }
        
        for (int i = 0; i < array.GetLength(0) ; i++)
        {
            for (int j = 0; j < array.GetLength(1) ; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        return array;

    }
    
    public int[,] DoubleArraySortToMax()
    {
        
        
        int[,] array = new int[,]
        {
            {212,111,323},
            {4243,123,535}
        };
        int tmp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    
                    if (array[i,j] > array[i,k])
                    {
                        array[i, k] = tmp;
                        array[i, k] = array[i, j];
                        array[i, j] = tmp;
                    }
                
                    Console.Write($"{array[i, i]} ");
                }

            }
            Console.WriteLine();

        }
        
        for (int i = 0; i < array.GetLength(0) ; i++)
        {
            for (int j = 0; j < array.GetLength(1) ; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        return array;

    }
    
    public int[,] CreateDoubleArrWithRandomNumbers(int a, int b)
    {

        
        //заполняем массив случайными числами методом Random

        Random random = new Random();
        int[,] array = new int[a,b];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = random.Next(1, 100);
            }
        }

        return array;
    }
    public void PrintDoubleArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+ " ");
            }
            Console.WriteLine();
        }
    }

    public void PrintBiggestNeightborOfDoubleArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if ((i == 0 || arr[i, j] > arr[i - 1, j]) 
                    && (i >= arr.GetLength(0)-1 || arr[i, j] > arr[i+1,j]) 
                    && (j == 0 || arr[i, j] > arr[i,j-1])  
                    && (j >= arr.GetLength(1)-1 || arr[i, j] > arr[i,j+1]) )
                {
                    Console.Write("Наибольший элемент = " + arr[i,j] + ". С координатами i:" + (i + 1) + ", j:" + (j + 1)+ ";");
                    Console.WriteLine();
                }
            }
        }
    }
    
    public void PrintMaxValueOfDoubleArray(int[,] arr)
    {
        int temp = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (temp < arr[i, j])
                {
                    temp = arr[i, j];
                }
            }
        }
        Console.WriteLine("Наибольшее значение = "+ temp);
    }
    
    public void PrintMinValueOfDoubleArray(int[,] arr)
    {
        int temp = arr[0,0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (temp > arr[i, j])
                {
                    temp = arr[i, j];
                }
            }
        }
        Console.WriteLine("Наименьшее значение = "+ temp);
    }

}