internal class Program
{
    private static void Main(string[] args)
    {
        int sayi;
        Console.WriteLine("Lütfen 1-10 arasında bir sayı giriniz : ");
        sayi = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < sayi; i++)
        {
            for (int j = 0; j < sayi; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}