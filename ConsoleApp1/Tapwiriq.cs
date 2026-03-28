using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tapwiriq
    {
   public static void profile()
        {
            Console.WriteLine("adinizi daxil edin");
            string ad = Console.ReadLine(); 

            Console.WriteLine("soyadinizi daxil edin");
            string soyad = Console.ReadLine();

            Console.WriteLine("ata adinizi daxil edin");
            string ataadi = Console.ReadLine();


            Console.WriteLine("yasinizi daxil edin");
            string yas = Console.ReadLine();

            int yas1 = Convert.ToInt32(yas);
            
            Console.WriteLine($"/n---Isdifadeci karti---"); 
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Soyad: {soyad}");
            Console.WriteLine($"Yas: {yas1}");
            Console.WriteLine($"Ata adi: {ataadi}");




        }

    }
}
