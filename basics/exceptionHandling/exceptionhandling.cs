using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             ======== TUGAS OLEH CHATGPT ======
            Buat program C# dengan ketentuan:

            1. User input:
            - Angka A
            - Angka B

            2. Program menampilkan hasil A / B
                
            3. Tangani exception berikut:
            - Jika input bukan angka → tampilkan pesan khusus
            - Jika pembagian dengan nol → tampilkan pesan khusus
            - Jika error lain → tampilkan e.Message
            - Gunakan minimal 2 catch
            - Salah satu catch WAJIB pakai variabel exception (e)
            **/

            int a,b;

            try
            {
                Console.Write("Input A : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input B : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Angka ga bisa dibagi dengan 0");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Hanya menerima input berupa angka!");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
           Console.ReadKey();


        }
    }
}
