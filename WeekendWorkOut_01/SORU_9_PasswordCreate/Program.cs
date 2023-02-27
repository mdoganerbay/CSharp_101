internal class Program
{
    private static void Main(string[] args)
    {
        int basamak = 0;
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Lütfen 1-10 arası bir sayı giriniz : ");
            Console.WriteLine("----------------------------------------------------------------------");
            basamak = Convert.ToInt32(Console.ReadLine());

            if (basamak > 10)
            {

                Console.WriteLine("Lütfen sınırlara uygun bir değer giriniz!!!!");
                continue;
            }
            else
            {
                int parola = random.Next((int)Math.Pow(10, basamak - 1), (int)(Math.Pow(10, basamak) - 1));
                Console.WriteLine(parola);
                Console.WriteLine("----------------------------------------------------------------------");
                break;
            }
        }
    }
}