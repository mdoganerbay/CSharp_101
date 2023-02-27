internal class Program
{
    private static void Main(string[] args)
    {
        int sonuc = 0;

        for (int i = 1; i <= 10; i++)
        {

            for (int j = 1; j <= 10; j++)
            {
                sonuc = i * j;
                Console.WriteLine(i + " 'ler çarpım tablosu : {0} x {1} = {2}", i, j, sonuc);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\n");
        }
    }
}