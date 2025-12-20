using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throwException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
================= TUGAS: THROW & EXCEPTION =================

Tujuan:
- Melatih penggunaan throw
- Memahami alur try → catch
- Menangani error buatan sendiri

Instruksi:
1. Minta user input UMUR
2. Jika umur < 0
   - lempar exception sendiri menggunakan:
     throw new Exception("Umur tidak valid");
3. Tangkap exception tersebut
4. Tampilkan pesan error dari exception
5. Program tidak boleh crash

Aturan:
- WAJIB pakai try
- WAJIB pakai catch (Exception e)
- WAJIB pakai throw
- JANGAN langsung print pesan tanpa exception

============================================================
*/
            int umur = 0;
            try
            {
                Console.Write("Input Umur : ");
                umur = Convert.ToInt32(Console.ReadLine());
                if (umur <= 0)
                    throw new ArgumentOutOfRangeException();
                Console.WriteLine("Umur anda adalah : " + umur);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hanya menerima input berupa angka");
            }
            
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Input harus diatas angka 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
