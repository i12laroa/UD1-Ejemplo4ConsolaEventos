using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo4ConsolaEventos
{
    internal class PuertaEventArgs : EventArgs
    {
        public string Location { get; set; }

        public PuertaEventArgs(string location)
        {
            Location = location;
        }
    }
}
