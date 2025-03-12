using System;

namespace modul4_103022300101
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Produk");
            Console.WriteLine("=========================");
            Console.WriteLine("Produk\t |     Kode Prduk");
            Console.WriteLine("=========================");
            //Perulangan untuk menampilkan Produk dan kode poduk
            foreach (KodeProduk.Produk prdk in Enum.GetValues(typeof(KodeProduk.Produk)))
            {
                string namaProduk = prdk.ToString();
                Console.WriteLine($"{prdk,-13} |     {KodeProduk.getKodeProduk(prdk)}");
            }
        }
    }
}
