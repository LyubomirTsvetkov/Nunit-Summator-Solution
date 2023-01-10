internal class Program
{
    private static void Main(string[] args)
    {
        long result = ConsoleApp1.Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
        if (result == 1)
        {
            Console.WriteLine("Test pass");
        }
        else
        {
            Console.WriteLine("Test fail");
        }

        int average = ConsoleApp1.Summator.Average(new int[] { 5, 10, 15 });
        if (average == 10)
        {
            Console.WriteLine("Test pass");
        }
        else
        {
            Console.WriteLine("Test fail");
        }
    }
}