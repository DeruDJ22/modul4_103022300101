using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300101
{
    internal class KodeProduk
    {
        //enum untuk daftar produk
        public enum Produk { Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera };

        //Metode untuk mendapatkan kode produk
        public static string getKodeProduk(Produk produk)
        {
            //Array berisi kode produk
            string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};
            return kodeProduk[(int)produk];//Mengembalikan nilai sesuai enum yang ada di parameter Produk
        }
    }
}
