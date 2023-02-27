internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1, sayi2;
        string islem;

        Console.WriteLine("Lütfen 1. sayı giriniz : ");
        sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen 2. sayı giriniz : ");
        sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1-Toplam için T veya t giriniz\n"
            + "2-Çıkarma için E veya e giriniz\n"
            + "3-Çarpma için Ç veya ç giriniz\n"
            + "4-Bölme için B veya b giriniz");
        islem = Console.ReadLine();

        switch (islem)
        {
            case "T":
            case "t":
                Console.WriteLine("Toplam :{0} ", sayi1 + sayi2);
                break;

            case "E":
            case "e":
                Console.WriteLine("Toplam :{0} ", sayi1 - sayi2);
                break;

            case "Ç":
            case "ç":
                Console.WriteLine("Toplam :{0} ", sayi1 * sayi2);
                break;

            case "B":
            case "b":

                if (sayi2 == 0)
                {
                    Console.WriteLine("lütfen sıfırdan büyük değer giriniz!!!!!");
                }
                else
                {
                    Console.WriteLine("Toplam :{0} ", sayi1 / sayi2);
                }
                break;

            default:
                Console.WriteLine("Lütfen geçerli bir işlem giriniz!!!!! ");
                break;

        }

    }
}