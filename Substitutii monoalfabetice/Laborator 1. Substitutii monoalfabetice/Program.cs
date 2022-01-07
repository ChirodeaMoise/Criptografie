using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_1._Substitutii_monoalfabetice
{
    class Program
    {

        static void Main(string[] args)
        {
            Cezar cezar = new Cezar();
            Console.WriteLine("Criptare prin cifrul lui Cezar:");
            Console.WriteLine(cezar.criptat);
            Console.WriteLine();
            string decriptat = cezar.Decriptare(cezar.criptat);
            Console.WriteLine(decriptat);

            Console.WriteLine();

            Console.Write("n=");
            CezarGeneralizat cezarGeneralizat = new CezarGeneralizat();
            Console.WriteLine("Criptare prin cifrul lui Cezar generalizat:");
            Console.WriteLine(cezarGeneralizat.criptat);
            Console.WriteLine();
            Console.WriteLine(cezarGeneralizat.Decriptare(cezarGeneralizat.criptat, cezarGeneralizat.n));
            Console.WriteLine();

            ROT13 rot13 = new ROT13();
            Console.WriteLine("Criptare prin ROT13:");
            Console.WriteLine(rot13.criptat);
            Console.WriteLine();
            Console.WriteLine(rot13.Decriptare(rot13.criptat));
            Console.WriteLine();


            Console.WriteLine("Criptarea prin cheie:");
            Console.Write("Introduceti un cuvant cheie: ");
            Substitutie sub = new Substitutie();
            Console.WriteLine(sub.criptat);


        }
    }
}
