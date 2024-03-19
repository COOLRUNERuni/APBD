// See https://aka.ms/new-console-template for more information

class MyClass
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
        Console.WriteLine(Avg(arr));
    }

    public static int Avg(int[] a)
    {
        int Avg = 0;
        for (int i = 0; i < a.Length; i++)
        {
            Avg += a[i] / a.Length;
        }
        return Avg;
    }
    
    public static int Max(int[] a)
    {
        int max = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        return max;
    }
}