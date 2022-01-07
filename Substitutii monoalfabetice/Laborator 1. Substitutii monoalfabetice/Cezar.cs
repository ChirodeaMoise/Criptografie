using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class Cezar : AlgoritmSimetric
    {
        public Cezar()
        {
            encrypted = Encryption(text);
        }

        public string Encryption(string text)
        {
            string encrypted = "";
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        if (c <= 'W')
                            c += (char)3;
                        else
                            c -= (char)23;
                    }
                    else
                        if (c <= 'w')
                        c += (char)3;
                    else
                        c -= (char)23;
                }
                encrypted += c;
            }
            return encrypted;
        }

        public string Decryption(string text)
        {
            string decryption = "";
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        if (c >= 'D')
                            c -= (char)3;
                        else
                            c += (char)23;
                    }
                    else
                        if (c >= 'd')
                        c -= (char)3;
                    else
                        c += (char)23;
                }
                decryption += c;
            }
            return decryption;
        }

    }
}
