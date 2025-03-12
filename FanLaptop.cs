using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300101
{
        public enum fan { Quiet, Turbo, Performance, Balanced } //Enum kondisi kipas
        public enum mode { modeDown, modeUp, turboShortcut } //Enum mode kipas

        class fanLaptop
        {
            private fan kipas; //Membuat variabel kipas dengan tipe data fan
            public fanLaptop() //Konstruktor buat ngatur kipas menjadi quet secar default
            {
                kipas  = fan.Quiet;
            }
            public void ubahMode(mode opsi)
            {
                switch (kipas) //Switch case kondis kegiatan kipas
                {
                    case fan.Quiet: //Kasus saat case kipas quiet
                        if (opsi == mode.turboShortcut) //Kondisi bila memilih ops turboShortcut
                        {
                            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                            kipas = fan.Turbo; //Mengubah kipas menjadi turbo
                        }
                        else if (opsi == mode.modeUp) //Kondisi bila memilih opsi modeUp
                        {
                            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                            kipas = fan.Balanced; //Mengubah kipas menjadi balance
                        }
                        else
                        {
                            Console.WriteLine("Fan sudah berada di mode quiet");
                        }
                        break;
                    case fan.Balanced: //Kasus kipas di kondisi balance
                        if (opsi == mode.modeDown) //kondisi apabia memilih opsi modeDown
                        {
                            Console.WriteLine("Fan Balance berubah menjadi Quiet");
                            kipas = fan.Quiet; //mengubah kipas menjadi quiet
                        }
                        else if (opsi == mode.modeUp) //kondisi apabila memilih opsi modeUp
                        {
                            Console.WriteLine("Fan Balance berubah menjadi Performance");
                            kipas = fan.Performance; //mengubah kipas menjadi Performance
                        }
                        else
                        {
                            Console.WriteLine("Fan sudah berada di mode Balance");
                        }
                        break; 
                    case fan.Performance: //Kasus kipas di Performance
                        if (opsi == mode.modeUp) //kondis apabila memilih opsi modeUp
                        {
                            Console.WriteLine("Fan Performace berubah menjadi Turbo");
                            kipas = fan.Turbo; //mengubah kipas ke turbo
                        }
                        else if (opsi == mode.modeDown) //Konisi memilih opsi modeDown
                        {
                            Console.WriteLine("Fan Performance berubah menjadi Balance");
                            kipas = fan.Balanced; //mengubah kipas ke mode balance
                        }
                        else
                        {
                            Console.WriteLine("Fan sudah berada di mode Performance");
                        }
                        break;
                    case fan.Turbo: //Kasus kipas di mode turbo
                        if (opsi == mode.modeDown) //kondisi apabila memilih opsi mode down
                        {
                            Console.WriteLine("Fan Turbo berubah menjadi Performance");
                            kipas = fan.Performance; //kipas diubah menjadi Performance
                        }
                        else if (opsi == mode.turboShortcut) //kondisi apabila memilih opsi turboShortcut
                        {
                            Console.WriteLine("Fan Turbo sudah berbah menjadi Quiet");
                            kipas = fan.Quiet; //mengubah kipas ke mode quiet
                        }
                        else
                        {
                            Console.WriteLine("Fan sudah berada di mode Turbo");
                        }
                        break;
                    
                }
            }
            public void getStatusKipas() //Prosedur untuk melihat status kipas
            {
                Console.WriteLine("Kipas: " + kipas);
            }
        }
}
