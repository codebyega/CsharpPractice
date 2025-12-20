using System;

namespace KonversiSuhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suhuC = 0;
            double suhuF = 0;
            double suhuR = 0;
            double suhuK = 0;

            Console.WriteLine("== Konversi Suhu Simpel ==");
            Console.WriteLine("Pilih Skala Termometer Yang Anda Ingin Ubah");
            Console.WriteLine("1.Celcius\n2.Reamur\n3.Fahrenheit\n4.Kelvin");
            string opsi = Console.ReadLine();

            double input;
            bool parsed;

            switch (opsi)
            {
                case "1":
                    Console.Write("Silahkan input suhunya (C) : ");
                    parsed = double.TryParse(Console.ReadLine(), out input);
                    if (!parsed) { Console.WriteLine("Input tidak valid."); return; }
                    suhuC = input;
                    // From Celsius
                    suhuF = suhuC * 9.0 / 5.0 + 32.0;
                    suhuR = suhuC * 4.0 / 5.0;
                    suhuK = suhuC + 273.15;
                    break;

                case "2":
                    Console.Write("Silahkan input suhunya (R) : ");
                    parsed = double.TryParse(Console.ReadLine(), out input);
                    if (!parsed) { Console.WriteLine("Input tidak valid."); return; }
                    suhuR = input;
                    // From Reamur
                    suhuC = suhuR * 5.0 / 4.0;
                    suhuF = suhuC * 9.0 / 5.0 + 32.0;
                    suhuK = suhuC + 273.15;
                    break;

                case "3":
                    Console.Write("Silahkan input suhunya (F) : ");
                    parsed = double.TryParse(Console.ReadLine(), out input);
                    if (!parsed) { Console.WriteLine("Input tidak valid."); return; }
                    suhuF = input;
                    // From Fahrenheit
                    suhuC = (suhuF - 32.0) * 5.0 / 9.0;
                    suhuR = suhuC * 4.0 / 5.0;
                    suhuK = suhuC + 273.15;
                    break;

                case "4":
                    Console.Write("Silahkan input suhunya (K) : ");
                    parsed = double.TryParse(Console.ReadLine(), out input);
                    if (!parsed) { Console.WriteLine("Input tidak valid."); return; }
                    suhuK = input;
                    // From Kelvin
                    suhuC = suhuK - 273.15;
                    suhuF = suhuC * 9.0 / 5.0 + 32.0;
                    suhuR = suhuC * 4.0 / 5.0;
                    break;

                default:
                    Console.WriteLine("Silahkan input dalam bentuk angka (1,2,3,4)");
                    Continue;
            }
            Console.Clear();

            Console.WriteLine($"Hasil Konversi : \n{suhuC:F2} Celcius\n{suhuR:F2} Reamur\n{suhuK:F2} Kelvin\n{suhuF:F2} Fahrenheit");
        }
    }
}
