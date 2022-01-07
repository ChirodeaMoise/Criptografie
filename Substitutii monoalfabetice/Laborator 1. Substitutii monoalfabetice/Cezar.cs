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
                decriptat += c;
            }
            return decriptat;
        }

    }
}
