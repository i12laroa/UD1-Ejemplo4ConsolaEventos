using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo4ConsolaEventos
{
    internal class Alarma
    {
        public void OnPuertaAbierta(object sender, PuertaEventArgs e)
        {
            Console.WriteLine($"Alarma: Puerta abierta del {e.Location}. Activando Alarma !!!!");
        }
    }
}
