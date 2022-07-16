using System.Linq;
namespace Domino
{

    public class TorneoGameOver_Usual : ITorneoFinalizador
    {
        public bool TorneoGameOver(Torneo torneo)
        {
            int juegosAGanar = torneo.juegos.Count / 2 + 1;

            foreach (var jugador in torneo.juegos.First().jugadores)
            {
                int cantJuegosGanados = 0;

                foreach (var item in torneo.juegos)
                {

                    if (item.ganadores.Count != 0 &&
                     jugador.numEquipo.Equals(item.ganadores.First().numEquipo))
                        cantJuegosGanados++;
                }

                if (cantJuegosGanados == juegosAGanar)
                {
                    torneo.ganadores.Add(jugador);
                    return true;
                }

            }

            return false;
        }
    }

    public class TorneoGameOver_Pollona : ITorneoFinalizador
    {
        public bool TorneoGameOver(Torneo torneo)
        {
            int juegosAGanar = torneo.juegos.Count / 2 + 1;

            foreach (var jugador in torneo.ganadores)
            {
                int cantJuegosGanados = 0;
                int cantPtosContrario = 0;

                foreach (var item in torneo.juegos)
                {

                    if (item.ganadores.Count != 0 &&
                     jugador.numEquipo.Equals(item.ganadores.First().numEquipo))
                        cantJuegosGanados++;
                }

                if (cantJuegosGanados == juegosAGanar)
                {
                    torneo.ganadores.Add(jugador);
                    return true;
                }


                foreach (var item in torneo.ganadores)
                {
                    if (!jugador.numEquipo.Equals(item.numEquipo))
                        cantPtosContrario += jugador.cantPuntos;
                }

                if (cantPtosContrario >= 100)
                {
                    torneo.ganadores.Add(jugador);
                    return true;
                }
            }

            return false;
        }
    }
}
