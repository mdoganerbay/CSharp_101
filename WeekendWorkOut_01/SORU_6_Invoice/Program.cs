internal class Program
{
    private static void Main(string[] args)
    {
        double tutar = 0;
        double sale;

        Console.WriteLine("Lütfen alışveriş tutarını giriniz : ");

        Console.WriteLine("---------------------------------");
        tutar = Convert.ToInt32(Console.ReadLine());

        if (tutar > 0 && tutar <= 200)
        {
            sale = tutar * 0.10;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Alışveriş indirim miktarı: {0} ", sale);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Toplam ödeyeceğiniz %10 indirimli tutar : {0}", tutar * 0.9);
        }
        else if (tutar > 200 && tutar < 400)
        {
            sale = tutar * 0.15;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Alışveriş indirim miktarı: {0} ", sale);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Toplam ödeyeceğiniz %15 indirimli tutar : {0}", tutar * 0.85);
        }
        else if (tutar > 400)
        {
            sale = tutar * 0.20;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Alışveriş indirim miktarı: {0} ", sale);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Toplam ödeyeceğiniz %20 indirimli tutar : {0}", tutar * 0.80);
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Lütfen geçerli bir tutar giriniz!!!!! ");
        }
    }
}