using System.Collections.Generic;
using System.Linq;
namespace Domino
{

    public class JugadorBotaGorda : JugadorBasico
    {
        public JugadorBotaGorda(string nombre, int numEquipo) : base(nombre, numEquipo)
        {
        }

        public override void Jugar(Mesa mesa, Reglas reglas)
        {
            List<Ficha>[] fichas = GetPosiblesJugadas(this, mesa, reglas);

            Ficha mayor = new Ficha(-1, -1);

            int mayorScore = -1;

            foreach (var ficha in fichas[0].Concat(fichas[1]))
            {
                int score = reglas.CalcularScore(ficha);
                if (score > mayorScore)
                {
                    mayor = ficha;
                    mayorScore = score;
                }
            }

            Jugada jugada = new Jugada(this, mayor);

            if (fichas[0].Contains(mayor))
                jugada.jugoDerecha = false;
            if (fichas[1].Contains(mayor))
                jugada.jugoDerecha = true;
            this.Jugadas.Add(jugada);
        }
    }
}
