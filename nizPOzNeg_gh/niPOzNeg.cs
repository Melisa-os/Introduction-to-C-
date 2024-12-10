using System;

class Program
{
    static void Main()
    {
        int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };
        int[] poziNiz = new int[array.Length];
        int[] negNiz = new int[array.Length];
        int pozIndeks = 0;
        int negIndeks = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                poziNiz[pozIndeks] = array[i];
                pozIndeks++;
            }
            else if (array[i] < 0)
            {
                negNiz[negIndeks] = array[i];
                negIndeks++;
            }
            
        }
        Console.WriteLine("Pozitivni brojevi:");
        for (int i = 0; i < pozIndeks; i++)
        {
            Console.Write(poziNiz[i] + " ");
        }

        Console.WriteLine("\nNegativni brojevi:");
        for (int i = 0; i < negIndeks; i++)
        {
            Console.Write(negNiz[i] + " ");
        }
    }
}