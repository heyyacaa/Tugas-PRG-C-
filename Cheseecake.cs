using System;

namespace TheHarvestCake.Models
{
    public class Cheesecake : Cake
    {
        public Cheesecake(string nama, int harga, int stok = 0)
            : base(nama, harga, stok) { }

        public override void MenampilkanInfo()
        {
            Console.WriteLine($"[Cheesecake] Nama: {Nama}, Harga: Rp.{Harga}, Stok: {Stok} pcs");
        }
    }
}
