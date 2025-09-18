using System;

namespace TheHarvestCake.Models
{
    public class Cupcake : Cake
    {
        public Cupcake(string nama, int harga, int stok = 0)
            : base(nama, harga, stok) { }

        public override void MenampilkanInfo()
        {
            Console.WriteLine($"[Cupcake] Nama: {Nama}, Harga: Rp.{Harga}, Stok: {Stok} pcs");
        }
    }
}
