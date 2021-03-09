using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptAndDecryptFile
{
    class Program
    {
        public static string Encrypt(string var, int key)
        {
            string output = string.Empty;

            foreach(char ch in var)
            {
                output += (ch, key);
            }
            return output;
        }
        public static string Decrypt(string var, int key)
        {
            return Encrypt(var, 26 - key);
        }
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char hurufBesar = char.IsUpper(ch) ? 'A' : 'a';
            return (char)(((ch + key) - hurufBesar % 26 + hurufBesar));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tuliskan sebuah kalimat yang anda inginkan: ");
            string input = Console.ReadLine();

            Console.WriteLine("\n");
            Console.Write("Masukkan kunci: ");
            int kunci = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.Write("Data telah dienkripsi dengan kode: ");
            string kode = Encrypt(input, kunci);
            Console.WriteLine(kode);

            Console.Write("\n");
            Console.Write("Data telah didekripsi / dikembalikan dengan kalimat: ");
            string reverse = Decrypt(kode, kunci);
            Console.WriteLine(reverse);
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
