namespace methods.Classes;

public class ValueOperations
{
    
    /// <summary>
    /// Служебный метод
    /// </summary>
    /// <param name="a"></param>
    /// <exception cref="Exception"></exception>
    public void CheckInputValue(int a)
    {
        if (a < 0) throw new Exception("вы ввели значение меньше 0, ошибка");
    }
    
    /// <summary>
    /// введенное число - индекс последовательности Фибоначчи
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int FindFibonachi(int n)
    {
        CheckInputValue(n);
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
            if (b <= 0 || a <= 0) throw new Exception("Одно из чисел меньше или равно 0, ошибка");

            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    }

    /// <summary>
    /// найти нечетные цифры в числе
    /// </summary>
    /// <param name="userEnterValue"></param>
    /// <returns></returns>
    public int FindOddValuesOfNumber(int userEnterValue)
    {
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

    /// <summary>
    /// вычисляет сумму четных и нечетных цифр числа, а затем сравнивает их.
    /// Если сумма четных цифр больше, то результатом является список чисел,
    /// для которых удовлетворяется указанное условие.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string SummOddAndEven(int n)
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

            if (sum1 > sum2)
            {
                temp = i;
                result += Convert.ToString(temp) + " ";
            }
        }
        return result;
    }

    /// <summary>
    /// ищет максимальный делитель числа
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public int FindMaxDivOfValue(int a)
    {
        CheckInputValue(a);
        int b = a - 1;
        int temp = 0;

        for (int i = b; i > 0; i--)
            if (a % i == 0)
            {
                temp = i;
                return temp;
            }

        return temp;
    }
    
    /// <summary>
    /// Пользователь вводит целое положитиельное число, которое является кубом целого числа N,
    /// найти N методом половинного деления
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public int HalfDivisionValue(int a)
    {
        CheckInputValue(a);
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
                rightBorder = middle;
            else
                leftBorder = middle;
        }
        Console.WriteLine(c);
        
        return c;
    }
    
    /// <summary>
    /// переворачивает число задом наперед
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public int[] RevertValue(int value)
    {
        string tmpString = value.ToString();
        int[] array = new int[tmpString.Length];
        for (int n = 0; n < tmpString.Length; ++n) array[n] = int.Parse(tmpString[n] + "");
        int[] arrayReverse = new int[array.Length];
        int temp = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            arrayReverse[temp] = array[i];
            temp++;
        }
        
        return arrayReverse;
    }
    
    /// <summary>
    /// выводит количество чисел от 1 до N, сумма чётных которых должна быть больше суммы нечётных
    /// </summary>
    /// <param name="userEnterValue"></param>
    /// <returns></returns>
    public int SumEvenOfValue(int userEnterValue)
    {
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
        
        return evenCount;
    }
    





}
