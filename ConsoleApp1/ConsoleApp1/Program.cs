// See https://aka.ms/new-console-template for more information

class MyClass
{
    public static void main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
    }

    public static int Avg(int[] a)
    {
        int avg = 0;
        for (int i = 0; i < a.Length; i++)
        {
            avg += a[i] / a.Length;
        }
        return avg;
    }
}