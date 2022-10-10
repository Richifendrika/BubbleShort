using System;

namespace Buble2
{
    class Program
    {
        // Deklarasi array int dengan ukuran 30
        private int[] a = new int[30];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                // Method untuk mengisi banyak data didalam elemen array
                Console.Write("Masukan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 30)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 30 elemen.\n");
            }
            // fungsi untuk menjalankan banyak data
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        // fungsi / method untuk menampilkan
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int RF = 0; RF < n; RF++)
            {
                Console.WriteLine(a[RF]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                // Pada pass i,bandingkan n - i elemen pertama dengan elemen
                for (int RF = 0; RF < n - i; RF++)
                {
                    if (a[RF] > a[RF + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[RF];
                        a[RF] = a[RF + 1];
                        a[RF + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            Program mylist = new Program();

            // Pemanggilan funsi untuk menerima elemen array
            mylist.read();

            // Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();

            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
            Console.Read();
        }
    }
}