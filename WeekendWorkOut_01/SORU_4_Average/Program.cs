internal class Program
{
    private static void Main(string[] args)
    {
        double total = 0;
        double count = 0;
        double average = 0;
        while (true)
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                break;
            }
            total += sayi;
            count++;
        }
        average = total / count;
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("Girdiğiniz sayıların ortalaması : {0}\n\t\t\t Toplam : {1}\n\t\t\t Sayac  :  {2}", average, total, count);
        Console.WriteLine("------------------------------------------------------------------------------");
    }
}