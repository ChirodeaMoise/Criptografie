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
            criptat = Criptare(text);
        }

        public string Criptare(string text)
        {
            string criptat = "";
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
                criptat += c;
            }
            return criptat;
        }

        public string Decriptare(string text)
        {
            string decriptat = "";
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
                decriptat += c;
            }
            return decriptat;
        }
    }
}
