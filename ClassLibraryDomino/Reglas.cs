using System.Collections.Generic;
namespace Domino
{
    public class Reglas
    {
        IFinalizador finalizador;

        public IValidador validador;

        ISiguienteJugador siguienteJugador;
        public int FichasPorMano { get; private set; }
        public int UltimNumero { get; private set; }

        
        IRepartidor repartidor;

        ICalculador calculador;

        public ICalculadorScore calculadorScore;

        public Reglas(IFinalizador finalizador, IValidador validador, ISiguienteJugador siguienteJugador, ICalculador calculador, IRepartidor repartidor,
            ICalculadorScore calculadorScore, int FichasPorMano, int UltimNumero)
        {
            this.finalizador = finalizador;
            this.validador = validador;
            this.siguienteJugador = siguienteJugador;
            this.calculador = calculador;
            this.UltimNumero = UltimNumero;
            this.repartidor = repartidor;
            this.FichasPorMano = FichasPorMano;
            this.calculadorScore = calculadorScore;
        }
        public bool GameOver(Mesa mesa, Juego juego, JugadorBasico jugador)
        {
            return this.finalizador.GameOver(mesa, juego, jugador);
        }

        public int CalcularPuntos(JugadorBasico jugador, ICalculadorScore calculadorScore)
        {
            return this.calculador.CalcularPuntos(jugador, calculadorScore);
        }
        public void Repartir(List<JugadorBasico> listJugadores, int fichaspormano, Mesa mesa)
        {

            this.repartidor.Repartir(listJugadores, fichaspormano, mesa);
            return;
        }

        public bool EsValida(int cara, int caraFicha)
        {
            return this.validador.EsValida(cara, caraFicha);
        }

        public int SiguienteJugador(List<JugadorBasico> jugadores, Ficha ficha)
        {
            return this.siguienteJugador.NextPlayer(jugadores, ficha);
        }

        public int CalcularScore(Ficha ficha)
        {
            return this.calculadorScore.CalcularScore(ficha);
        }
    }

}
