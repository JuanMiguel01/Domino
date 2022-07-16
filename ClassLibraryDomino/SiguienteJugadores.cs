using System.Collections.Generic;
namespace Domino
{

    public class SiguienteJugador_Usual : ISiguienteJugador
    {
        int indiceJugadoractual;
        int cantidadDeJugadores;
        public SiguienteJugador_Usual(int indiceJugadoractual, int cantidadDeJugadores)
        {
            this.indiceJugadoractual = indiceJugadoractual;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }
        public int NextPlayer(List<JugadorBasico> jugadores, Ficha ficha)
        {
            if (indiceJugadoractual < cantidadDeJugadores)
                return (indiceJugadoractual++);
            else
            {
                indiceJugadoractual = 1;
                return 0;
            }
        }
    }
    public class SiguienteJugador_InvierteOrden : ISiguienteJugador
    {
        int indiceJugadoractual;
        int cantidadDeJugadores;
        public SiguienteJugador_InvierteOrden(int indiceJugadoractual, int cantidadDeJugadores)
        {
            this.indiceJugadoractual = indiceJugadoractual;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }
        public int NextPlayer(List<JugadorBasico> jugadores, Ficha ficha)
        {


            if (ficha.First == -1 && ficha.Second == -1)
            {
                jugadores.Reverse();

                indiceJugadoractual = cantidadDeJugadores - indiceJugadoractual + 1;

            }
            if (indiceJugadoractual < cantidadDeJugadores)
                return (indiceJugadoractual++);
            else
            {
                indiceJugadoractual = 1;
                return 0;
            }
        }
    }
}