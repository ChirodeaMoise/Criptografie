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
            #region Cezar
            Cezar cezar = new Cezar();
            Console.WriteLine("- Criptare prin cifrul lui Cezar -");
            Console.WriteLine();
            Console.Write("encrypted> "); Console.Write(cezar.encrypted);
            Console.WriteLine();
            string decrypted = cezar.Decryption(cezar.encrypted);
            Console.Write("plaintext> "); Console.WriteLine(decrypted);
            #endregion

            Console.Write("------------------------------------------------------------");
            Console.WriteLine();
            #region CezarGeneralizat
            Console.WriteLine("- Criptare prin cifrul lui Cezar generalizat -");
            Console.Write("Introduceti valori lui n=");
            CezarGeneralizat cezarGeneralizat = new CezarGeneralizat();

            Console.Write("encrypted> "); Console.WriteLine(cezarGeneralizat.encrypted);
            Console.Write("decrypted> "); Console.WriteLine(cezarGeneralizat.Decryption(cezarGeneralizat.encrypted, cezarGeneralizat.n));
            Console.WriteLine();
            #endregion

            Console.Write("------------------------------------------------------------");
            Console.WriteLine();
            #region ROT13
            ROT13 rot13 = new ROT13();
            Console.WriteLine();
            Console.WriteLine("- Criptare prin ROT13 -");
            Console.Write("encrypted> "); Console.WriteLine(rot13.encrypted);
            Console.Write("decrypted> "); Console.WriteLine(rot13.Decryption(rot13.encrypted));
            Console.WriteLine();
            #endregion

            Console.Write("------------------------------------------------------------");
            Console.WriteLine();
            #region Substitutie
            Console.WriteLine("- Criptarea prin cheie -");
            Console.Write("Introduceti un cuvant cheie: ");
            Substitutie sub = new Substitutie();
            Console.Write("encrypted> "); Console.WriteLine(sub.encrypted);
            #endregion

        }
    }
}
