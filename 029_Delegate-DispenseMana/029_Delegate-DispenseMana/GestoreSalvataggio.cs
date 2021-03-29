using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _029_Delegate_DispenseMana
{
    // DICHIARO il mio delegato
    public delegate void salvataggioEseguitoEventHandler(int id);

    class GestoreSalvataggio
    {
        // dichiaro l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void salvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");

            salvataggioEseguito(id);
        }


    }
}
