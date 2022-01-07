using System;

namespace Laborator_4._Substitutii_polialfabetice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "attackatdawn";
            string text2 = "hide the gold in the tree stump";
            string text3 = "heilhitler";

            Console.WriteLine("Vingenere encryption: " + VingenereEncryption.I.Encrypt(text1));
            Console.WriteLine("Vingenere decryption: " + VingenereEncryption.I.Decrypt(VingenereEncryption.I.Encrypt(text1)));
            Console.WriteLine();

            Console.WriteLine("Playfair encryption:  " + PlayfairEncryption.I.Encrypt(text2));
            Console.WriteLine("Playfair decryption:  " + PlayfairEncryption.I.Decrypt(PlayfairEncryption.I.Encrypt(text2)));
            Console.WriteLine();

            Console.WriteLine("Jefferson encryption: " + JeffersonEncryption.I.Encrypt(text3));
            Console.WriteLine("Jefferson decryption: " + JeffersonEncryption.I.Decrypt(JeffersonEncryption.I.Encrypt(text3)));
            JeffersonEncryption.I.Break(JeffersonEncryption.I.Encrypt(text3));
        }
    }
}
