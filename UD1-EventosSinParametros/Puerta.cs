using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo4ConsolaEventos
{
    internal class Puerta
    {
        public string Location { get; set; }

        // Definir el evento usando EventHandler
        public event EventHandler PuertaAbierta;

        public Puerta(string location)
        {
            Location = location;
        }

        public void Abierta()
        {
            Console.WriteLine($"Puerta del {Location} está abierta.");
            OnPuertaAbierta();
        }

        protected virtual void OnPuertaAbierta()
        {
            PuertaAbierta?.Invoke(this, EventArgs.Empty);
        }
    }
}
