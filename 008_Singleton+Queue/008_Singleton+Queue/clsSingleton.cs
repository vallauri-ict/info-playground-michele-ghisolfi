using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Singleton_Queue
{
    class clsSingleton
    {
        public string val = "";
        private static clsSingleton instace = null;
        public static Queue<string> codaStampa = new Queue<string>();

        private clsSingleton()
        {

        }

        public void add (string s)
        {
            codaStampa.Enqueue(s);
            System.Windows.Forms.MessageBox.Show(s + " aggiunto alla coda");
        }

        public void stampa ()
        {
            try
            {
                string s = codaStampa.Dequeue();
                System.Windows.Forms.MessageBox.Show(s);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static clsSingleton GetClsSingleton()
        {
            if (instace == null)
            {
                instace = new clsSingleton();
            }
            return instace;
        }
    }
}
