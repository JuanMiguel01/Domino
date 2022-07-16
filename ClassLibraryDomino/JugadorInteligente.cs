using System.Collections.Generic;
using System.Linq;

namespace Domino
{
    public class JugadorInteligente : JugadorBasico
    {
        public JugadorInteligente(string nombre, int numEquipo) : base(nombre, numEquipo)
        {
        }
        public override void Jugar(Mesa mesa, Reglas reglas)
        {
            List<Ficha>[] posiblesJugadas = GetPosiblesJugadas(this, mesa, reglas);

            if (posiblesJugadas[0].Count > posiblesJugadas[1].Count)
            {
                Jugada jugada = new Jugada(this, posiblesJugadas[0].First());

                jugada.jugoDerecha = false;

                this.Jugadas.Add(jugada);
            }


            else
            {
                Jugada jugada = new Jugada(this, posiblesJugadas[1].First());

                jugada.jugoDerecha = true;

                this.Jugadas.Add(jugada);
              
            }
        }
    }
}
