internal class Program
{
    private static void Main(string[] args)
    {
        double salary = 8500;
        int year = 5;
        for (int i = 1; i <= year; i++)
        {
            salary *= 1.15;
            Console.WriteLine(i + ". yıl için maaaşınız : " + salary);
        }
    }
}