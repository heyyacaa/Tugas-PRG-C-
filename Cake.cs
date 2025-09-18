using System;

namespace TheHarvestCake.Models
{
    public class Cake
    {
        private string nama;
        private int harga;
        private int stok;

        public Cake(string nama, int harga, int stok = 0)
        {
            this.nama = nama;
            this.harga = harga;
            this.stok = stok;
        }

        public string Nama
        {
            get => nama;
            set => nama = value;
        }

        public int Harga
        {
            get => harga;
            set { if (value >= 0) harga = value; }
        }

        public int Stok
        {
            get => stok;
            set { if (value >= 0) stok = value; }
        }

        public virtual void MenampilkanInfo()
        {
            Console.WriteLine($"Nama Kue : {Nama}, Harga: Rp.{Harga}, Stok: {Stok} pcs");
        }
    }
}
