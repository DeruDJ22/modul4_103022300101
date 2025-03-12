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
            Console.WriteLine("\n=================================");
            fanLaptop kipas = new fanLaptop();

            kipas.getStatusKipas();
            string input = "";
            while (input != "keluar")
            {
                Console.WriteLine("Perintah kipas (modeDown, modeUp, turboShortcut) ");
                input = Console.ReadLine();
                if (Enum.TryParse(input, out mode trigger))
                {
                     kipas.ubahMode(trigger);
                    kipas.getStatusKipas();
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid");
                }
            }
            Console.WriteLine("\n=================================");
        }
    }
}
