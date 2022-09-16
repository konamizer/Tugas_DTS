using System;

namespace Tugas_DTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Display();

        }
        void Display()
        {
            int menu, hadir;
            string nama, jenis="",nip, keterangan="";
            
            Console.WriteLine("=====kantor X ======");
            Console.WriteLine("=====absensi karyawan======");
            Console.Write("Masukkan NIP :");
            nip = Console.ReadLine();
            Console.Write("Masukkan nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("List divisi :    ");
            string[] kode = { "1.  junior programer", "2.  senior programer", "3.  manager"};
            foreach (string i in kode)
            {
                Console.WriteLine(i);
            }
            Console.Write("kode divisi (1/2/3): ");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    jenis = "junior programer";
                    break;
                case 2:
                    jenis = "senior programer";
                    break;

                case 3:
                    jenis = "manager";
                    break;

                default:
                    Console.WriteLine("Inputan Anda Salah, masukkan angka 1-3");
                    break;

            }
            Console.Write("kode absensi (0/1)");
            hadir = int.Parse(Console.ReadLine());

            if (hadir != 0)
            {
                keterangan = "Hadir";
            }
            else
            {
                keterangan = "absen";
            }
            Console.WriteLine("===============");
            Console.WriteLine("Nip :" + nip);
            Console.WriteLine("Nama :" + nama);
            Console.WriteLine("Divisi :" + jenis);
            Console.WriteLine("keterangan :" + keterangan);
        }
    }
}
