using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class CezarGeneralizat : AlgoritmSimetric
    {
        public int n;
        public CezarGeneralizat()
        {
            n = int.Parse(Console.ReadLine());
            encrypted = Encryption(text, n);
        }

        private int PrepareN(int n)
        {
            while (n > 26)
            {
                n -= 26;
            }
            return n;
        }


        public string Encryption(string text, int n)
        {
            n = PrepareN(n);
            string encrypted = "";
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (Char.IsLetter(c))
                {
                    if (IntTrans(c) + n <= 26)
                        c += (char)n;
                    else
                        c -= (char)(26 - n);
                }
                encrypted += c;
            }
            return encrypted;
        }

        public string Decryption(string text, int n)
        {
            n = PrepareN(n);
            string decryption = "";
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (Char.IsLetter(c))
                {
                    if (IntTrans(c) - n > 0)
                        c -= (char)n;
                    else
                        c += (char)(26 - n);
                }
                decryption += c;
            }
            return decryption;
        }
    }
}
