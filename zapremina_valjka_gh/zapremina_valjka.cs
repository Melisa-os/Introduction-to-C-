using System;

class Program
{
    static void Main()
    {

        const double Pi = 3.14;


        double poluprecnik = 10;
        double visina = 50;


        double zapremina = Pi * Math.Pow(poluprecnik, 2) * visina;


        Console.WriteLine("Zapremina valjka sa poluprečnikom {0} i visinom {1} je {2}.", poluprecnik, visina, zapremina);
    }
}

