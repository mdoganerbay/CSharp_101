internal class Program
{
    private static void Main(string[] args)
    {
        int sayi;
        Console.WriteLine("Lütfen bir sayı giriniz : ");
        sayi = Convert.ToInt32(Console.ReadLine());

        while (sayi != 1)
        {
            if (sayi > 0)
            {
                sayi -= 5;
                if (sayi < 0 || sayi == 0)
                {
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Girdiğiniz sayidan daha fazla 5 çıkartamıyorum.\n Çünkü negatif sayı oldu.");
                    break;
                }
                Console.WriteLine("Sonuç : {0} ", sayi);
            }
            else
            {
                Console.WriteLine("NEGETİF SAYİ GİRDİNİZ.. ");
                break;
            }
        }


    }
}