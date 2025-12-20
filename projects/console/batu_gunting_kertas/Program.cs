using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace batu_gunting_kertas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;

            while (playagain)
            {
                Console.WriteLine("=== Selamat Datang di Game Batu Gunting Kertas! ===");
                string playerChoice = getPlayerChoice();
                string computerChoice = getComputerChoice(random);

                Console.WriteLine($"Pilihan kamu : {playerChoice}");
                Console.WriteLine($"Pilihan Komputer : {computerChoice}");

                Console.WriteLine(getResult(playerChoice, computerChoice));

                Console.Write("Mau Main Lagi? Y/N :");
                playagain = Console.ReadLine().Trim().ToUpper() == "Y";
                Console.Clear();

            }
            Console.WriteLine("Terima Kasih Sudah Bermain");
        }

        //======================= METHOD ========================

        static string getPlayerChoice()
        {
            while (true)
            {
                Console.WriteLine("Input pilihan anda: ROCK/PAPER/SCISSORS");
                string input = Console.ReadLine().Trim().ToUpper();
                if (input == "ROCK" || input == "PAPER" || input == "SCISSORS")
                {
                    return input;
                }
                Console.Clear();
                Console.WriteLine("Tidak Valid");
            }
        }

        static string getComputerChoice(Random random)
        {
            string[] options = { "ROCK", "PAPER", "SCISSORS" };
            return options[random.Next(options.Length)];
        }

        static string getResult(string player, string computer)
        {
            if (player == computer){
                return "kamu SERI!";
            }

            if (player == "ROCK" && computer == "SCISSORS"||
                player == "PAPER" && computer == "ROCK"||
                player == "SCISSORS" && computer == "PAPER")
            {
                return "YOU MENANG :)!";
            }

            return "YOU KALAH :(!";

        }

    }
}
