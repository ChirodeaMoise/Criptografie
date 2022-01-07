using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class AlgoritmSimetric
    {
        public string text = "to die for liberty is a pleasure and not a pain."; //Markos Botsaris, Greek general, hero of the Greek War of Independence (21 August 1823), killed in action in attack on Karpenisi
        public string criptat;
        public AlgoritmSimetric()
        {
        }

        public int IntTrans(char c)
        {
            c = Char.ToLower(c);
            int rezultat = 0;
            switch (c)
            {
                case 'a':
                    rezultat = 1;
                    break;
                case 'b':
                    rezultat = 2;
                    break;
                case 'c':
                    rezultat = 3;
                    break;
                case 'd':
                    rezultat = 4;
                    break;
                case 'e':
                    rezultat = 5;
                    break;
                case 'f':
                    rezultat = 6;
                    break;
                case 'g':
                    rezultat = 7;
                    break;
                case 'h':
                    rezultat = 8;
                    break;
                case 'i':
                    rezultat = 9;
                    break;
                case 'j':
                    rezultat = 10;
                    break;
                case 'k':
                    rezultat = 11;
                    break;
                case 'l':
                    rezultat = 12;
                    break;
                case 'm':
                    rezultat = 13;
                    break;
                case 'n':
                    rezultat = 14;
                    break;
                case 'o':
                    rezultat = 15;
                    break;
                case 'p':
                    rezultat = 16;
                    break;
                case 'q':
                    rezultat = 17;
                    break;
                case 'r':
                    rezultat = 18;
                    break;
                case 's':
                    rezultat = 19;
                    break;
                case 't':
                    rezultat = 20;
                    break;
                case 'u':
                    rezultat = 21;
                    break;
                case 'v':
                    rezultat = 22;
                    break;
                case 'w':
                    rezultat = 23;
                    break;
                case 'x':
                    rezultat = 24;
                    break;
                case 'y':
                    rezultat = 25;
                    break;
                case 'z':
                    rezultat = 26;
                    break;
                default:
                    break;

            }
            return rezultat;
        }

    }
}
