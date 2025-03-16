// See https://aka.ms/new-console-template for more information
using System;
using Ilayda_namespace;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesap = new Hesaplama();
            int toplam = hesap.sayiToplam(16, 20);
            int carpim = hesap.sayiCarp(29, 20);

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Çarpım: " + carpim);
        }
    }
}
