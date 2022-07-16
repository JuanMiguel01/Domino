using System.Collections.Generic;
using System.Linq;
namespace Domino
{

    public class Torneo
    {
        public List<Juego> juegos;
        public List<JugadorBasico> ganadores = new List<JugadorBasico>();
        ITorneoFinalizador finalizador;

        public Torneo(List<Juego> juegos, ITorneoFinalizador finalizador)
        {
            this.juegos = juegos;
            this.finalizador = finalizador;
        }

        public void IniciarTorneo()
        {
            Dictionary<JugadorBasico, int> tabla = new Dictionary<JugadorBasico, int>();

            foreach (var item in juegos)
            {
                item.Jugar();

                if (finalizador.TorneoGameOver(this))
                    break;
            }
        }
    }
}