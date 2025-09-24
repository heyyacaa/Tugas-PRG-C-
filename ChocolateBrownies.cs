using System;

namespace TheHarvest.Models
{
    public class ChocolateBrownies : Cake
    {
        public ChocolateBrownies(string nama, int harga, int stok = 0)
            : base(nama, harga, stok) { }

        public override void MenampilkanInfo()
        {
            Console.WriteLine($"[Brownies] Nama: {Nama}, Harga: Rp.{Harga}, Stok: {Stok} pcs");
        }
    }
}
