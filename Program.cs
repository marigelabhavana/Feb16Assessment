// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Feb16Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Product> products = new SortedList<int, Product>();

            products.Add(1, new Product("Dewy Skin Primer      ", 10.99, "DewyDaze   ", new DateTime(2023, 02, 14), new DateTime(2028, 02, 16)));
            products.Add(2, new Product("Radiant Glow Serum    ", 20.99, "GlamourGlow", new DateTime(2022, 10, 23), new DateTime(2027, 03, 19)));
            products.Add(3, new Product("Hydrating Facial Mist ", 30.99, "PureGlow   ", new DateTime(2018, 08, 27), new DateTime(2023, 04, 26)));
            products.Add(4, new Product("Exfoliating Body Scrub", 40.99, "AuraLux    ", new DateTime(2016, 05, 12), new DateTime(2024, 05, 04)));
            products.Add(5, new Product("Nourishing Hair Mask  ", 50.99, "SilkBeauty ", new DateTime(2020, 11, 08), new DateTime(2025, 06, 03)));

            Console.WriteLine("Index Key |          PName         | Price |    Brand    |    MfDate  |   ExpDate  |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key, -9} | {product.Value.PName} | {product.Value.PPrice,-5} | {product.Value.PBrand,-5} | {product.Value.ManufacturingDate.ToString("yyyy-MM-dd"),-10} | {product.Value.ExpiryDate.ToString("yyyy-MM-dd"),-10} |");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }

    
}