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
            criptat = Criptare(text, n);
        }

        private int PregatireN(int n)
        {
            while (n > 26)
            {
                n -= 26;
            }
            return n;
        }


        public string Criptare(string text, int n)
        {
            n = PregatireN(n);
            string criptat = "";
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
                criptat += c;
            }
            return criptat;
        }

        public string Decriptare(string text, int n)
        {
            n = PregatireN(n);
            string decriptat = "";
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
                decriptat += c;
            }
            return decriptat;
        }
    }
}
