using System.Collections.Generic;

namespace _020_Scopa
{
    class Giocatore
    {
        private string nome;
        Mano mano;
        List<Mano> prese = new List<Mano>();

        public Giocatore(string n)
        {
            this.nome = n;
            mano = new Mano();
            prese.Clear();
        }

        public Mano Lettura()
        {
            return mano;
        }

        public List<Mano> Prese()
        {
            return prese;
        }

        public void Gioca(int i)
        {
            Carta giocata = mano.Gioca(i);
        }
    }
}
