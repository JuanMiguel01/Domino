namespace Domino
{

    public class Jugada
    {
        public JugadorBasico jugador { get; private set; }
        public Ficha ficha { get; private set; }
        public bool jugoDerecha { get; set; }

        public Jugada(JugadorBasico jugador, Ficha ficha)
        {
            this.jugador = jugador;
            this.ficha = ficha;

        }
    }
}
