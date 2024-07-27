using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo4ConsolaEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de puertas y la alarma
            Puerta PuertaSalon = new Puerta("Salón");
            Alarma CasaAlarma = new Alarma();

            // Suscribirse a los eventos
            PuertaSalon.PuertaAbierta += CasaAlarma.OnPuertaAbierta;

            // Simular la apertura de la puerta y la ventana
            PuertaSalon.Abierta();
           
        }
    }
}
