namespace methods.Classes;

public class Functions
{
    public double HalfDivFunction(double y)
    {
        // y = 5*x+6; найти х
        // Console.WriteLine("введите число Y");
        // double y = Convert.ToDouble(Console.ReadLine());
        double left = 0;
        double right = y;
        double x = (y - 6) / 5;
        double middle = 0;

        while (!(x == (y-6)/5))
        {
            middle = (left + right) / 2;

            if (middle > x)
            {
                right = middle;
            }
            else
            {
                left = middle;
            }
        }

        return x;
        Console.WriteLine(x);
        Console.ReadLine();
    }

    public int[,] ConvertStringToInt(string[,] arr)
    {
        int[,] resultArray = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                resultArray[i, j] = Convert.ToInt32(arr[i, j]);
            }
        }
        return resultArray;
    }

}