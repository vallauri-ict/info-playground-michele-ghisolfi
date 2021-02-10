using System;

namespace _025_Interfacce
{
    interface IDispAggiuntivo
    {
        int id { get; set; }
        Boolean status { get; }

        void connetti(string s);

        void disconnetti(string s);
    }
}
