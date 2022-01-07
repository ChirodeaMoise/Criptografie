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
        public string encrypted ;
        public AlgoritmSimetric()
        {
        }

        public int IntTrans(char c)
        {
            c = Char.ToLower(c);
            int result = 0;
            switch (c)
            {
                case 'a':
                    result = 1;
                    break;
                case 'b':
                    result = 2;
                    break;
                case 'c':
                    result = 3;
                    break;
                case 'd':
                    result = 4;
                    break;
                case 'e':
                    result = 5;
                    break;
                case 'f':
                    result = 6;
                    break;
                case 'g':
                    result = 7;
                    break;
                case 'h':
                    result = 8;
                    break;
                case 'i':
                    result = 9;
                    break;
                case 'j':
                    result = 10;
                    break;
                case 'k':
                    result = 11;
                    break;
                case 'l':
                    result = 12;
                    break;
                case 'm':
                    result = 13;
                    break;
                case 'n':
                    result = 14;
                    break;
                case 'o':
                    result = 15;
                    break;
                case 'p':
                    result = 16;
                    break;
                case 'q':
                    result = 17;
                    break;
                case 'r':
                    result = 18;
                    break;
                case 's':
                    result = 19;
                    break;
                case 't':
                    result = 20;
                    break;
                case 'u':
                    result = 21;
                    break;
                case 'v':
                    result = 22;
                    break;
                case 'w':
                    result = 23;
                    break;
                case 'x':
                    result = 24;
                    break;
                case 'y':
                    result = 25;
                    break;
                case 'z':
                    result = 26;
                    break;
                default:
                    break;

            }
            return result;
        }

    }
}
