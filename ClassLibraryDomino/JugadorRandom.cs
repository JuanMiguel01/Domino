using System.Linq;
using System.Collections.Generic;
using System;
namespace Domino
{

    public class JugadorRandom : JugadorBasico
    {
        public JugadorRandom(string nombre, int numEquipo) : base(nombre, numEquipo)
        {
        }
        public override void Jugar(Mesa mesa, Reglas reglas)
        {
            List<Ficha>[] posiblesJugadas = GetPosiblesJugadas(this, mesa, reglas);

            Random random = new Random();

            List<Ficha> todas = posiblesJugadas[0].Concat(posiblesJugadas[1]).ToList();

            int posFicha = random.Next(todas.Count());

            Ficha ficha = todas.ElementAt(posFicha);

            if (todas.Count != 0)
            {
                Jugada jugada = new Jugada(this, ficha );

                if(posiblesJugadas[1].Contains(ficha))
                jugada.jugoDerecha = true;

                this.Jugadas.Add(jugada);
            }
           
        }
    }
}
