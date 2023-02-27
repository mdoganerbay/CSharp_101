internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 200);
        int count = 10;

        while (true)
        {
            if (count == 0)
            {
                Console.WriteLine("Üretilen random sayi : {0}", rastgeleSayi);
                Console.WriteLine("HAKKINIZ BİTTİ...!!!!!!");
                break;
            }
            Console.WriteLine("Lütfen 1-200 arası bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == rastgeleSayi)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("ÜRETİLEN DOĞRU SAYI : {0}", rastgeleSayi);
                Console.WriteLine("TEBRİKLER KAZADINIZ... !!!!");
                break;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("lütfen tekrar deneyiniz.....");
            }
            count--;
        }

        Console.ReadKey();
    }
}