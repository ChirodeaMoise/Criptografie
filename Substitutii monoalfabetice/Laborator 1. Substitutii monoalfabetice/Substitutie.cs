using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class Substitutie : AlgoritmSimetric
    {
        public string word = Console.ReadLine();

        public Substitutie()
        {
            word = DeleteDuplicates(word);
            Console.WriteLine(word);
            word = Key(word);
            Console.WriteLine(word);
            encrypted = Encryption(text, word);
            Console.WriteLine(encrypted);
            encrypted = Spacing(encrypted);
        }


        public string DeleteDuplicates(string word)
        {
            string result = "";
            List<char> list = new List<char>();
            for (int i = 0; i < word.Length; i++)
                if (!list.Contains(word[i]))
                    list.Add(word[i]);

            foreach (char item in list)
                result += item;

            return result;
        }

        public string Key(string word)
        {
            string aux = "";
            string result = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length; i++)
                if (!word.Contains(alphabet[i]))
                    aux += alphabet[i];
            result = word + aux;
            return result;
        }

        public string Encryption(string text, string word)
        {
            string encrypted = "";
            char w;
            for (int i = 0; i < text.Length; i++)
            {
                w = text[i];
                if (Char.IsLetter(w))
                {
                    w = word[IntTrans(w) - 1];
                }
                encrypted += w;
            }
            return encrypted;
        }

        public string Spacing(string encrypted)
        {
            string result = "";
            foreach (char item in encrypted)
            {
                if (Char.IsLetter(item))
                    result += item;
            }

            for (int i = 0; i <= result.Length; i++)
            {
                if (i % 6 == 0)
                    result = result.Insert(i, " ");
            }
            return result;
        }

    }
}
