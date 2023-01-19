namespace methods.Classes;

public class ValueOperations
{
    public int FindFibonachi(int n)
    {
        int fb1 = 1;
        int fb2 = 1;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            fb1 = fb2;
            fb2 = sum;
            sum = fb1 + fb2;
        }
        return sum;
    }

    public int Evklid(int a, int b)
    {
        
        //Найти наибольший общий делитель 2х чисел по алгоритму Евклида
        while (a != b)
        {
            if (b == 0 && a == 0)
            {
                throw new Exception("Одно из чисел равно 0, ошибка");
            }
            {
                
            }
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        return a;
    }

    public int FindOddValuesOfNumber(int userEnterValue)
    {
        // Console.WriteLine("Введите число");
        int b = 0;
        int count = 0;
        while (userEnterValue > 0)
        {
            b = userEnterValue % 10;
            if (b % 2 == 0)
            {
                userEnterValue = userEnterValue / 10;
            }
            else
            {
                userEnterValue = userEnterValue / 10;
                count++;
            }
        }
        return count;
    }

    public string SummOddAndEven(int n)
    // вывести количество чисел от 1 до N, сумма чётных которых должна быть больше суммы нечётных
    {
        int sum1 = 0;
        int sum2 = 0;
        int k;
        int temp = 0;
        string result = "";

        for (int i = 1; i < n; i++)
        {
            k = i;
            sum1 = 0;
            sum2 = 0;
            while (k > 0)
            {
                if (k % 2 == 0)
                {
                    sum1 += k % 10;
                    k /= 10;
                }
                else
                {
                    sum2 += k % 10;
                    k /= 10;
                }
            }

            if (sum1 > sum2)
            {
                temp = i;
                result += Convert.ToString(temp) + " ";
            }
        }
        return result;
    }

    public int FindMaxDivOfValue(int a)
    {
        //Находим максимальный делитель числа

        int b = a - 1;
        int temp = 0;

        for (int i = b; i > 0; i--)
        {
            if (a % i == 0)
            {
                temp = i;
                return temp;

            }

        }

        return temp;
        Console.ReadLine();
    }
    

    public int HalfDivisionValue(int a)
    {
        //Пользователь вводит целое положитиельное число, которое является кубом целого числа N, найти N методом половинного деления

        // Console.WriteLine("введите число A");
        // int a = int.Parse(Console.ReadLine());
        int n = a * a * a;
        int leftBorder = 0;
        int rightBorder = 300000;
        int middle = 0;
        int c = 0;

        while (c != n && c >= 0)
        {
            middle = (rightBorder + leftBorder) / 2;
            c = middle;

            if (middle > n)
            {
                rightBorder = middle;
            }
            else
            {
                leftBorder = middle;
            }
        }

        Console.WriteLine(c);
        return c;

        Console.ReadLine();
    }
    
    public int[] RevertValue(int value)
    {
        // Перевернуть число задом наперед
        // int[] array = new int[value];

        string tmpString = value.ToString();
        int[] array = new int[tmpString.Length];
        for(int n = 0; n < tmpString.Length; ++n){ 
            array[n] = int.Parse(tmpString[n]+ "");
        }
        
        

        int[] arrayReverse = new int[array.Length];
        int temp = array.Length - 1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            arrayReverse[temp] = array[i];
            temp--;
            return array;
        }
        return array;
        
        
    }
    
    public int SummEvenOrSummOdd(int userEnterValue)
    {
        // вывести количество чисел от 1 до N, сумма чётных которых должна быть больше суммы нечётных
        // Console.WriteLine("Введите число");
        // int userEnterValue = int.Parse(Console.ReadLine());
        int b = 0;
        string count = "";
        int even = 0;
        int evenCount = 0;
        int odd = 0;
        int oddCount = 0;
        for (int i = 1; i <= userEnterValue; i++)
        {
            if (i % 2 == 0)
            {
                even += i;
                evenCount++;
            }
            else
            {
                odd += i;
                oddCount++;
            }
            count += $" {i}";
        }
        // Console.WriteLine(count);

        if (odd > even)
        {
            // Console.WriteLine($"Сумма нечётных чисел {odd}");
            // throw new Exception("Сумма нечётных чисел больше суммы чётных");
        }
        else
        {
            // Console.WriteLine($"Сумма чётных чисел {even}");
        }
        return evenCount;
        Console.WriteLine($"Чётные числа {evenCount}");
        Console.WriteLine($"Нечётные числа {oddCount}");
        Console.ReadLine();
    }
    





}
