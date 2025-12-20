using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
==================== REAL CASE: REGISTRASI USER ====================

Konteks:
Lo lagi bikin sistem registrasi user sederhana (console app).

Aturan Bisnis:
1. User harus input:
   - Username
   - Umur
   - Password

2. Validasi yang WAJIB:
   - Username TIDAK boleh kosong
     → lempar ArgumentNullException
   - Umur harus di antara 13 dan 60
     → lempar ArgumentOutOfRangeException
   - Password minimal 8 karakter
     → lempar ArgumentException

3. Tangani exception berikut:
   - ArgumentNullException → tampilkan pesan khusus
   - ArgumentOutOfRangeException → tampilkan pesan khusus
   - ArgumentException → tampilkan pesan khusus
   - Exception lain → tampilkan e.Message

Aturan Teknis:
- WAJIB pakai try
- WAJIB pakai throw (minimal 3 throw)
- WAJIB pakai multiple catch
- WAJIB urutan: spesifik → umum
- DILARANG pakai catch kosong (catch { })

Output jika sukses:
"Registrasi berhasil"

===================================================================

Tugas:
- Tulis kode C# lo di bawah ini
- Jangan hapus komentar
- Jangan minta jawaban
- Kirim kodenya untuk direview

*/
            string username, password;
            int umur = 0;

            try
            {
                username = getusername();
                umur = getumur();
                password = getpassword();
                Console.WriteLine("Registrasi Berhasil!");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          

            
        }
       
        static string getusername()
        {
           
                Console.Write("Input Username : ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("username", "Username ga boleh kosong");
                }
                    return input;
           
        }
        static int getumur() 
        {
            Console.Write("Input umur : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 13 || input > 60)
            {
                throw new ArgumentOutOfRangeException("umur", "Umur harus di antara 13 dan 60");
            }
                return input;
        }

        static string getpassword()
        {
            Console.Write("input Password : ");
            string input = Console.ReadLine();

            if (input.Length < 8 || string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Password minimal 8 karakter dan ga boleh kosong", "password");
            }
                return input;
        }   
    }
}
