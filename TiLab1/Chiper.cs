using System;

namespace TiLab1
{
    public abstract class Chiper
    {
        public abstract string Encrypt(string text, string key);
        public abstract string Decrypt(string chiptext, string key);

        public string abc;
        public string ABC
        {
            get
            {
                return abc;
            }

            set
            {
                abc = value;
            }
        }
    }
}
