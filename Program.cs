using System;

public class Test1
{
    public static void Main(string[] args)
    {
        Console.Write("Jumlah pohon : ");
        
        // --- PENGATURAN ---
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int jumlahPohon))
        {
            Console.WriteLine("Input tidak valid. Menggunakan jumlah pohon default: 1");
            jumlahPohon = 1;
        }

        int tinggi = 5;       // Tinggi bagian daun pohon (piramida)
        int tinggiBatang = 3; // Tinggi batang pohon
        
        
        for (int p = 1; p <= jumlahPohon; p++)
        {
            // BAGIAN DAUN POHON
            for (int i = 1; i <= tinggi; i++)
            { 
                // 1. Mencetak spasi di awal setiap baris
                for (int spasi = 1; spasi <= tinggi - i; spasi++)
                {
                    Console.Write(" ");
                }

                // 2. Mencetak bintang dengan spasi
                for (int bintang = 1; bintang <= i; bintang++)
                { 
                    Console.Write("* ");
                }

                // Pindah ke baris berikutnya
                Console.WriteLine();
            }


            // BAGIAN BATANG POHON 
            int spasiAwalBatang = tinggi - 1; 
            for (int b = 1; b <= tinggiBatang; b++)
            {
                // Cetak spasi awal untuk menengahkan batang
                for (int spasi = 1; spasi <= spasiAwalBatang; spasi++)
                {
                    Console.Write(" ");
                }
                
                // Cetak Batang
                Console.WriteLine("*"); 
            }
            Console.WriteLine(" "); // Spasi antar pohon
        }


        Console.WriteLine("WOHOOOOOO DONE BROOOO!");
    }
}