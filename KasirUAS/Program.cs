using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirUAS
{
    /// <summary>
    /// syntax class sistem kasir untuk dimasukan pada main class
    /// </summary>
    /// <remarks>Class SistemKasir membuat operasi tampilan menu dan perhitungan kasir</remarks>
    public class SistemKasir
    {
        /// <summary>
        /// pendeklarasian variabel untuk data kasir
        /// </summary>
        
        public int pilih, a, b, c, d;
        public int Cappuchino, mocchachino, americcano, indomie;
        
        /// <summary>
        /// public void data membuat tampilan awal menu dan operasi perhitungan dalam kasir
        /// <param name="pilih">membaca input dari user</param>
        /// <param name="a">operasi perhitungan untuk menu Cappuchino</param>
        /// <param name="b">operasi perhitungan untuk menu Mocchachino</param>
        /// <param name="c">operasi perhitungan untuk menu Americano</param>
        /// <param name="d">operasi perhitungan untuk menu Indomie</param>
        /// </summary>
        public void data()
        {
            
            Console.WriteLine("");
            Console.WriteLine("MENU");
            Console.WriteLine("1. cappuchino             Rp. 15.000");
            Console.WriteLine("2. mocchachino            Rp. 15.000");
            Console.WriteLine("3. americcano             Rp. 10.000");
            Console.WriteLine("4. indomie                Rp. 8.000");
            Console.WriteLine("5. Selesai");
            Console.Write("pilihan (1/2/3/4/5) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //membuat switch
            switch (pilih)
            {
                //menghitung menu cappuchino
                case 1:
                    Console.WriteLine("Berapa cappuchino yang ingin anda beli ?");
                    Cappuchino = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Cappuchino + " jumlah yang di beli");
                    Console.WriteLine();
                    a = Cappuchino * 15000;
                    break;
                //menghitung menu Mocchachino
                case 2:
                    Console.WriteLine("Berapa mocchachino yang ingin anda beli ?");
                    mocchachino = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(mocchachino + " jumlah yang di beli");
                    Console.WriteLine();
                    b = mocchachino * 15000;
                    break;
                //menghitung menu americcano
                case 3:
                    Console.WriteLine("Berapa americcano yang ingin anda beli ?");
                    americcano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(americcano + " jumlah yang di beli");
                    Console.WriteLine();
                    c = americcano * 10000;
                    break;
                //menghitung menu indomie
                case 4:
                    Console.WriteLine("Berapa porsi indomie yang ingin anda beli ?");
                    indomie = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(indomie + " jumlah yang di beli");
                    Console.WriteLine();
                    d = indomie * 8000;
                    break;
                case 5:
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("pilihan salah satu");
                    Console.Read();
                    break;
            }
        }
    }
    /// <summary>
    /// main class dan pembuatan nota dari hasil perhitungan pada class SistemKasir
    /// pada main class terdapat syntax untuk pencetakan nota pada file txt
    /// </summary>
    class program
    {

        static void Main(string[] args)
        {
            SistemKasir x = new SistemKasir();
            string pembeli, kasir;
            string perulangan;

            Console.WriteLine("Selamat datang di senja cafe");
            Console.WriteLine("Silahkan pilih manakanan dan minuman yang ada di menu");
            Console.WriteLine("-----------------------------------------------------");
            do
            {
                do
                {
                    x.data();
                } while (x.pilih != 5);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Receipt:");
                Console.WriteLine($"{x.Cappuchino} cappuchino   \t= Rp. {x.a} ");
                Console.WriteLine($"{x.mocchachino} mocchachino \t= Rp. {x.b}");
                Console.WriteLine($"{x.americcano} americcano   \t= Rp. {x.c}");
                Console.WriteLine($"{x.indomie} indomie         \t= Rp. {x.d} ");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"                 \t\tTotal = {x.a + x.b + x.c + x.d}");
                Console.WriteLine(DateTime.Now);
                Console.Write("Nama Pembeli : ");
                pembeli = Console.ReadLine();
                Console.Write("Kasir : ");
                kasir = Console.ReadLine();

                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamWriter str = new StreamWriter(Path.Combine(path, $"NotaBelanja.txt"), append: true);
                str.WriteLine("--------------------------------------------------------");
                str.WriteLine("--------------------------------------------------------");
                str.WriteLine("Receipt:");
                str.WriteLine($"{x.Cappuchino} cappuchino    \t= Rp. {x.a} ");
                str.WriteLine($"{x.mocchachino} mocchachino  \t= Rp. {x.b}");
                str.WriteLine($"{x.americcano} americcano    \t= Rp. {x.c}");
                str.WriteLine($"{x.indomie} indomie           \t= Rp. {x.d} ");
                str.WriteLine("--------------------------------------------------------");
                str.WriteLine($"                 \t\tTotal = {x.a + x.b + x.c + x.d}");
                str.WriteLine(DateTime.Now);
                str.Write("Nama Pembeli : {0}", pembeli);
                str.Write("\tKasir : {0}", kasir);
                str.Close();

                perulangan = Console.ReadLine();
            }

            while (perulangan == "yes");
        }
    }

}
