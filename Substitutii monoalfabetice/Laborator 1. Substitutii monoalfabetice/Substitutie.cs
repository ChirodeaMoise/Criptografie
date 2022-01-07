using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class Substitutie : AlgoritmSimetric
    {
        public string cuvant = Console.ReadLine();

        public Substitutie()
        {
            cuvant = StergereDubluri(cuvant);
            Console.WriteLine(cuvant);
            cuvant = Cheie(cuvant);
            Console.WriteLine(cuvant);
            criptat = Criptare(text, cuvant);
            Console.WriteLine(criptat);
            criptat = Spatiere(criptat);
        }


        public string StergereDubluri(string cuvant)
        {
            string rezultat = "";
            List<char> lista = new List<char>();
            for (int i = 0; i < cuvant.Length; i++)
                if (!lista.Contains(cuvant[i]))
                    lista.Add(cuvant[i]);

            foreach (char item in lista)
                rezultat += item;

            return rezultat;
        }

        public string Cheie(string cuvant)
        {
            string aux = "";
            string rezultat = "";
            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alfabet.Length; i++)
                if (!cuvant.Contains(alfabet[i]))
                    aux += alfabet[i];
            rezultat = cuvant + aux;
            return rezultat;
        }

        public string Criptare(string text, string cuvant)
        {
            string criptat = "";
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];
                if (Char.IsLetter(c))
                {
                    c = cuvant[IntTrans(c) - 1];
                }
                criptat += c;
            }
            return criptat;
        }

        public string Spatiere(string criptat)
        {
            string rezultat = "";
            foreach (char item in criptat)
            {
                if (Char.IsLetter(item))
                    rezultat += item;
            }

            for (int i = 0; i <= rezultat.Length; i++)
            {
                if (i % 6 == 0)
                    rezultat = rezultat.Insert(i, " ");
            }
            return rezultat;
        }

    }
}
