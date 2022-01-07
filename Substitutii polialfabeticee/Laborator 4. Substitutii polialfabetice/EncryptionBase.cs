using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_4._Substitutii_polialfabetice
{
    public abstract class EncryptionBase
    {
        public abstract string Encrypt(string toEncryptText);

        public abstract string Decrypt(string toDecryptText);
    }
}
