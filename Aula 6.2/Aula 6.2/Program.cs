using System;

namespace Aula_6
{
    class Program
    {
        static void Main(string[] args)
        {
            QuartoHotel q = new QuartoHotel();
            q.Numero = 102;
            q.Andar = 1;
            q.Fumante = false;
            q.Reservar();
            q.CancelarReserva();
            q.Expulsar(12);
        }
    }
}
