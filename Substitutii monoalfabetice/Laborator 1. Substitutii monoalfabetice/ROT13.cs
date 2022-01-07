using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class ROT13 : AlgoritmSimetric
    {

        public ROT13()
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
                    if (IntTrans(c) + 13 <= 26)
                        c += (char)13;
                    else
                        c -= (char)13;
                }
                encrypted += c;
            }
            return encrypted;
        }

        public string Decryption(string text)
        {
            string decrypted = "";
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (Char.IsLetter(c))
                {
                    if (IntTrans(c) - 13 > 0)
                        c -= (char)13;
                    else
                        c += (char)13;
                }
                decrypted += c;
            }
            return decrypted;
        }
    }
}
