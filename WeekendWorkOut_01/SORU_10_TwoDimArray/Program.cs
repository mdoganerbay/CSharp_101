internal class Program
{
    private static void Main(string[] args)
    {
        int[,] dizi = new int[3, 4]
                       {
          {1,2,3,4},
          {5,6,7,8},
          {9,10,11,12},
                       };

        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for (int j = 0; j < dizi.GetLength(1); j++)
            {
                dizi[i, j] *= 2;

                Console.Write(dizi[i, j]);
            }
            Console.WriteLine("");
        }
    }
}