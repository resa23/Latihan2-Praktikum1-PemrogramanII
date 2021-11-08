using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204053
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("MENU PERSEGI PANJANG\n");
            Console.Write("1. Hitung Luas\n");
            Console.Write("2. Hitung Keliling\n");
            Console.Write("3. Hitung Panjang Diagonal\n");

            Console.Write("\nMenu Pilihan: ");

            int menu = Convert.ToInt16(Console.ReadLine());

            if (menu == 1)
            {
                int P, L, Luas;

                Console.WriteLine("\nLUAS PERSEGI PANJANG");

                Console.Write("Masukkan Panjangnya: ");
                P = Convert.ToInt16(Console.ReadLine());

                Console.Write("Masukkan Lebarnya: ");
                L = Convert.ToInt16(Console.ReadLine());

                Luas = P * L;

                Console.Write("Luas Persegi Panjang adalah = " + Luas);

                Console.ReadKey();
            }
            else if (menu == 2)
            {
                int P, L, Keliling;

               Console.WriteLine("\nKELILING PERSEGI PANJANG");

                Console.Write("Masukkan Panjangnya: ");
                P = Convert.ToInt16(Console.ReadLine());

                Console.Write("Masukkan Lebarnya: ");
                L = Convert.ToInt16(Console.ReadLine());

                Keliling = 2 * P + L;

                Console.Write("Luas Persegi Panjang adalah = " + Keliling);

                Console.ReadKey();
            }
            else if (menu == 3)
            {
                int P, L, PjgDiagonal;

                Console.WriteLine("\nPANJANG DIAGONAL PERSEGI PANJANG");

                Console.Write("Masukkan Panjangnya: ");
                P = Convert.ToInt16(Console.ReadLine());

                Console.Write("Masukkan Lebarnya: ");
                L = Convert.ToInt16(Console.ReadLine());

                PjgDiagonal = ( P * P) + ( L * L );

                Console.Write("Panjang Diagonal Persegi Panjang adalah = " + PjgDiagonal);

                Console.ReadKey();
            }
        }
    }
}
