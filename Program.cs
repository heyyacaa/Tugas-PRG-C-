using System;
using TheHarvest.Models;
using TheHarvest.Services;

namespace TheHarvest
{
    class Program
    {
        static void Main()
        {
            var cheese = new Cheesecake("Cheesecake", 50000, 20);
            var brownies = new ChocolateBrownies("Chocolate Brownies", 45000, 15);
            var cup = new Cupcake("Cupcake", 25000, 30);

            var tempat = new TheHarvestCake();
            tempat.TambahMenu(cheese);
            tempat.TambahMenu(brownies);
            tempat.TambahMenu(cup);

            tempat.MenampilkanMenu();
            tempat.MenampilkanMenu(true);

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}