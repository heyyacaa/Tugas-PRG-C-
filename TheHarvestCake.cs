using System;
using TheHarvest.Models;

namespace TheHarvest.Services
{
    public class TheHarvestCake
    {
        private List<Cake> menu = new List<Cake>();

        public void TambahMenu(Cake c)
        {
            menu.Add(c);
        }


        public void MenampilkanMenu()
        {
            Console.WriteLine("--- The Harvest's Menu ---");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Nama} - Rp.{item.Harga} (Stok: {item.Stok})");
            }
        }

        public void MenampilkanMenu(bool detail)
        {
            Console.WriteLine("\n--- Detail Menu ---");
            foreach (var item in menu)
            {
                item.MenampilkanInfo();
            }
        }
    }
}