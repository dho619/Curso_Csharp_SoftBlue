using System;

namespace Aula_6
{
    static class ExtensionQuartoHotel
    {
        public static void Expulsar(this QuartoHotel quarto, int numQuarto)
        {
            quarto.CancelarReserva();
        }
    }
}
