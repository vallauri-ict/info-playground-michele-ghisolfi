using System;
using System.Collections.Generic;

namespace _020_Scopa
{
    class Mazzo
    {
        private List<Carta> mazzo = new List<Carta>();

        public Mazzo()
        {
            creaMazzo();
            mazzo = mescola(mazzo);
        }

        public void creaMazzo()
        {
            string[] semi = { "coppe", "denari", "bastoni", "spade" };
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Carta carta = new Carta(i, semi[j]);
                    mazzo.Add(carta);
                }
            }
        }

        public List<Carta> mescola(List<Carta> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int k = rnd.Next(0, i);
                Carta value = list[k];
                list[k] = list[i];
                list[i] = value;
            }
            return list;
        }

        public Carta estrai (List<Carta> list)
        {
            Random rnd = new Random();
            int val = rnd.Next(0, list.Count);
            Carta card = mazzo[val];
            mazzo.RemoveAt(val);

            return card;
        }


    }
}
